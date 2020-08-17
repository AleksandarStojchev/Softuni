using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationPraticeRegistrationNegativeTests.Models
{
   public class FormModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailFieldFromRegistration { get; set; }
        public string PasswordField { get; set; }
        public string Address1 { get; set; }
        public string City { get; set; }
        public int State { get; set; }
        public int? ZipCode { get; set; }
        public int? Country { get; set; }
        public int? MobilePhone { get; set; }
        public string AssignAnAddresAlias { get; set; }



    }
}
