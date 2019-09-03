using System;
using System.Collections.Generic;
using System.Data.Entity;  // Db context için ekledik ......
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sy.Core.Entities;

namespace Sy.DataAccess
{
    public class StockContext : DbContext
       
    {
        public StockContext() :base("name=MyCon")
        {
        }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Product> Clients { get; set; }
    }
}
