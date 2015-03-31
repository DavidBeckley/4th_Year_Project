using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Google_Maps_Transport_Locator.Models
{
    public class BusDetailsContext : DbContext
    {
        public BusDetailsContext() : base("DefaultConnection")
        {

        }
        public DbSet<BusDetails> details { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}