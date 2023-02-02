using System;
using System.Collections.Generic;
using System.Text;
using RemitaDDMandateSDK.Net.Remita.DDMandate.Config;
using Newtonsoft.Json;
using RemitaDDMandateSDK.Net.Remita.DDMandate.ValidateOTP;

namespace RemitaDDMandateSDK.Net.Remita.DDMandate
{
    public class TestRemitaDDMandateSDKServices
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#########################################################");
            Console.WriteLine("## INITIALIZING REMITA PAYMENT CREDENTIALS AND GATEWAY ##");
            Console.WriteLine("#########################################################");
            Console.WriteLine(" ");

            Console.WriteLine("#################################");
            Console.WriteLine("###### SETTING ENVIRONMENT ######");
            Console.WriteLine("#################################");
            Console.WriteLine(" ");
            RemitaDDMandateAPI remitaDDMandateAPI = new RemitaDDMandateAPI(EnvironmentConfig.TEST);
            remitaDDMandateAPI.merchantId = "27768931";
            remitaDDMandateAPI.serviceTypeId = "35126630";
            remitaDDMandateAPI.apiKey = "Q1dHREVNTzEyMzR8Q1dHREVNTw==";
            remitaDDMandateAPI.apiToken = "SGlQekNzMEdMbjhlRUZsUzJCWk5saDB6SU14Zk15djR4WmkxaUpDTll6bGIxRCs4UkVvaGhnPT0=";
            remitaDDMandateAPI.amount = "1000";

            Console.WriteLine("++++ ENVIRONMENT BASE URL: " + remitaDDMandateAPI.baseUrl);

            Console.WriteLine(" ");
            Console.WriteLine("#############################");
            Console.WriteLine("###### Validate OTP ######");
            Console.WriteLine("#############################");
            Console.WriteLine(" ");
            ValidateOTPPayload validateOTPPayload = new ValidateOTPPayload();
            validateOTPPayload.username = "14Q1MI1GTOBGC6VN";
            validateOTPPayload.password = "NK3KY481WLUW53CQ1Y2NOXRFZTDWH7JF";
            ValidateOTPResponseData validateOTPResponseData = remitaDDMandateAPI.validateOTP(validateOTPPayload);
            Console.WriteLine("++++ RESPONSE: " + JsonConvert.SerializeObject(validateOTPResponseData));
            Console.WriteLine(" ");
            string accessToken = generateTokenResponseData.data[0].accessToken;
            //Console.WriteLine("++++ ACCESS TOKEN: " + accessToken);

                      
        }

        public static string generateUniqueID()
        {
            string uniqueId = Guid.NewGuid().ToString("N");           
            string newUniqueId = uniqueId.Replace('a', '2').Replace('b', '3').Replace('c', '5').Replace('d', '7').Replace('e', '9').Replace('f', '1');
            return newUniqueId;
        }

    }
}
