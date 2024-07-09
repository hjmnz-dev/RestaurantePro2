using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantePro.Common.Data.Repository
{
    /// <summary>
    /// Interfaces base para los repositorios de datos.
    /// </summary>
    /// <typeparam name="TEntity">Entidad con la que se va a trabajar</typeparam>
    /// <typeparam name="TType">Id por donde se va a buscar</typeparam>
    public interface IBaseRepository<TEntity, TType> where TEntity : class
    {
        void Save(TEntity entity);
        void Update(TEntity entity);
        void Remove(TEntity entity);
        void GetEntityById(int id);
        List<TEntity> GetAll();
        bool Exists(Expression<Func<TEntity, bool>> filter);


    }
}
