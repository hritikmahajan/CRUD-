using CRUD_Operations.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CRUD_Operations.Data
{
    public class DBApplication : DbContext
    {
        public DBApplication(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees{ get; set; }

        protected DBApplication()
        {
        }
    }
}
