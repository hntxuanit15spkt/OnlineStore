﻿// <auto-generated />
using System;
using DAL.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DAL.EF.Migrations
{
    [DbContext(typeof(OnlineStoreDbContext))]
    partial class OnlineStoreDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DAL.Models.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId");

                    b.Property<byte[]>("Timestamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Cart");
                });

            modelBuilder.Entity("DAL.Models.CartDetail", b =>
                {
                    b.Property<int>("ItemId");

                    b.Property<int>("CartId");

                    b.Property<int>("Quantity");

                    b.Property<byte[]>("Timestamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("ItemId", "CartId");

                    b.HasIndex("CartId");

                    b.ToTable("CartDetail");
                });

            modelBuilder.Entity("DAL.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)");

                    b.Property<byte[]>("Timestamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.ToTable("Category");

                    b.HasData(
                        new { Id = 1, Name = "Điện thoại" },
                        new { Id = 2, Name = "Laptop" },
                        new { Id = 3, Name = "Máy tính bảng" },
                        new { Id = 4, Name = "Phụ kiện" }
                    );
                });

            modelBuilder.Entity("DAL.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .HasMaxLength(200);

                    b.Property<int>("CustomerId");

                    b.Property<int>("Evaluation");

                    b.Property<int>("ItemId");

                    b.Property<byte[]>("Timestamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ItemId");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("DAL.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("BillingAddress")
                        .HasMaxLength(500);

                    b.Property<string>("FirstName")
                        .HasMaxLength(100);

                    b.Property<int>("Gender");

                    b.Property<string>("LastName")
                        .HasMaxLength(100);

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("ShippingAddress")
                        .HasMaxLength(500);

                    b.Property<int>("Status");

                    b.Property<byte[]>("Timestamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("TypeOfCustomerId");

                    b.Property<string>("Username")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("TypeOfCustomerId");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("DAL.Models.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Bonus")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Description")
                        .HasMaxLength(500);

                    b.Property<DateTime>("EndDate");

                    b.Property<byte[]>("Image");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<DateTime>("StartDate");

                    b.Property<byte[]>("Timestamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.ToTable("Event");
                });

            modelBuilder.Entity("DAL.Models.GoodsReceipt", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("SupplierId");

                    b.Property<byte[]>("Timestamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("SupplierId");

                    b.ToTable("GoodsReceipt");
                });

            modelBuilder.Entity("DAL.Models.GoodsReceiptDetail", b =>
                {
                    b.Property<int>("ItemId");

                    b.Property<int>("GoodsReceiptId");

                    b.Property<int>("Quantity");

                    b.Property<byte[]>("Timestamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("ItemId", "GoodsReceiptId");

                    b.HasIndex("GoodsReceiptId");

                    b.ToTable("GoodsReceiptDetail");
                });

            modelBuilder.Entity("DAL.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal?>("AverageEvaluation");

                    b.Property<string>("BrandName");

                    b.Property<int>("CategoryId");

                    b.Property<bool>("Deleted");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(500)");

                    b.Property<int?>("EventId");

                    b.Property<string>("Image");

                    b.Property<int>("Inventory");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<byte[]>("Timestamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("View");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("EventId");

                    b.ToTable("Item");

                    b.HasData(
                        new { Id = 1, BrandName = "Apple", CategoryId = 1, Deleted = false, Description = "Đây là Iphone 5", Image = "Iphone5-16G.png", Inventory = 200, Name = "Iphone 5", Price = 5000000m, View = 0 },
                        new { Id = 3, BrandName = "Apple", CategoryId = 1, Deleted = false, Description = "<div id=\"CauHinh\"><div class=\"CauHinh_TieuDe\">Bộ vi xử lý</div><ul><li>+ Tên bộ vi xử lý : Chip A7 Dual-Core.</li><li>+ Tốc độ : 1.3Ghz Cyclone.</li> <li>+ Bộ nhớ đệm : ARM v8-based</li><li>+ Hệ điều hành : iOS 7.</li> </ul> <div style=\"clear:both\"></div> <div class=\"CauHinh_TieuDe\">Bộ nhớ trong</div> <ul> <li>+ RAM : 1 GB.</li> <li>+ ROM : 16 GB.</li> </ul><div style=\"clear:both\"></div><div class=\"CauHinh_TieuDe\">Màn hình (Display)</div> <ul> <li>+ Độ lớn màn hình : 7.9 inches.</li> <li>+ Độ phân giải : LED-backlit IPS LCD, 16 triệu màu.</li> </ul><div style=\"clear:both\"></div><div class=\"CauHinh_TieuDe\">Camera</div><ul><li>+ Chính : 5 MP , 2592x1944 pixels.</li><li>+ Phụ : 1.2 MP , 720p  </li> <li>+ Chức năng : Nhận diện khuôn mặt, FaceTime, tự động lấy nét.</li><li>+ Quay phim : Full HD 1080p 30fps, chống rung.</li> </ul> <div style=\"clear:both\"></div> <div class=\"CauHinh_TieuDe\">Thông tin thêm</div> <ul><li>+ Kết nối : Wifi, GPRS, 3G, Bluetooth, USB, GPS.</li><li>+ Pin : Li-Po (23.8 Wh), Lên đến 10 giờ.</li><li>+ Trọng lượng : 341g.</li><li>+ Thời gian bảo hành : 24 tháng.</li>  </ul> <div style=\"clear:both\"></div> </div>", Image = "Iphone5-16G.png", Inventory = 200, Name = "Iphone 5", Price = 5000000m, View = 0 },
                        new { Id = 4, BrandName = "Dell", CategoryId = 2, Deleted = false, Description = "Đây là DELL", Image = "AP-ME294ZP.png", Inventory = 300, Name = "DELL 3440", Price = 12390000m, View = 0 },
                        new { Id = 5, BrandName = "Acer", CategoryId = 2, Deleted = false, Description = "<div id=\"CauHinh\" > <div class=\"CauHinh_TieuDe\" >Bộ vi xử lý</div> <ul> <li>+ Tên bộ vi xử lý : Intel® Core™ i7 380M.</li> <li>+ Tốc độ : 8.0Ghz.</li><li>+ Bộ nhớ đệm : 3MB Cache L3</li> </ul> <div style=\"clear:both\"></div><div class=\"CauHinh_TieuDe\">Bộ nhớ trong (RAM)</div><ul> <li>+ Loại Ram : DDR3 1066Mhz (PC3-8500).</li> <li>+ Dung lượng : 2GB.</li></ul> <div style=\"clear:both\"></div><div class=\"CauHinh_TieuDe\">Ổ đĩa cứng HDD</div> <ul> <li>+ Dung lượng : 320GB.</li><li>+ Kích thước : 2.5 inchs.</li> <li>+ Tốc độ vòng quay : 5400 rpm.</li></ul> <div style=\"clear:both\"></div> <div class=\"CauHinh_TieuDe\">Ổ đĩa quang (ODD)</div> <ul><li>+ Loại ổ đĩa quang : DVD+/- R/RW.</li>  </ul><div style=\"clear:both\"></div><div class=\"CauHinh_TieuDe\">Màn hình (Display)</div><ul><li>+ Độ lớn màn hình : 16 inchs.</li><li>+ Độ phân giải : HD (1366 x 768).</li> </ul> <div style=\"clear:both\"></div> <div class=\"CauHinh_TieuDe\">Đồ Họa (VGA)</div><ul><li>+ Bộ xử lý : Intel HD graphics.</li><li>+ Bộ nhớ đồ họa : Upto 1696MB.</li></ul> <div style=\"clear:both\"></div><div class=\"CauHinh_TieuDe\">Thông tin thêm</div><ul><li>+ Trọng lượng : 3.5 Kg.</li><li>+ Thời gian bảo hành : 24 Tháng.</li></ul><div style=\"clear:both\"></div></div>", Image = "ACER-2215i.png", Inventory = 200, Name = "ACER-2215i", Price = 5000000m, View = 0 },
                        new { Id = 6, BrandName = "Samsung", CategoryId = 3, Deleted = false, Description = "Đây là Galaxy Tab 3", Image = "AP-ME294ZP.png", Inventory = 200, Name = "Galaxy Tab-3-10-P5200", Price = 5904568m, View = 0 },
                        new { Id = 8, CategoryId = 4, Deleted = false, Description = "Đây là tai nghe", Image = "Iphone5-16G.png", Inventory = 200, Name = "Tai nghe", Price = 5000000m, View = 0 }
                    );
                });

            modelBuilder.Entity("DAL.Models.LineItem", b =>
                {
                    b.Property<int>("ItemId");

                    b.Property<int>("OrderId");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity");

                    b.Property<byte[]>("Timestamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("ItemId", "OrderId");

                    b.HasIndex("OrderId");

                    b.ToTable("LineItem");
                });

            modelBuilder.Entity("DAL.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Bonus")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("CustomerId");

                    b.Property<DateTime>("DeliveryDate");

                    b.Property<int>("EmployeeId");

                    b.Property<decimal>("ShippingFee")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Status");

                    b.Property<byte[]>("Timestamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("DAL.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(200)");

                    b.Property<byte[]>("Timestamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("DAL.Models.Supplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("varchar(20)");

                    b.Property<byte[]>("Timestamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.ToTable("Supplier");
                });

            modelBuilder.Entity("DAL.Models.TypeOfCustomer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)");

                    b.Property<byte[]>("Timestamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.ToTable("TypeOfCustomer");
                });

            modelBuilder.Entity("DAL.Models.TypeOfUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)");

                    b.Property<byte[]>("Timestamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.ToTable("TypeOfUser");
                });

            modelBuilder.Entity("DAL.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<int>("Gender");

                    b.Property<string>("LastName");

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("varchar(20)");

                    b.Property<int>("Status");

                    b.Property<byte[]>("Timestamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("TypeOfUserId");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.HasIndex("TypeOfUserId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("DAL.Models.UserDecentralization", b =>
                {
                    b.Property<int>("RoleId");

                    b.Property<int>("TypeOfUserId");

                    b.Property<byte[]>("Timestamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("RoleId", "TypeOfUserId");

                    b.HasIndex("TypeOfUserId");

                    b.ToTable("UserDecentralization");
                });

            modelBuilder.Entity("DAL.Models.Cart", b =>
                {
                    b.HasOne("DAL.Models.Customer", "Customer")
                        .WithMany("Carts")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DAL.Models.CartDetail", b =>
                {
                    b.HasOne("DAL.Models.Cart", "Cart")
                        .WithMany("CartDetails")
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DAL.Models.Item", "Item")
                        .WithMany("CartDetails")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DAL.Models.Comment", b =>
                {
                    b.HasOne("DAL.Models.Customer", "Customer")
                        .WithMany("Comments")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DAL.Models.Item", "Item")
                        .WithMany("Comments")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DAL.Models.Customer", b =>
                {
                    b.HasOne("DAL.Models.TypeOfCustomer", "TypeOfCustomer")
                        .WithMany("Customers")
                        .HasForeignKey("TypeOfCustomerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DAL.Models.GoodsReceipt", b =>
                {
                    b.HasOne("DAL.Models.Supplier", "Supplier")
                        .WithMany("GoodsReceipts")
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DAL.Models.GoodsReceiptDetail", b =>
                {
                    b.HasOne("DAL.Models.GoodsReceipt", "GoodsReceipt")
                        .WithMany("GoodsReceiptDetails")
                        .HasForeignKey("GoodsReceiptId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DAL.Models.Item", "Item")
                        .WithMany("GoodsReceiptDetails")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DAL.Models.Item", b =>
                {
                    b.HasOne("DAL.Models.Category", "Category")
                        .WithMany("Item")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DAL.Models.Event", "Event")
                        .WithMany("Item")
                        .HasForeignKey("EventId");
                });

            modelBuilder.Entity("DAL.Models.LineItem", b =>
                {
                    b.HasOne("DAL.Models.Item", "Item")
                        .WithMany("LineItems")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DAL.Models.Order", "Order")
                        .WithMany("LineItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DAL.Models.Order", b =>
                {
                    b.HasOne("DAL.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DAL.Models.User", b =>
                {
                    b.HasOne("DAL.Models.TypeOfUser", "TypeOfUser")
                        .WithMany("Users")
                        .HasForeignKey("TypeOfUserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DAL.Models.UserDecentralization", b =>
                {
                    b.HasOne("DAL.Models.Role", "Role")
                        .WithMany("UserDecentralizations")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DAL.Models.TypeOfUser", "TypeOfUser")
                        .WithMany("UserDecentralizations")
                        .HasForeignKey("TypeOfUserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}