# Remita Direct Debit/Mandate .NET SDK
.NET SDK for Remita Direct Debit/Mandate Service.

## Prerequisites
The workflow to getting started on RITs is as follows:

*  Register a profile on Remita: You can visit [Remita](https://login.remita.net) to sign-up if you are not already registered as a merchant/biller on the platform.
*  Receive the Remita credentials that certify you as a Biller: Remita will send you your merchant ID and an API Key necessary to secure your handshake to the Remita platform.
## Requirements
*  Microsoft Visual Studio 
* .NET 2.0 or later

## Running the application
*  Clone project, review and run:
   https://github.com/RemitaNet/remita-mandate-directdebit-sdk-dotnet/blob/main/dd-nuget-dotnet/Net/Remita/DDMandate/TestRemitaDDMandateSDKServices.cs

**Sample Demo Code:**
```java
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
	
```

## Useful links
* Join our Slack channel at http://bit.ly/RemitaDevSlack
    
## Support
- For all other support needs, support@remita.net
