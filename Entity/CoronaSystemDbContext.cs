using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public partial class CoronaSystemDbContext: DbContext
    {
        public CoronaSystemDbContext()
        {
        }
        public CoronaSystemDbContext(DbContextOptions<CoronaSystemDbContext> options)
      : base(options)
        {
        }


        public virtual DbSet<VaccineDetails> VaccineDetails { get; set; }

        public virtual DbSet<Members> Member { get; set; }
        public virtual DbSet<CoronaDetails> CoronaDetails { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
       => optionsBuilder.UseSqlServer("Data Source=DESKTOP-6D4H651\\SQLEXPRESS;Initial Catalog=CoronaSystem1;TrustServerCertificate=true;Integrated Security=true");
    
     
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CoronaDetails>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK_CoronaDetails");
                entity.ToTable("CoronaDetails");

                entity.Property(e => e.Id).HasColumnName("ID");
              
            });
            modelBuilder.Entity<VaccineDetails>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK_VaccineDetails");
                entity.ToTable("VaccineDetails");

                entity.Property(e => e.Id).HasColumnName("ID");


            });
            modelBuilder.Entity<Members>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK_Member");
                entity.ToTable("Members");

              //  entity.Property(e => e.Id).HasColumnName("ID");

            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
