using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using iptu.Models;

namespace iptu.Data
{
    public class iptuContext : DbContext
    {
        public iptuContext (DbContextOptions<iptuContext> options)
            : base(options)
        {
        }

        public DbSet<iptu.Models.Dados> Dados { get; set; }
    }
}
