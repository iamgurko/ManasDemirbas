using ManasDemirbas.Data;
using ManasDemirbas.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManasDemirbas.Repositories
{
    public class EmployeeManager : Employee
    {
        public static IEnumerable<Employee> GetAll()
        {
            // var employees = LoadTestData();

            var context = new FixtureContext();
            var employees = context.Employees.ToList();

            return employees;
        }

        // Personel Ekleme
        public static void Add(Employee emp)
        {
            var context = new FixtureContext();
            context.Employees.Add(emp);
            context.SaveChanges();
        }

        // Personel Güncelleme
        public static void Update(Employee emp)
        {
            var context = new FixtureContext();
            var existingEmp = context.Employees.SingleOrDefault(e => e.Id == emp.Id);

            existingEmp.FirstName = emp.FirstName;
            existingEmp.LastName = emp.LastName;
            existingEmp.HireDate = emp.HireDate;
            existingEmp.DeskNumber = emp.DeskNumber;
            existingEmp.PhoneNumber = emp.PhoneNumber;
            existingEmp.DepartmentId = emp.DepartmentId;
            context.SaveChanges();
        }

    }
}
