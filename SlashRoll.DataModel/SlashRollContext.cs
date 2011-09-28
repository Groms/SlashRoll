using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace SlashRoll.DataModel
{
    public class SlashRollContext : DbContext
    {
        public DbSet<Roll> Rolls { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
