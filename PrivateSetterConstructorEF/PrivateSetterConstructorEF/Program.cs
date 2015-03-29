namespace PrivateSetterConstructorEF
{
    class Program
    {
        static void Main(string[] args)
        {
            using (EmployeeContext employeeContext = new EmployeeContext())
            {
                Employee employee = new Employee("Jalpesh", "Vadgama");
                employeeContext.Employee.Add(employee);
                employeeContext.SaveChanges();
            }
        }
    }
}
