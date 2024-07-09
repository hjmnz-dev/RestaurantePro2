using RestaurantePro.Common.Data.Base;
using System.ComponentModel.DataAnnotations.Schema;


namespace RestaurantePro.Cliente.Domain.Entities
{
    public class Empleado : AuditEntity<int>
    {
        [Column("IdEmpleado")]
        public override int Id { get; set; }
    }
}
