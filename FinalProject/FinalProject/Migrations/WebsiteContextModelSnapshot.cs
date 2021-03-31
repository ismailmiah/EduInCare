﻿// <auto-generated />
using System;
using Foundation.Library.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FinalProject.Web.Migrations
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

            modelBuilder.Entity("Foundation.Library.Entities.AcademicYear", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsOpenForAdmission")
                        .HasColumnType("bit");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AcademicYears");
                });

            modelBuilder.Entity("Foundation.Library.Entities.Advertise", b =>
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

            modelBuilder.Entity("Foundation.Library.Entities.AppointmentImage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AlternativeText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("JobInfoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("JobInfoId")
                        .IsUnique();

                    b.ToTable("AppointmentImages");
                });

            modelBuilder.Entity("Foundation.Library.Entities.Course", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DepartmentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<bool>("HaveCompulsorySubject")
                        .HasColumnType("bit");

                    b.Property<int>("MaxCompulsorySubject")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("Foundation.Library.Entities.Department", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("Foundation.Library.Entities.Designation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Designations");
                });

            modelBuilder.Entity("Foundation.Library.Entities.EducationLevel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("EducationLevelName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EducationLevels");
                });

            modelBuilder.Entity("Foundation.Library.Entities.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FatherName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("ImageAlternativeText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("JoinOfDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("MaritalStatus")
                        .HasColumnType("int");

                    b.Property<string>("MobileNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotherName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nationality")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PermanentAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PresentAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Religion")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Foundation.Library.Entities.EmployeeEducation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Achievement")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Cgpa")
                        .HasColumnType("real");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<Guid>("EducationLevelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ExamTitleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("InstituteName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Major")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Marks")
                        .HasColumnType("real");

                    b.Property<string>("PassingYear")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ResultType")
                        .HasColumnType("int");

                    b.Property<int>("Scale")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EducationLevelId")
                        .IsUnique();

                    b.HasIndex("EmployeeId");

                    b.HasIndex("ExamTitleId")
                        .IsUnique();

                    b.ToTable("EmployeeEducations");
                });

            modelBuilder.Entity("Foundation.Library.Entities.EmploymentHistory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CompanyLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Designation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("From")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("To")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("EmploymentHistories");
                });

            modelBuilder.Entity("Foundation.Library.Entities.ExamTitle", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("EducationLevelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TitleName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EducationLevelId")
                        .IsUnique();

                    b.ToTable("ExamTitles");
                });

            modelBuilder.Entity("Foundation.Library.Entities.Footer", b =>
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

            modelBuilder.Entity("Foundation.Library.Entities.Group", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("Foundation.Library.Entities.Header", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ImageAlternativeText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ShowBannerImage")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Headers");
                });

            modelBuilder.Entity("Foundation.Library.Entities.JobInfo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DesignationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("JoiningDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("TotalLeave")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DesignationId")
                        .IsUnique();

                    b.HasIndex("EmployeeId");

                    b.ToTable("JobInfos");
                });

            modelBuilder.Entity("Foundation.Library.Entities.Notice", b =>
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

            modelBuilder.Entity("Foundation.Library.Entities.Parents", b =>
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

                    b.Property<Guid>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("StudentId")
                        .IsUnique();

                    b.ToTable("Parents");
                });

            modelBuilder.Entity("Foundation.Library.Entities.Post", b =>
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

            modelBuilder.Entity("Foundation.Library.Entities.Registration", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AcademicYearId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BoardRegistrationNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CardNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("CourseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsPromoted")
                        .HasColumnType("bit");

                    b.Property<string>("OldRegistrationId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegistrationNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RollNo")
                        .HasColumnType("int");

                    b.Property<Guid>("SectionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Shift")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<Guid>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("AcademicYearId")
                        .IsUnique();

                    b.HasIndex("CourseId")
                        .IsUnique();

                    b.HasIndex("SectionId")
                        .IsUnique();

                    b.HasIndex("StudentId")
                        .IsUnique();

                    b.ToTable("Registrations");
                });

            modelBuilder.Entity("Foundation.Library.Entities.Section", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<Guid>("CourseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<Guid>("TeacherId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("TeacherId")
                        .IsUnique();

                    b.ToTable("Sections");
                });

            modelBuilder.Entity("Foundation.Library.Entities.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BirthCertificateNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BloodGroup")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("ImageAlternativeText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
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

                    b.Property<string>("PermanentAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PresentAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Religion")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("YearOfEnroll")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Foundation.Library.Entities.Subject", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("CourseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("ExcludeInResult")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Type")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("Foundation.Library.Entities.AppointmentImage", b =>
                {
                    b.HasOne("Foundation.Library.Entities.JobInfo", "JobInfo")
                        .WithOne("Appointment")
                        .HasForeignKey("Foundation.Library.Entities.AppointmentImage", "JobInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Foundation.Library.Entities.Course", b =>
                {
                    b.HasOne("Foundation.Library.Entities.Department", "Department")
                        .WithMany("Courses")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Foundation.Library.Entities.EmployeeEducation", b =>
                {
                    b.HasOne("Foundation.Library.Entities.EducationLevel", "EducationLevel")
                        .WithOne("EmployeeEducation")
                        .HasForeignKey("Foundation.Library.Entities.EmployeeEducation", "EducationLevelId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Foundation.Library.Entities.Employee", "Employee")
                        .WithMany("EmployeeEducation")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Foundation.Library.Entities.ExamTitle", "ExamTitle")
                        .WithOne("EmployeeEducation")
                        .HasForeignKey("Foundation.Library.Entities.EmployeeEducation", "ExamTitleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Foundation.Library.Entities.EmploymentHistory", b =>
                {
                    b.HasOne("Foundation.Library.Entities.Employee", "Employee")
                        .WithMany("EmploymentHistory")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Foundation.Library.Entities.ExamTitle", b =>
                {
                    b.HasOne("Foundation.Library.Entities.EducationLevel", "EducationLevel")
                        .WithOne("ExamTitle")
                        .HasForeignKey("Foundation.Library.Entities.ExamTitle", "EducationLevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Foundation.Library.Entities.JobInfo", b =>
                {
                    b.HasOne("Foundation.Library.Entities.Designation", "Designation")
                        .WithOne("JobInfo")
                        .HasForeignKey("Foundation.Library.Entities.JobInfo", "DesignationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Foundation.Library.Entities.Employee", "Employee")
                        .WithMany("JobInfo")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Foundation.Library.Entities.Parents", b =>
                {
                    b.HasOne("Foundation.Library.Entities.Student", "Student")
                        .WithOne("Parents")
                        .HasForeignKey("Foundation.Library.Entities.Parents", "StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Foundation.Library.Entities.Registration", b =>
                {
                    b.HasOne("Foundation.Library.Entities.AcademicYear", "AcademicYear")
                        .WithOne("Registration")
                        .HasForeignKey("Foundation.Library.Entities.Registration", "AcademicYearId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Foundation.Library.Entities.Course", "Course")
                        .WithOne("Registration")
                        .HasForeignKey("Foundation.Library.Entities.Registration", "CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Foundation.Library.Entities.Section", "Section")
                        .WithOne("Registration")
                        .HasForeignKey("Foundation.Library.Entities.Registration", "SectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Foundation.Library.Entities.Student", "Student")
                        .WithOne("Registration")
                        .HasForeignKey("Foundation.Library.Entities.Registration", "StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Foundation.Library.Entities.Section", b =>
                {
                    b.HasOne("Foundation.Library.Entities.Course", "Course")
                        .WithMany("Sections")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Foundation.Library.Entities.Employee", "Employee")
                        .WithOne("Section")
                        .HasForeignKey("Foundation.Library.Entities.Section", "TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Foundation.Library.Entities.Subject", b =>
                {
                    b.HasOne("Foundation.Library.Entities.Course", "Course")
                        .WithMany("Subjects")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
