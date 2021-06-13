using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vue.Domain
{
    public class User
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string usernaname { get; set; }
        public string password { get; set; }
        public ICollection<Admin> Admins { get; set; }
        public Product Product { get; set; }
    }
}
