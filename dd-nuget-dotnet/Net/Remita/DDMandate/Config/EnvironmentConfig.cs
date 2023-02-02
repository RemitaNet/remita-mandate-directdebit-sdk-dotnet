using System;
using System.Collections.Generic;
using System.Text;

namespace RemitaDDMandateSDK.Net.Remita.DDMandate.Config
{
    class EnvironmentConfig
    {
        public static string TEST = "https://remitademo.net/";
        public static string PRODUCTION = "https://login.remita.net/";
        public static string MANDATE_ACTIVATE_VALIDATE_OTP = "/remita/exapp/api/v1/send/api/echannelsvc/echannel/mandate/validateAuthorization";

        //     public static string setupMandatePath = "/remita/exapp/api/v1/send/api/echannelsvc/echannel/mandate/setup";

        // public static string mandateStatusPath = "/remita/exapp/api/v1/send/api/echannelsvc/echannel/mandate/status";

        // public static string mandateActivateRequestOTPPath = "/remita/exapp/api/v1/send/api/echannelsvc/echannel/mandate/requestAuthorization";

        //   public static string sendDebitInstructionPath = "/remita/exapp/api/v1/send/api/echannelsvc/echannel/mandate/payment/send";

        // public static string debitStatusPath = "/remita/exapp/api/v1/send/api/echannelsvc/echannel/mandate/payment/status";

        //public static string cancelDebitInstructionPath = "/remita/exapp/api/v1/send/api/echannelsvc/echannel/mandate/payment/stop";

        // public static string mandatePaymentHistoryPath = "/remita/exapp/api/v1/send/api/echannelsvc/echannel/mandate/payment/history";

        // public static string stopMandatePath = "/remita/exapp/api/v1/send/api/echannelsvc/echannel/mandate/stop";

        //  public static string mandateFormPath = "/remita/ecomm/mandate/form/{{merchantId}}/{{hash}}/{{mandateId}}/{{requestId}}/rest.reg";


        public static string GenerateUniqueID()
        {
            string uniqueId = Guid.NewGuid().ToString("N");
            string newUniqueId = uniqueId.Replace('a', '2').Replace('b', '3').Replace('c', '5').Replace('d', '7').Replace('e', '9').Replace('f', '1');
            return newUniqueId;
        }
    }
}
