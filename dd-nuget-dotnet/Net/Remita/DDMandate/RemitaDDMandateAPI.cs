using System;
using System.Collections.Generic;
using System.Text;

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

     public ValidateOTPResponseData validateOTP(ValidateOTPPayload validateOTPPayload)
     {
            ValidateOTP validateOTP = new ValidateOTP(baseUrl);
            return validateOTP.validateOTP(validateOTPPayload);
     }
    }
}
