using AutomationPraticeRegistrationNegativeTests.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationPraticeRegistrationNegativeTests.Factories
{
    public class FormFactory
    {
        public static FormModel Create()
        {
            return new FormModel
            {
                FirstName = "SomeName",
                LastName = "SomeLastName",
                PasswordField = "SomePassword",
                Address1 = "Some Address 11 fl 3",
                City ="SomeCity",
                State = 1,
                ZipCode = "22114",
                MobilePhone = "1112233334",
                AssignAnAddresAlias = "Some Address 15"
            };
        }
    }
}
