using Entity.Conc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DBContext : DbContext
    {
        public DbSet<Haber> Haberler { get; set; }
        public DBContext(DbContextOptions options) : base(options)
        { 
            
        }
        
    }
}
