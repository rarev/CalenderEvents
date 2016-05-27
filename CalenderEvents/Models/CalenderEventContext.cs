using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CalenderEvents.Models
{
    public class CalenderEventContext : DbContext
    {
        public DbSet<CalenderEvent> CalenderEvents { get; set; }
    }
}