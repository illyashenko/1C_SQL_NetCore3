using System.Collections.Generic;

namespace ForOneCSQLAppNC3.Service
{
    public interface IServiceSQL
    {
        public List<object> SendRequest(JSONParametrs textRequest);
    }
}
