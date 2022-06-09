using System;
using System.Linq;

namespace test
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            using (EmployeeContext employeeContext = new EmployeeContext())
            {
                employeeContext.Employees.Add(new Employees
                {
                    Inn = "123",
                    DateOfBirth = new DateTime(2020, 01, 01),
                    FirstName = "txtName.Text",
                    MiddleName = "txtName.Text",
                    LastName = "txtName.Text",
                    Phone = "+7",
                    Email = "txtName.Text",
                    DriverLicenceCategory = "txtName.Text"
                });
                employeeContext.SaveChanges();

                var emplpoyees = employeeContext.Employees;
                emplpoyees.ToList().ForEach(p=>Console.WriteLine(p.FirstName+ " "));
            }
        }
    }
}