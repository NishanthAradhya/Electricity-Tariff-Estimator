using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Interface
{
    public interface ITariffBLL
    {
        public List<TariffBO> GetEstimation(int consumption);
    }
}
