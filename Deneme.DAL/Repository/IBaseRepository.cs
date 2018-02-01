using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Deneme.DAL.Repository
{
  public interface IBaseRepository<TEntity> where TEntity:class
    {
        void Ekle(TEntity nesne);

        void Guncelle(TEntity nesne);

        void Sil(TEntity nesne);

        List<TEntity> Listele();

        TEntity IdGoreGetir(int id);

        IEnumerable<TEntity> KosulaGoreGetir(Expression<Func<TEntity, bool>> _lambda);
    }
}
