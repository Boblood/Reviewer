using Reviewer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reviewer
{
    public class GRDB_D1 : DbContext
    {
        public DbSet<Game> Games { get; set; }
    }
}
