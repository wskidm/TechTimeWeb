using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechTime.Models.TechTime
{
    public class TechTimeContext : DbContext
    {
        public TechTimeContext(DbContextOptions<TechTimeContext> options) : base(options) { }

        public DbSet<Event> Events { get; set; }
        public DbSet<EventType> EventTypes { get; set; }
        public DbSet<TimeType> TimeTypes { get; set; }
    }
}
