using LayersArchiDemo_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayersArchiDemo_DAL.Interfaces
{
    public interface IRepositoryBase<Tkey, TElem>
    {
        IEnumerable<TElem> GetAll();

        TElem GetById(Tkey id);

        TElem Create(TElem user);

        bool Update(TElem user);

        bool Delete(Tkey id);
    }
}
