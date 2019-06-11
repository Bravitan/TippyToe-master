using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TippyToe.Models;

namespace TippyToe.Models
{
    public class TippyToeContext : DbContext
    {
        public TippyToeContext(DbContextOptions<TippyToeContext> options)
            : base(options)
        { }
        public DbSet<TippyToe.Models.Shoes> Shoes { get; set; }
        public DbSet<TippyToe.Models.Color> Color { get; set; }
        public DbSet<TippyToe.Models.Size> Size { get; set; }
        public DbSet<TippyToe.Models.Orders> Orders { get; set; }
        public DbSet<TippyToe.Models.Customer> Customer { get; set; }
        public DbSet<TippyToe.Models.OrderShoes> OrderShoes { get; set; }

    }
}

