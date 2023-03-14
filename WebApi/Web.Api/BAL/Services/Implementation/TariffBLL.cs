using Proxy;
using AutoMapper;
using BLL.Services.Interface;

namespace BLL.Services.Implementation
{
    public class TariffBLL : ITariffBLL
    {
        private readonly IExternalProxyProcess _proxyExternal;
        private Mapper _productMapper;
        public TariffBLL(IExternalProxyProcess proxyExternal)
        {
            _proxyExternal = proxyExternal;
            var _configProduct = new MapperConfiguration(cfg => cfg.CreateMap<ProductDTO, ProductBO>().ReverseMap());
            _productMapper = new Mapper(_configProduct);
            ApiHelper.InitializeClient();
        }
        public List<TariffBO> GetEstimation(int consumption)
        {
            try
            {
                List<ProductDTO> items = _proxyExternal.GetExternalTariffData();

                if (items.Count == 0)
                    throw new Exception("No Products available");

                List<ProductBO> productList = _productMapper.Map<List<ProductDTO>, List<ProductBO>>(items);
                return getEstimatedTariffs(productList, consumption);
            }
            catch (Exception ex)
            {
                throw new Exception( ex.Message);
            }

        }
        private List<TariffBO> getEstimatedTariffs(List<ProductBO> products, int data)
        {
            List<TariffBO> tariffs = new List<TariffBO>();
            foreach (ProductBO product in products)
            {
                tariffs.Add(calculateElectricityTariff(product, data));
                
            }
            return tariffs;
        }

        private TariffBO calculateElectricityTariff(ProductBO product, int data)
        {
            int totalCost;
            if (product.IncludedKwh == 0)
                totalCost = product.BaseCost * 12 + data * product.AdditionalKwhCost / 100;
            else
                totalCost= data <= product.IncludedKwh ? product.BaseCost : product.BaseCost + (data - product.IncludedKwh) * product.AdditionalKwhCost / 100;                

            return new TariffBO() { EstimatedAnnualCost = totalCost, ProductName = product.Name };

        }
    }

    
}