using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantePro.Cliente.Persistance.Context
{
    public class RestauranteContext : DbContext
    {
        #region
        public RestauranteContext(DbContextOptions<RestauranteContext>options):base(options)
        {
            
        }
        #endregion

        #region"Db Sets"
        public  DbSet<Domain.Entities.Cliente>Clientes{ get; set; }
        public DbSet<Domain.Entities.Empleado> Empleado { get; set; }
        #endregion
    }
}
