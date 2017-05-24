using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EmplayeeRegistry
{
    public class Registry : IRegistry
    {
        private Dictionary<string, Employee> employees;
        private Regex ssnRegex = new Regex(@"\d{6}-\d{4}");
        public Registry()
        {
            employees = new Dictionary<string, Employee>();
        }
        public Registry(Dictionary<string, Employee> newemployees)
        {
            employees = newemployees;
        }

        public List<Employee> AllEmployees()
        {
            return employees.Values.ToList();
        }

        public void Fire(string ssn)
        {
            
        }

        public void Hire(Employee employee)
        {
            if (!ssnRegex.IsMatch(employee.SocialSecurityNumber))
                throw new InvalidSsnExeption();
            employees.Add(employee.SocialSecurityNumber, employee);
        }
    }
}
