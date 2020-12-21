using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForOneCSQLAppNC3.Service
{
    public interface IServiceAPI
    {
        public List<dynamic> GetData(JSONParametrs Request);
    }
}
