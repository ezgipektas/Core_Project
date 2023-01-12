using Core_Project_Api.DAL.Entity;
using Microsoft.EntityFrameworkCore;

namespace Core_Project_Api.DAL.ApiContext
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-FJT4L6QM;database=DbCoreUdemyProjectApi;integrated security=true;");
        }
        public DbSet<Category> Categories { get; set; }
    }
}
