using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace JobsRegistration.Models
{
    public class DataContext : DbContext
    {
        public DataContext() : base("name=dep_Job_Register") { }
        public DbSet<Users> Users { get; set; }
        public DbSet<Job_Status> Job_Status { get; set; }
        public DbSet<Job_Register> Job_Register { get; set; }
        public DbSet<Departments> Department { get; set; }
        public DbSet<Job_Category> Job_Category { get; set; }
        public DbSet<Employees> Employee { get; set; }
        
    }
}