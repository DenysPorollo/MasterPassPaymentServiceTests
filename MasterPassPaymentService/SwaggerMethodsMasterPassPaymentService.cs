using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterPassPaymentService
{
    public static class SwaggerMethodsMasterPassPaymentService
    {
        public static string Check(string guid)
        {
            string relativeUrl = "/api/Payment/Check";

            return SwaggerHelper.RequestHelper.CommitGetRequest(String.Format("{0}{1}?guid={2}", SwaggerUrl.serviceUrlQR, relativeUrl, guid));
        }
        public static string Purchase(string guid, string uniqueId, Int32 filialId, string posName, string poS_IP, string frNumber, Int32 zId, Int32 localChequeId, double amount, string uuid)
        {
            string relativeUrl = "/api/Payment/Purchase";

            var v = new
            {
                guid,
                uniqueId,
                filialId,
                posName,
                poS_IP,
                frNumber,
                zId,
                localChequeId,
                amount,
                uuid

            };


            return SwaggerHelper.RequestHelper.CommitPostRequest(SwaggerUrl.serviceUrlQR + relativeUrl, JsonConvert.SerializeObject(v));
        }
    }
}
