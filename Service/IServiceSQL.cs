using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForOneCSQLAppNC3.Service
{
    public interface IServiceSQL
    {
        public List<dynamic> SendRequest(JSONParametrs TextRequest);
    }
}
