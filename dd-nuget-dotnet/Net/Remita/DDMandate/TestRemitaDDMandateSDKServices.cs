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
            validateOTPPayload.remitaTransRef = "1675364633046";
            validateOTPPayload.card = "0441234567890";
            validateOTPPayload.otp = "1234";
            string response = remitaDDMandateAPI.validateOTP(validateOTPPayload);
            Console.WriteLine("++++ RESPONSE: " + response);
           
            Console.ReadLine();
        }

    }
}
