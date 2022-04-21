using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ToDoList2.Model
{
    public partial class RegisterModel : DbContext
    {
        public RegisterModel()
            : base("name=RegisterModel")
        {
        }

        public virtual DbSet<RegisterTable> RegisterTables { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RegisterTable>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<RegisterTable>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<RegisterTable>()
                .Property(e => e.email)
                .IsUnicode(false);
        }
    }
}
