using System;
using System.Collections.Generic;
  
using System.Text;
  

namespace RemitaDDMandateSDK.Net.Remita.DDMandate.ValidateOTP
{
    public class ValidateOTPPayload
    {
        public string remitaTransRef { get; set; }
        public string card { get; set; }
        public string otp { get; set; }
    }
}
