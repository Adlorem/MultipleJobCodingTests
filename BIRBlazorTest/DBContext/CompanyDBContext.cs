using BIRBlazorTest.Models;
using BIRService.Models;
using Microsoft.EntityFrameworkCore;

namespace BIRBlazorTest.DBContext
{
    public class CompanyDBContext : DbContext
    {
        public CompanyDBContext(DbContextOptions<CompanyDBContext> options)
                : base(options)
        {

        }

        public DbSet<CompanyModel> Company { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
