using DemoApp.APIs.Entites;
using DemoTest.ASP;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
    

namespace DemoApp.APIs
{
    public class EmploeTestDataBaseContext : DbContext
    {



        //options connection realted details
        public EmploeTestDataBaseContext(DbContextOptions<EmploeTestDataBaseContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }

        
        //base

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}