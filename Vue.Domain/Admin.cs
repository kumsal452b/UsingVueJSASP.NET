using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vue.Domain
{
   public class Admin
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User Users { get; set; }
    }
}
