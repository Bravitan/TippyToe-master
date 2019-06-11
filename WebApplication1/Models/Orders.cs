using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TippyToe.Models
{
    public class Orders
    {
        public int Id { get; set; }
        public int OrderDate { get; set; }
        public ICollection<OrderShoes> OrderShoes { get; set; }
    }
}
