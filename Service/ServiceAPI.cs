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
        public List<object> GetData(JSONParametrs request)
        {
            if (request.TimeOutInSecond == 0 || request.ConnectionString == string.Empty || request.QueryString == string.Empty) 
                return null;

            var answer = ServiceSQL.SendRequest(request);
            return answer;
        }
    }
}
