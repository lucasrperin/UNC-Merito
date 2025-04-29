using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MeritoHealth.Models;

namespace MeritoHealth.Data
{
    public class MeritoHealthContext : DbContext
    {
        public MeritoHealthContext (DbContextOptions<MeritoHealthContext> options)
            : base(options)
        {
        }

        public DbSet<MeritoHealth.Models.Paciente> Paciente { get; set; } = default!;
        public DbSet<MeritoHealth.Models.Alergia> Alergia { get; set; } = default!;

    }
}
