﻿// <auto-generated />
using System;
using Foundation.Library.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FinalProject.Migrations
{
    [DbContext(typeof(WebsiteContext))]
    partial class WebsiteContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Foundation.Entities.Address", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("Foundation.Entities.Advertise", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ActionUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Advertises");
                });

            modelBuilder.Entity("Foundation.Entities.Course", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("Foundation.Entities.Footer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Copyright")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ShowCopyright")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Footers");
                });

            modelBuilder.Entity("Foundation.Entities.Header", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ImageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("ShowBannerImage")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("ImageId");

                    b.ToTable("Headers");
                });

            modelBuilder.Entity("Foundation.Entities.Image", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AlternativeText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("Foundation.Entities.Notice", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Notices");
                });

            modelBuilder.Entity("Foundation.Entities.Post", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("Foundation.Entities.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BirthCertificateNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("EnrollCourseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NationalIdentificationNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nationality")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ParentsInfoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("PermanentAddressId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("PresentAddressId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("YearOfEnroll")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("EnrollCourseId");

                    b.HasIndex("ParentsInfoId");

                    b.HasIndex("PermanentAddressId");

                    b.HasIndex("PresentAddressId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Foundation.Entities.StudentParents", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("FatherAnnualIncome")
                        .HasColumnType("float");

                    b.Property<string>("FatherMobileNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FatherName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FatherOccupation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GuardianMobileNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GuardianName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotherMobileNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotherName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotherOccupation")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Parents");
                });

            modelBuilder.Entity("Foundation.Entities.Header", b =>
                {
                    b.HasOne("Foundation.Entities.Image", "Image")
                        .WithMany()
                        .HasForeignKey("ImageId");
                });

            modelBuilder.Entity("Foundation.Entities.Student", b =>
                {
                    b.HasOne("Foundation.Entities.Course", "EnrollCourse")
                        .WithMany()
                        .HasForeignKey("EnrollCourseId");

                    b.HasOne("Foundation.Entities.StudentParents", "ParentsInfo")
                        .WithMany()
                        .HasForeignKey("ParentsInfoId");

                    b.HasOne("Foundation.Entities.Address", "PermanentAddress")
                        .WithMany()
                        .HasForeignKey("PermanentAddressId");

                    b.HasOne("Foundation.Entities.Address", "PresentAddress")
                        .WithMany()
                        .HasForeignKey("PresentAddressId");
                });
#pragma warning restore 612, 618
        }
    }
}
