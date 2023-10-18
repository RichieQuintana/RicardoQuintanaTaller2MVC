using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RicardoQuintanaTaller2MVC.Models;

namespace RicardoQuintanaTaller2MVC.Data
{
    public class RicardoQuintanaTaller2MVCContext : DbContext
    {
        public RicardoQuintanaTaller2MVCContext (DbContextOptions<RicardoQuintanaTaller2MVCContext> options)
            : base(options)
        {
        }

        public DbSet<RicardoQuintanaTaller2MVC.Models.Burger> Burger { get; set; } = default!;

        public DbSet<RicardoQuintanaTaller2MVC.Models.Promo>? Promo { get; set; }
    }
}
