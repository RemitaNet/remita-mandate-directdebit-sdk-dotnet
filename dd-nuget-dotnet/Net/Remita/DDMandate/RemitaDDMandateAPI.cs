using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RemitaDDMandateSDK.Net.Remita.DDMandate.Config;
using RemitaDDMandateSDK.Net.Remita.DDMandate.ValidateOTP;

namespace RemitaDDMandateSDK.Net.Remita.DDMandate
{
    public class RemitaDDMandateAPI
    {
        public string baseUrl { get; set; }
        public string merchantId { get; set; }
        public string serviceTypeId { get; set; }
        public string apiKey { get; set; }
        public string apiToken { get; set; }
        public string amount { get; set; }

        public RemitaDDMandateAPI(string environment)
        {
            if (string.IsNullOrEmpty(environment))
            {
                baseUrl  =  EnvironmentConfig.TEST;
            }
            else
            {
              baseUrl =  environment;
            }
        }

     public string validateOTP(ValidateOTPPayload validateOTPPayload)
     {
            string response = null;
            try
            {
                //URL
                string url = baseUrl + EnvironmentConfig.MANDATE_ACTIVATE_VALIDATE_OTP;
                string requestId = EnvironmentConfig.GenerateUniqueID();
                string hash = Util.WebClientUtil.SHA512(apiKey + requestId + apiToken);
                string date = DateTime.Now.ToString("yyyy-dd-MM");
                string time = DateTime.Now.ToString("HH:mm:ss");

                string requestTS = date+"T"+time+ "+000000";//

                //HEADERS
                List<Header> headers = new List<Header>();
                headers.Add(new Header { header = "Content-Type", value = "application/json" });
                headers.Add(new Header { header = "MERCHANT_ID", value = merchantId });
                headers.Add(new Header { header = "API_KEY", value = apiKey });
                headers.Add(new Header { header = "REQUEST_ID", value = requestId });
                headers.Add(new Header { header = "REQUEST_TS", value = requestTS });
                headers.Add(new Header { header = "API_DETAILS_HASH", value = hash });

                List<AuthParams> authParams = new List<AuthParams>();
                AuthParams authParam1 = new AuthParams();
                authParam1.param1 = "OTP";
                authParam1.value = validateOTPPayload.otp;
                authParams.Add(authParam1);

                AuthParams authParam2 = new AuthParams();
                authParam2.param2 = "CARD";
                authParam2.value = validateOTPPayload.card;
                authParams.Add(authParam2);

                var body = new
                {
                    remitaTransRef = validateOTPPayload.remitaTransRef,
                    authParams = authParams
                };
                
                response = Util.WebClientUtil.PostResponse(url, JsonConvert.SerializeObject(body), headers);
                String result = response.Substring(7, response.Length);
                response = result.Substring(0, result.Length - 1);
               
             }
             catch (Exception ex)
             {
                    ex.ToString();
             }

             return response;
     }

    }
}
