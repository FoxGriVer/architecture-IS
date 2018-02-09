using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Server
{
    class CarContext: DbContext
    {
        public CarContext() : base("DbConnection")
        {

        }

        public DbSet<Car> Cars { get; set; }
    }
}
