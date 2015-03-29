using System.Data.Entity;

namespace PrivateSetterConstructorEF
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext() :base("DefaultConnectionString")
        {
            
        }
        DbSet<Employee> Employee { get; set; }
    }
}