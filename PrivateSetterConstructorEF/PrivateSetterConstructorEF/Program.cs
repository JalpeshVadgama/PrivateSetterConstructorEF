using System;

namespace PrivateSetterConstructorEF
{
    class Program
    {
        static void Main(string[] args)
        {
            using (EmployeeContext employeeContext = new EmployeeContext())
            {
                Employee employee = new Employee("Jalpesh", "Vadgama");
                employeeContext.Employees.Add(employee);
                employeeContext.SaveChanges();

                Console.WriteLine("Employee Saved");
            }
        }
    }
}
