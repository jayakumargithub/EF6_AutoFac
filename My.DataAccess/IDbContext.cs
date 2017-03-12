using My.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My.DataAccess
{
    public interface IDbContext
    {
         DbSet<Address> Addresses { get; set; }
          DbSet<Customer> Customers { get; set; }

    }
}
