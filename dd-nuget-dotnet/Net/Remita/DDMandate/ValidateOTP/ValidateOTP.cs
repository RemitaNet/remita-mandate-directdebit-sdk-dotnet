

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using System;
using System.Collections.Generic;

using System.Text;
using RemitaDDMandateSDK.Net.Remita.DDMandate.Config;

namespace RemitaDDMandateSDK.Net.Remita.DDMandate.ValidateOTP
{
    class ValidateOTP
    {
        private ValidateOTPResponseData result;

        private string baseUrl;
        public ValidateOTP(string baseUrl)
        {
            this.baseUrl = baseUrl;
        }

        public ValidateOTPResponseData validateOTP(ValidateOTPPayload accountEnquiryPayload, string accessToken)
        {
            ValidateOTPResponseData altResult = new ValidateOTPResponseData();
            {
                try
                {
                    //URL
                    string url = baseUrl + EnvironmentConfig.MANDATE_ACTIVATE_VALIDATE_OTP;

                    //HEADERS
                    List<Header> headers = new List<Header>();
                    headers.Add(new Header { header = "Content-Type", value = "application/json" });
                    string token = "Bearer " + accessToken;
                    headers.Add(new Header { header = "Authorization", value = token });

                    var body = new
                    {
                        sourceAccount = accountEnquiryPayload.sourceAccount,
                        sourceBankCode = accountEnquiryPayload.sourceBankCode
                    };

                    var response = WebClientUtil.PostResponse(url, JsonConvert.SerializeObject(body), headers);
                    result = JsonConvert.DeserializeObject<ValidateOTPResponseData>(response);
                
                } catch (Exception ex)
                {
                    ex.ToString();
                }
                return result;
            }

        }
    }
}
