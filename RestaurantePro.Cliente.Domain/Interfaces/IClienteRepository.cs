using RestaurantePro.Common.Data.Repository;

namespace RestaurantePro.Cliente.Domain.Interfaces
{
    public interface IClienteRepository : IBaseRepository<Cliente.Domain.Entities.Cliente, int>
    {
        List<Cliente.Domain.Entities.Cliente> GetClientesByClienteId(int clienteId);
    }
}
