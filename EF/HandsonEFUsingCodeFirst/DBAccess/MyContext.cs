using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HandsonEFUsingCodeFirst.Entities;
namespace HandsonEFUsingCodeFirst.DBAccess
{
    public class MyContext:DbContext
    {
        //Entity set
        public DbSet<Product> Products { get; set; }
        public DbSet<Dept> Depts { get; set; }
        public DbSet<Employee> Employees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //configure connectionstring
            optionsBuilder.UseSqlServer(@"Data Source=SANTU\MSSQLSERVER2019;Initial Catalog=SampleDB;User ID=sa;Password=pass@word1");
        }
    }
}
