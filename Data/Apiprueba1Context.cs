using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Apiprueba1.Models;

namespace Apiprueba1.Data
{
    public class Apiprueba1Context : DbContext
    {
        public Apiprueba1Context (DbContextOptions<Apiprueba1Context> options)
            : base(options)
        {
        }

        public DbSet<Apiprueba1.Models.Empleado> Empleado { get; set; }
    }
}
