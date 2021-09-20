using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    public class EventDataContext:DbContext
    {
        public DbSet<Event> Events { get; set; }

        public EventDataContext(DbContextOptions<EventDataContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
