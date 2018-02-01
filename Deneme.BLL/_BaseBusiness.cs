using Deneme.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Deneme.BLL
{
    public class BaseBusiness<TEntity> where TEntity : class
    {
        BaseRepository<TEntity> repo = new BaseRepository<TEntity>();
    

        public void Ekle(TEntity nesne)
        {
            repo.Ekle(nesne);
        }


        public void Guncelle(TEntity nesne)
        {
            repo.Guncelle(nesne);
        }


        public void Sil(TEntity nesne)
        {
            repo.Sil(nesne);
        }


        public List<TEntity> Listele()
        {
            return repo.Listele();
        }


        public TEntity IdGoreGetir(int id)
        {
            return repo.IdGoreGetir(id);
        }

        public IEnumerable<TEntity> KosulaGoreGetir(Expression<Func<TEntity, bool>> _lambda)
        {
            return repo.KosulaGoreGetir(_lambda);
        }

    }

}

