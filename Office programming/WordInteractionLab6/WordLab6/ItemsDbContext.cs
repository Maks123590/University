using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordLab6
{
    public class ItemsDbContext : DbContext
    {
        public ItemsDbContext() : base("DbConnection")
        {
        }

        public DbSet<DataItem> Items { get; set; }
    }
}
