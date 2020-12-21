namespace LTQL_nganha.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public virtual DbSet<Khachhang> KhachHangs { get; set; }
        public virtual DbSet<NhanVien> NhanViens{ get; set; }
        public virtual DbSet<MatHang> MatHangs { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<CTHD> CTHDs { get; set; }
        public virtual DbSet<LoaiHang> LoaiHangs { get; set; }
        public Model1()
            : base("name=Model1")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
