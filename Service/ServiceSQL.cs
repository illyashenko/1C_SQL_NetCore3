using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using Dapper;
using System.Data;

namespace ForOneCSQLAppNC3.Service
{
    public class ServiceSQL : IServiceSQL
    {
        public List<object> SendRequest(JSONParametrs request)
        {
            var Result = new List<object>();

            using (IDbConnection dbConnection = new SqlConnection(request.ConnectionString))
            {
                dbConnection.Open();

                if (!request.StoredProcedure)
                    Result = dbConnection.Query<object>(request.QueryString, null, null, true, request.TimeOutInSecond).ToList();
                else
                {
                    var param = new DynamicParameters();
                    foreach (KeyValuePair<string, string> keyValue in request.ProcedureParam)
                        param.Add(keyValue.Key, keyValue.Value);
                    var ans = dbConnection.Query<object>(request.QueryString, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                }
            }

            return Result;
        }
    }
}
