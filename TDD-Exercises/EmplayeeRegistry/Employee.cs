using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmplayeeRegistry
{
  public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SocialSecurityNumber { get; set; }

        public Employee(string firstName, string lastName, string SSN)
        {
            FirstName = firstName;
            LastName = lastName;
            SocialSecurityNumber = SSN;
        }
    }
}
