using System.Data.Entity;

namespace PrivateSetterConstructorEF
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext() :base("DefaultConnectionString")
        {

        }
        public DbSet<Employee> Employee { get; set; }
    }
}