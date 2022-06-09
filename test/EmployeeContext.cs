using System.Data.Entity;

namespace test
{
    public class EmployeeContext : DbContext
    {
        public DbSet<Employees> Employees { get; set; }
        public EmployeeContext() : base(nameOrConnectionString: "PGConnectionString")
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            base.OnModelCreating(modelBuilder);
        }
    }
}