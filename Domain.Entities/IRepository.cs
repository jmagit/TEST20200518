using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Core {
    public interface IRepository<TEntity>
        where TEntity : class {
        List<TEntity> GetAll();
        TEntity GetOne(int id);
        void Add(TEntity item);
        void Modify(TEntity item);
        void Remove(TEntity item);
    }
}
