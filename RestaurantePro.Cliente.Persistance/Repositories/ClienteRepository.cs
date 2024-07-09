



using RestaurantePro.Cliente.Domain.Interfaces;
using System.Linq.Expressions;

namespace RestaurantePro.Cliente.Persistance.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        public bool Exists(Expression<Func<Domain.Entities.Cliente, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Domain.Entities.Cliente> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Domain.Entities.Cliente> GetClientesByClienteId(int clienteId)
        {
            throw new NotImplementedException();
        }

        public void GetEntityById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Domain.Entities.Cliente entity)
        {
            throw new NotImplementedException();
        }

        public void Save(Domain.Entities.Cliente entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Domain.Entities.Cliente entity)
        {
            throw new NotImplementedException();
        }
    }
}
