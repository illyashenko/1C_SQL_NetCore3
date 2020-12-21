using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForOneCSQLAppNC3.Service
{
    public class ServiceAPI : IServiceAPI
    {
        IServiceSQL ServiceSQL;

        public ServiceAPI(IServiceSQL serviceSQL)
        {
            ServiceSQL = serviceSQL;
        }
        public List<dynamic> GetData(JSONParametrs Request)
        {
            if (Request.TimeOutInSecond == 0
                   || Request.ConnectionString == string.Empty
                       || Request.StringRequest == string.Empty)
            {
                return null;
            }

            var answer = ServiceSQL.SendRequest(Request);

            return answer;
        }
    }
}
