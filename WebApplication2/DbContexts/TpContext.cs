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
        public TpContext(DbContextOptions<TpContext> options)
        : base(options)
        {
        }
        //private readonly IConfiguration _configuration;
        //string _connstr = "";
        //public TpContext(IConfiguration configuration)
        //{
        //    _configuration = configuration;
        //    _connstr = _configuration.GetConnectionString("TP");
        //}

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(_connstr);
        //}
        // List All Model Sets
        public DbSet<ISO3166> ISO3166s { get; set; }


    }
}