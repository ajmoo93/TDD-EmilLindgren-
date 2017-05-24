using Microsoft.Win32;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmplayeeRegistry.Test
{

    public class RegistryTests
    {
        private Registry sut;
        private Dictionary<string, Employee> employees;
        private Employee employee1;
        private Employee employee2;
        [SetUp]
        public void Setup()
        {
            employees = new Dictionary<string, Employee>();
            employee1 = new Employee("Andreas", "Koskenkora", "550505-1241");
            employee2 = new Employee("Aladin", "mahnadrin", "691212-2524");
            sut = new Registry();
        }
        [Test]
        public void StartWithZeroEmployees()
        {
            var result = sut.AllEmployees();
            Assert.IsNotNull(result);
            // Assert.AreEqual(0, result.Count);
        }
        [Test]
        public void CanSeedEmployeesOnConstruct()
        {
            employees.Add(employee1.SocialSecurityNumber, employee1);
            employees.Add(employee2.SocialSecurityNumber, employee2);
            sut = new Registry(employees);
            var result = sut.AllEmployees();
            Assert.AreEqual(2, result.Count);
        }

        [Test]
        public void CanHireAnEmployee()
        {
            var employee = new Employee("Konny", "Kula", "650201-5465");
            sut.Hire(employee);
            var result = sut.AllEmployees();
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("Konny", result[0].FirstName);
        }

        [Test]
        public void HireWithInvalidSsn_ThrowsExeption()
        {
            var employee = new Employee("Konny", "Kula", "650102dd-5362");
            sut.Hire(employee);
            var result = sut.AllEmployees();

            Assert.Throws<InvalidSsnExeption>(() =>
            {
                sut.Hire(employee);
            });
        }
    }
}
