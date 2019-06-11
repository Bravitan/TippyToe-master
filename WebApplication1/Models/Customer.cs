using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TippyToe.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public ICollection<Orders> Orders { get; set; }
    }

}

