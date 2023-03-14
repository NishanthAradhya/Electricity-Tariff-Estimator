using AutoMapper;
using BLL;
using BLL.Services.Implementation;
using BLL.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Proxy;
using Web.Api.Models;

namespace Web.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TariffController : Controller
    {
        private Mapper _tariffMapper;
        private readonly ITariffBLL _tariffBLL;
        public TariffController(ITariffBLL tariffBLL) 
        {
            _tariffBLL = tariffBLL;
            var _configTariff = new MapperConfiguration(cfg => cfg.CreateMap<TariffBO, Tariff>().ReverseMap());
            _tariffMapper = new Mapper(_configTariff);
        }

        [HttpGet]
        [Route("Estimation")]
        public ActionResult<Tariff> GetEstination(int consumption)
        {
            List<TariffBO> data;
            try
            {
                if(consumption == 0) { return NotFound("Consumption cannot be 0"); }

                data = _tariffBLL.GetEstimation(consumption);
                List<Tariff> productList = _tariffMapper.Map<List<TariffBO>, List<Tariff>>(data);
                if (data == null)
                {
                    return NotFound("No Products");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return  Ok(data);
        }
    }
}
