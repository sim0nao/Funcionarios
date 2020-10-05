using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SimoneDesenv.Models;

namespace SimoneDesenv.Data
{
    public class SimoneDesenvContext : DbContext
    {
        public SimoneDesenvContext (DbContextOptions<SimoneDesenvContext> options)
            : base(options)
        {
        }

        public DbSet<SimoneDesenv.Models.pessoa> pessoa { get; set; }
    }
}
