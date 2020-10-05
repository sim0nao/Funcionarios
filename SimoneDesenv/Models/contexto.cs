using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

namespace SimoneDesenv.Models
{
    public class contexto : DbContext
    {
        public DbSet<pessoa> Pessoas { get; set; }
    }
}
