using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MartinZumarragaCambiosMVC.Models;

namespace MartinZumarragaCambiosMVC.Data
{
    public class MartinZumarragaCambiosMVCContext : DbContext
    {
        public MartinZumarragaCambiosMVCContext (DbContextOptions<MartinZumarragaCambiosMVCContext> options)
            : base(options)
        {
        }

        public DbSet<MartinZumarragaCambiosMVC.Models.Burger> Burger { get; set; } = default!;
    }
}
