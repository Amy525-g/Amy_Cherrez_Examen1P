using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Amy_Cherrez_Examen1P.Models;

namespace Amy_Cherrez_Examen1P.Data
{
    public class Amy_Cherrez_Examen1PContext : DbContext
    {
        public Amy_Cherrez_Examen1PContext (DbContextOptions<Amy_Cherrez_Examen1PContext> options)
            : base(options)
        {
        }

        public DbSet<Amy_Cherrez_Examen1P.Models.AmyCherrez_TablaFactura> AmyCherrez_TablaFactura { get; set; } = default!;
    }
}
