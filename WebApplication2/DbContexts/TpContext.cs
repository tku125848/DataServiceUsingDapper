using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.DbContexts
{
    public class TpContext : DbContext
    {
        public TpContext(DbContextOptions<TpContext> options) : base(options) { }

        // List All Model Sets
        public DbSet<ISO3166> ISO3166s { get; set; }
    }
}