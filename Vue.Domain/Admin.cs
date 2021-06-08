using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vue.Domain
{
    class Admin
    {
        public int id { get; set; }
        public int userId { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
