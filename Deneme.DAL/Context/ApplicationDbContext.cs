using Deneme.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme.DAL.Context
{
  public  class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext() : base("DenemeSon")
        {
            Database.SetInitializer<ApplicationDbContext>(new DropCreateDatabaseIfModelChanges<ApplicationDbContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Kitaplar> Kitaplar { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
    }
}
