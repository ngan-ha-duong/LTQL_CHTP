namespace LTQL_nganha.Migrations
{
    using LTQL_nganha.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LTQL_nganha.Models.Model1>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(LTQL_nganha.Models.Model1 context)
        {
            context.KhachHangs.AddOrUpdate(k => k.MaKH,
                new Khachhang
                {
                    MaKH = "KH0001",
                    TenKH = "Lan Anh",
                    DiaChi = "Đông Lào",
                    DienThoai = "0357921354",
                    Email = "",
                    Role = "",
                    password = "",
                },
                new Khachhang
                {
                    MaKH = "KH0002",
                    TenKH = "Lan Chị",
                    DiaChi = "Tây Lào",
                    DienThoai= "0357670421",
                    Email = "",
                    Role = "",
                    password = "",

                },
                new Khachhang
                {
                    MaKH = "KH0003",
                    TenKH = "Lan Em",
                    DiaChi = "Nam Lào",
                    DienThoai = "0357370421",
                    Email = "",
                    Role = "",
                    password = "",
                }
                );
        }
    }
}
