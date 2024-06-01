using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DemoApp.Models
{
    public class DemoappDb : DbContext
    {
        public DemoappDb() : base("name=MyConnectionString")
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}