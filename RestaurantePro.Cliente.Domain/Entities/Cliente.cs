using RestaurantePro.Common.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantePro.Cliente.Domain.Entities
{
    public class Cliente : AuditEntity<int>
    {
        [Column("IdCliente")]
        public override int Id { get; set; }
    }
}
