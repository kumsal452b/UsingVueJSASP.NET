using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vue.Domain
{
    public class Product
    {
        public int Id { get; set; }
        public string name { get; set; }
        public DateTime Date { get; set; }
        public int piece { get; set; }
        public int price { get; set; }
        public int User_id { get; set; }
        public User User { get; set; }
    }
}
