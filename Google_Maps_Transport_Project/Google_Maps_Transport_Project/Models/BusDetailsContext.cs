using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Google_Maps_Transport_Project.Models
{
    public class BusDetailsContext : DbContext
    {
        public DbSet<Bus_details> details { get; set; }
    }
}