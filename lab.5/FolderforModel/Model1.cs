using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace lab._5.FolderforModel
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Table_Motorbike> Table_Motorbike { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Table_Motorbike>()
                .Property(e => e.Model)
                .IsUnicode(false);

            modelBuilder.Entity<Table_Motorbike>()
                .Property(e => e.Brand)
                .IsUnicode(false);

            modelBuilder.Entity<Table_Motorbike>()
                .Property(e => e.Picture)
                .IsUnicode(false);
        }
    }
}
