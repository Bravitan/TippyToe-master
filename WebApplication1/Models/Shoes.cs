using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TippyToe.Models
{
    public class Shoes
    {
        public int Id { get; set; }
        public string Gender { get; set; }
        public double Price { get; set; }
        public string Style { get; set; }
        public string Image { get; set; }
        public ICollection<Color> Color { get; set; }
        public ICollection<Size> Size { get; set; }
        public ICollection<OrderShoes> OrderShoes { get; set; }
    }
}
