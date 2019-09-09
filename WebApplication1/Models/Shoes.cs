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
        public string Color { get; set; }
        public int Size { get; set; }
        public ICollection<OrderShoes> OrderShoes { get; set; }
    }

    public enum Gender
    {
        Male,
        Female
    }

    public enum Style
    {
        Sandals,
        Sneakers,
        Boots,
        Heels,
        Flats,
        Sports,
        Elegants
    }

    public enum Color
    {
        Black,
        White,
        Red,
        Green,
        Blue,
        Silver,
        Yellow,
        Gold,
        Pink
    }

}
