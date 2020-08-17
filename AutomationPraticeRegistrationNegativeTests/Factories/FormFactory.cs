using AutoFixture;
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
            var fixture = new Fixture();
            Random rnd = new Random();
            int randomZip = rnd.Next(10000, 99999);
            int randomState = rnd.Next(1, 51);

            return new FormModel
            {
                FirstName = $"Some Name",
                LastName = "Some LastName",
                PasswordField = fixture.Create<string>().Substring(0, 10),
                Address1 = fixture.Create<string>().Substring(0, 10),
                City = fixture.Create<string>().Substring(0, 10),
                State = randomState,
                ZipCode = randomZip,
                MobilePhone = fixture.Create<int>(),
                AssignAnAddresAlias = fixture.Create<string>().Substring(0, 10)
            };
        }
    }
}
