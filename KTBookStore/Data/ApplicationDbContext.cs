using KTBook.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace KTBook.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Order> Order { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);

            SeedUser(builder);

            SeedRole(builder);

            SeedUserRole(builder);

            Seed(builder);


        }

        private void Seed(ModelBuilder builder)
        {
            builder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Book",
                    Description = "ok",
                    Status = "Active"
                },
                new Category
                {
                    Id = 2,
                    Name = "Learning tool",
                    Description = "good",
                    Status = "Active"
                },
                new Category
                {
                    Id = 3,
                    Name = "Manga",
                    Description = "Fantasy",
                    Status = "Active"
                },
                new Category
                {
                    Id = 4,
                    Name = "Comic",
                    Description = "good",
                    Status = "Active"
                },
                new Category
                {
                    Id = 5,
                    Name = "Magic",
                    Description = "Magic",
                    Status = "Active"
                },
                new Category
                {
                    Id = 6,
                    Name = "Drama",
                    Description = "Drama",
                    Status = "Active"
                }
                );
            builder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Conan Chapter 100",
                    Price = 100,
                    Quantity = 10,
                    Description = "Very funny for children.",
                    CategoryId = 3,
                    Image = "conan100.png"
                },
                new Product
                {
                    Id = 2,
                    Name = "Shin chapter 7",
                    Price = 99,
                    Quantity = 20,
                    Description = "Good",
                    CategoryId = 4,
                    Image = "shin7.png"
                },

                new Product
                {
                    Id = 3,
                    Name = "Tiếng Việt lớp 2",
                    Price = 20,
                    Quantity = 70,
                    Description = "Greate for children study VietNamese.",
                    CategoryId = 1,
                    Image = "tiengviet2.png"
                });
        }

        private void SeedUser(ModelBuilder builder)
        {
            //1. tạo tài khoản ban đầu để add vào DB
            var admin = new ApplicationUser
            {
                Id = "1",
                UserName = "thuanddgch200729@fpt.edu.vn",
                Email = "thuanddgch200729@fpt.edu.vn",
                NormalizedUserName = "thuanddgch200729@fpt.edu.vn",
                Image = "https://toigingiuvedep.vn/wp-content/uploads/2021/05/hinh-anh-avatar-hai-doc.jpg",
                DoB = "2000/08/03",
                Address = "Hà Nội",
                FullName = "Đặng Đức Thuần"
            };
            var admin2 = new ApplicationUser
            {
                Id = "2",
                UserName = "phamtrungkien@gmail.com",
                Email = "phamtrungkien@gmail.com",
                NormalizedUserName = "phamtrungkien@gmail.com",
                Image = "https://toigingiuvedep.vn/wp-content/uploads/2021/05/hinh-anh-avatar-hai-doc.jpg",
                DoB = "2002/08/10",
                Address = "Quảng Ninh",
                FullName = "Phạm Trung Kiên"
            };

            var staff1 = new ApplicationUser
            {
                Id = "5",
                UserName = "staff1@gmail.com",
                Email = "staff1@gmail.com",
                NormalizedUserName = "staff1@gmail.com",
                Image = "https://toigingiuvedep.vn/wp-content/uploads/2021/05/hinh-anh-avatar-hai-doc.jpg",
                DoB = "2002/08/10",
                Address = "Hà Nội",
                FullName = "Dang Duc Thuan"
            };
            var staff2 = new ApplicationUser
            {
                Id = "6",
                UserName = "staff2@gmail.com",
                Email = "staff2@gmail.com",
                NormalizedUserName = "staff2@gmail.com",
                Image = "https://toigingiuvedep.vn/wp-content/uploads/2021/05/hinh-anh-avatar-hai-doc.jpg",
                DoB = "2002/08/10",
                Address = "Quang Ninh",
                FullName = "Pham Trung Kien"
            };
            var customer = new ApplicationUser
            {
                Id = "3",
                UserName = "customer@gmail.com",
                Email = "customer@gmail.com",
                NormalizedUserName = "customer@gmail.com",
                Image = "https://toigingiuvedep.vn/wp-content/uploads/2021/05/hinh-anh-avatar-hai-doc.jpg",
                DoB = "2002/08/10",
                Address = "Hà Nội",
                FullName = "Nguyen Van A"
            };

            //2. khai báo thư viện để mã hóa mật khẩu
            var hasher = new PasswordHasher<ApplicationUser>();

            //3. thiết lập và mã hóa mật khẩu từng tài khoản
            admin.PasswordHash = hasher.HashPassword(admin, "P@ssw0rd");
            admin2.PasswordHash = hasher.HashPassword(admin2, "P@ssw0rd");
            customer.PasswordHash = hasher.HashPassword(customer, "P@ssw0rd");

            staff1.PasswordHash = hasher.HashPassword(staff1, "P@ssw0rd");
            staff2.PasswordHash = hasher.HashPassword(staff2, "P@ssw0rd");


            builder.Entity<ApplicationUser>().HasData(admin, customer, admin2, staff1, staff2);
        }

        private void SeedUserRole(ModelBuilder builder)
        {
            builder.Entity<IdentityUserRole<string>>().HasData(
                 new IdentityUserRole<string>
                 {
                     UserId = "1",
                     RoleId = "A"
                 },
                 new IdentityUserRole<string>
                 {
                     UserId = "2",
                     RoleId = "A"
                 },
                 new IdentityUserRole<string>
                 {
                     UserId = "3",
                     RoleId = "B"
                 },
                 new IdentityUserRole<string>
                 {
                     UserId = "5",
                     RoleId = "S"
                 },
                 new IdentityUserRole<string>
                 {
                     UserId = "6",
                     RoleId = "S"
                 },
                 new IdentityUserRole<string>
                 {
                     UserId = "4",
                     RoleId = "A"
                 }
              );

        }

        private void SeedRole(ModelBuilder builder)
        {
            //1. tạo các role cho hệ thống
            var admin = new IdentityRole
            {
                Id = "A",
                Name = "Administrator",
                NormalizedName = "Administrator"
            };
            var customer = new IdentityRole
            {
                Id = "B",
                Name = "Customer",
                NormalizedName = "Customer"
            };
            var Staff = new IdentityRole
            {
                Id = "S",
                Name = "Staff",
                NormalizedName = "Staff"
            };

            //2. add role vào trong DB
            builder.Entity<IdentityRole>().HasData(admin, customer, Staff);

        }

    }

}