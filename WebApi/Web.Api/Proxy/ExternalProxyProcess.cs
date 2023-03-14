using System.Text.Json;

namespace Proxy
{
    public class ExternalProxyProcess : IExternalProxyProcess
    {
        public List<ProductDTO> GetExternalTariffData()
        {
            
           var source = new List<ProductDTO>();
                

            //Should call the External Tariff Provider using our ApiHelper
            //As i dont have the URL i will be extracting the data from JSON file instead of mocking the object 

            //using (HttpResponseMessage responseMessage=  ApiHelper.ClientApi.GetAsync(url))
            //{

            //}
            using (StreamReader r = new StreamReader("ExternalTariff.json"))
            {
                string json = r.ReadToEnd();
                source = JsonSerializer.Deserialize<List<ProductDTO>>(json);
            }
            return source;
        }

    }
}