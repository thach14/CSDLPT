using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QLDA
{
    public partial class QLDA : DbContext
    {
        public QLDA(string connectionString)
            : base(connectionString)
        {
        }

        public virtual DbSet<ChiNhanh> ChiNhanh { get; set; }
        public virtual DbSet<DuAn> DuAn { get; set; }
        public virtual DbSet<NhanVien> NhanVien { get; set; }
        public virtual DbSet<PhanCong> PhanCong { get; set; }
        public virtual DbSet<TraLuong> TraLuong { get; set; }
        public virtual DbSet<VaiTro> VaiTro { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiNhanh>()
                .HasMany(e => e.NhanVien)
                .WithRequired(e => e.ChiNhanh)
                .HasForeignKey(e => e.IDCN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ChiNhanh>()
                .HasMany(e => e.DuAn)
                .WithRequired(e => e.ChiNhanh)
                .HasForeignKey(e => e.IDCN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DuAn>()
                .Property(e => e.KinhPhi)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DuAn>()
                .HasOptional(e => e.DuAn1)
                .WithRequired(e => e.DuAn2);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.PhanCong)
                .WithRequired(e => e.NhanVien)
                .HasForeignKey(e => e.IDNV)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PhanCong>()
                .HasOptional(e => e.TraLuong)
                .WithRequired(e => e.PhanCong);

            modelBuilder.Entity<VaiTro>()
                .Property(e => e.Luong)
                .HasPrecision(18, 0);

            modelBuilder.Entity<VaiTro>()
                .HasMany(e => e.PhanCong)
                .WithRequired(e => e.VaiTro)
                .HasForeignKey(e => e.IDVT)
                .WillCascadeOnDelete(false);
        }
    }
}
