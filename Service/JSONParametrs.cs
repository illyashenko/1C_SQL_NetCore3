using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForOneCSQLAppNC3.Service
{
    public class JSONParametrs
    {
        public string QueryString { get; set; }
        public string ConnectionString { get; set; }
        public int TimeOutInSecond { get; set; }
        public bool StoredProcedure { get; set; }
        public string PricedureName { get; set; }
        public Dictionary<string, string> ProcedureParam { get; set; } 
    }
}
