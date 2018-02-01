using Deneme.DAL.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Deneme.DAL.Repository
{
   public class BaseRepository<TEntity> where TEntity : class 
    {
        ApplicationDbContext db = new ApplicationDbContext();

        public void Ekle(TEntity nesne)
        {
            db.Set<TEntity>().Add(nesne);
            db.SaveChanges();
        }

        public void Guncelle(TEntity nesne)
        {
            db.Entry(nesne).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Sil(TEntity nesne)
        {
            db.Set<TEntity>().Remove(nesne);
            db.SaveChanges();
        }

        public List<TEntity> Listele()
        {
            return db.Set<TEntity>().ToList();
        }
        public TEntity IdGoreGetir(int id)
        {
            return db.Set<TEntity>().Find(id);
        }
       public IEnumerable<TEntity> KosulaGoreGetir(Expression<Func<TEntity, bool>> _lambda)
        {
            return db.Set<TEntity>().Where(_lambda).ToList();
        }



    }
}
