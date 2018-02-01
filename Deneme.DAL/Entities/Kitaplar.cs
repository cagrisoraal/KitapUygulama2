using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme.DAL.Entities
{
    public class Kitaplar
    {
        public int Id { get; set; }
        public string KitapAdi { get; set; }
        public string YazarAdi { get; set; }
        public string KitapResUrl { get; set; }

        public virtual ICollection<Kategori> Kategoriler { get; set; }
       
    }
}
