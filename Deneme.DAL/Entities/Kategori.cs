using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme.DAL.Entities
{
  public  class Kategori
    {
        public int Id { get; set; }
        public string KategoriAdi { get; set; }

        public virtual ICollection<Kitaplar> Kitaplar { get; set; }

        public Kategori()
        {
            Kitaplar = new List<Kitaplar>();
        }

    }
}
