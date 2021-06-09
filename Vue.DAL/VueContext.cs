using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vue.Domain;
namespace Vue.DAL
{
    public class VueContext:DbContext
    {
        public VueContext():base("myDbContext")
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}
