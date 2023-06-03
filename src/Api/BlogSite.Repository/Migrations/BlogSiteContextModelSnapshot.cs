﻿// <auto-generated />
using System;
using BlogSite.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlogSite.Repository.Migrations
{
    [DbContext(typeof(BlogSiteContext))]
    partial class BlogSiteContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BlogSite.Core.Entities.Master.MCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnOrder(0);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnOrder(4);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnOrder(2);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnOrder(1);

                    b.Property<int>("ReferenceId")
                        .HasColumnType("int")
                        .HasColumnOrder(3);

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnOrder(5);

                    b.HasKey("Id");

                    b.ToTable("MCategories");
                });

            modelBuilder.Entity("BlogSite.Core.Entities.Transaction.TBlog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnOrder(0);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Category_ID")
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnOrder(3);

                    b.Property<byte[]>("ContentImg")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("CoverImg")
                        .HasColumnType("varbinary(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnOrder(7);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnOrder(4);

                    b.Property<byte[]>("HeaderImg")
                        .HasColumnType("varbinary(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnOrder(6);

                    b.Property<bool>("IsApprove")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnOrder(2);

                    b.Property<DateTime>("PeriodEnd")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2")
                        .HasColumnName("PeriodEnd");

                    b.Property<DateTime>("PeriodStart")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2")
                        .HasColumnName("PeriodStart");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnOrder(8);

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("User_ID")
                        .HasColumnType("int")
                        .HasColumnOrder(9);

                    b.Property<int>("ViewNumber")
                        .HasColumnType("int")
                        .HasColumnOrder(5);

                    b.HasKey("Id");

                    b.HasIndex("Category_ID");

                    b.HasIndex("UserId");

                    b.HasIndex("User_ID");

                    b.ToTable("TBlogs");

                    b.ToTable(tb => tb.IsTemporal(ttb =>
                            {
                                ttb.UseHistoryTable("TBlogsHistory");
                                ttb
                                    .HasPeriodStart("PeriodStart")
                                    .HasColumnName("PeriodStart");
                                ttb
                                    .HasPeriodEnd("PeriodEnd")
                                    .HasColumnName("PeriodEnd");
                            }));
                });

            modelBuilder.Entity("BlogSite.Core.Entities.Transaction.TComment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnOrder(0);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Blog_ID")
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnOrder(4);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnOrder(6);

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnOrder(5);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnOrder(3);

                    b.Property<int>("ParentId")
                        .HasColumnType("int")
                        .HasColumnOrder(2);

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnOrder(7);

                    b.Property<int>("User_ID")
                        .HasColumnType("int")
                        .HasColumnOrder(8);

                    b.HasKey("Id");

                    b.HasIndex("Blog_ID");

                    b.HasIndex("User_ID");

                    b.ToTable("TComments");
                });

            modelBuilder.Entity("BlogSite.Core.Entities.Transaction.TMovement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnOrder(0);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Blog_ID")
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnOrder(3);

                    b.Property<byte>("EUserReaction")
                        .HasColumnType("tinyint");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnOrder(2);

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnOrder(4);

                    b.Property<int>("User_ID")
                        .HasColumnType("int")
                        .HasColumnOrder(5);

                    b.HasKey("Id");

                    b.HasIndex("Blog_ID");

                    b.HasIndex("User_ID");

                    b.ToTable("TMovements");
                });

            modelBuilder.Entity("BlogSite.Core.Entities.UserBase.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnOrder(0);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnOrder(4);

                    b.Property<string>("Description")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnOrder(2);

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnOrder(3);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnOrder(1);

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnOrder(5);

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2023, 6, 3, 12, 51, 55, 412, DateTimeKind.Local).AddTicks(4727),
                            Description = "Admin kullanıcıları için tanımlanmıştır.",
                            IsActive = true,
                            Name = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2023, 6, 3, 12, 51, 55, 412, DateTimeKind.Local).AddTicks(4740),
                            Description = "Blog Site kullanıcıları için tanımlanmıştır.",
                            IsActive = true,
                            Name = "BlogSiteUser"
                        });
                });

            modelBuilder.Entity("BlogSite.Core.Entities.UserBase.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnOrder(0);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("About")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnOrder(5);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnOrder(9);

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(max)")
                        .HasColumnOrder(6);

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnOrder(8);

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnOrder(3);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnOrder(1);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnOrder(7);

                    b.Property<string>("Title")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnOrder(4);

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnOrder(10);

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnOrder(2);

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2023, 6, 3, 12, 51, 55, 412, DateTimeKind.Local).AddTicks(5175),
                            Image = new byte[] { 255, 216, 255, 224, 0, 16, 74, 70, 73, 70, 0, 1, 1, 0, 0, 1, 0, 1, 0, 0, 255, 219, 0, 132, 0, 8, 6, 6, 7, 6, 5, 8, 7, 7, 7, 9, 9, 8, 10, 12, 20, 13, 12, 11, 11, 12, 25, 18, 19, 15, 20, 29, 26, 31, 30, 29, 26, 28, 28, 32, 36, 46, 39, 32, 34, 44, 35, 28, 28, 40, 55, 41, 44, 48, 49, 52, 52, 52, 31, 39, 57, 61, 56, 50, 60, 40, 51, 52, 50, 255, 219, 0, 132, 1, 9, 9, 9, 12, 11, 12, 24, 13, 13, 24, 50, 33, 28, 33, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50 },
                            IsActive = true,
                            Mail = "admin@gmail.com",
                            Name = "admin",
                            Password = "1234",
                            Title = "Manager",
                            UserName = "Admin User"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2023, 6, 3, 12, 51, 55, 412, DateTimeKind.Local).AddTicks(5318),
                            Image = new byte[] { 255, 216, 255, 224, 0, 16, 74, 70, 73, 70, 0, 1, 1, 0, 0, 1, 0, 1, 0, 0, 255, 219, 0, 132, 0, 8, 6, 6, 7, 6, 5, 8, 7, 7, 7, 9, 9, 8, 10, 12, 20, 13, 12, 11, 11, 12, 25, 18, 19, 15, 20, 29, 26, 31, 30, 29, 26, 28, 28, 32, 36, 46, 39, 32, 34, 44, 35, 28, 28, 40, 55, 41, 44, 48, 49, 52, 52, 52, 31, 39, 57, 61, 56, 50, 60, 40, 51, 52, 50, 255, 219, 0, 132, 1, 9, 9, 9, 12, 11, 12, 24, 13, 13, 24, 50, 33, 28, 33, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50 },
                            IsActive = true,
                            Mail = "skacmaz@gmail.com",
                            Name = "skacmaz",
                            Password = "1234",
                            Title = "Software Developer",
                            UserName = "Serhat Kaçmaz"
                        });
                });

            modelBuilder.Entity("BlogSite.Core.Entities.UserBase.UserRefreshToken", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnOrder(0);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnOrder(2);

                    b.Property<DateTime>("Expiration")
                        .HasColumnType("datetime2")
                        .HasColumnOrder(3);

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    b.HasKey("Id");

                    b.ToTable("UserRefreshTokens");
                });

            modelBuilder.Entity("BlogSite.Core.Entities.UserBase.UserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnOrder(0);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnOrder(4);

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnOrder(3);

                    b.Property<int>("Role_ID")
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnOrder(5);

                    b.Property<int>("User_ID")
                        .HasColumnType("int")
                        .HasColumnOrder(2);

                    b.HasKey("Id");

                    b.HasIndex("Role_ID");

                    b.HasIndex("User_ID");

                    b.ToTable("UserRoles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2023, 6, 3, 12, 51, 55, 412, DateTimeKind.Local).AddTicks(5052),
                            IsActive = true,
                            Role_ID = 1,
                            User_ID = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2023, 6, 3, 12, 51, 55, 412, DateTimeKind.Local).AddTicks(5055),
                            IsActive = true,
                            Role_ID = 2,
                            User_ID = 2
                        });
                });

            modelBuilder.Entity("BlogSite.Core.Entities.Transaction.TBlog", b =>
                {
                    b.HasOne("BlogSite.Core.Entities.Master.MCategory", "Category")
                        .WithMany("Blogs")
                        .HasForeignKey("Category_ID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("BlogSite.Core.Entities.UserBase.User", null)
                        .WithMany("TBlogs")
                        .HasForeignKey("UserId");

                    b.HasOne("BlogSite.Core.Entities.UserBase.User", "User")
                        .WithMany()
                        .HasForeignKey("User_ID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BlogSite.Core.Entities.Transaction.TComment", b =>
                {
                    b.HasOne("BlogSite.Core.Entities.Transaction.TBlog", "Blog")
                        .WithMany("Comments")
                        .HasForeignKey("Blog_ID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("BlogSite.Core.Entities.UserBase.User", "User")
                        .WithMany()
                        .HasForeignKey("User_ID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Blog");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BlogSite.Core.Entities.Transaction.TMovement", b =>
                {
                    b.HasOne("BlogSite.Core.Entities.Transaction.TBlog", "Blog")
                        .WithMany("Movements")
                        .HasForeignKey("Blog_ID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("BlogSite.Core.Entities.UserBase.User", "User")
                        .WithMany("TMovements")
                        .HasForeignKey("User_ID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Blog");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BlogSite.Core.Entities.UserBase.UserRole", b =>
                {
                    b.HasOne("BlogSite.Core.Entities.UserBase.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("Role_ID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("BlogSite.Core.Entities.UserBase.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("User_ID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BlogSite.Core.Entities.Master.MCategory", b =>
                {
                    b.Navigation("Blogs");
                });

            modelBuilder.Entity("BlogSite.Core.Entities.Transaction.TBlog", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Movements");
                });

            modelBuilder.Entity("BlogSite.Core.Entities.UserBase.Role", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("BlogSite.Core.Entities.UserBase.User", b =>
                {
                    b.Navigation("TBlogs");

                    b.Navigation("TMovements");

                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
