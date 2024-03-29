﻿// <auto-generated />
using System;
using EFTask2.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFTask2.Migrations
{
    [DbContext(typeof(LibraryDBContext2))]
    [Migration("20240128095637_mig2")]
    partial class mig2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EFTask2.Entities.Curator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .ValueGeneratedOnUpdateSometimes()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Name");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .ValueGeneratedOnUpdateSometimes()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.ToTable("Curators");
                });

            modelBuilder.Entity("EFTask2.Entities.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Building")
                        .HasColumnType("int");

                    b.Property<int>("FacultyId")
                        .HasColumnType("int");

                    b.Property<decimal>("Financing")
                        .HasColumnType("money")
                        .HasColumnName("Financing");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.HasIndex("FacultyId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("EFTask2.Entities.Faculty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Faculties");
                });

            modelBuilder.Entity("EFTask2.Entities.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Name");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("EFTask2.Entities.GroupsCurators", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CuratorId")
                        .HasColumnType("int");

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CuratorId");

                    b.HasIndex("GroupId");

                    b.ToTable("GroupsCurators");
                });

            modelBuilder.Entity("EFTask2.Entities.GroupsLectures", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<int>("LectureId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.HasIndex("LectureId");

                    b.ToTable("GroupsLectures");
                });

            modelBuilder.Entity("EFTask2.Entities.GroupsStudents", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.HasIndex("StudentId");

                    b.ToTable("GroupsStudents");
                });

            modelBuilder.Entity("EFTask2.Entities.Lecture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("LectureDate")
                        .HasColumnType("date")
                        .HasColumnName("LectureDate");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SubjectId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Lectures");
                });

            modelBuilder.Entity("EFTask2.Entities.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Name");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Surname");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("EFTask2.Entities.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("EFTask2.Entities.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("IsProfessor")
                        .HasColumnType("bit")
                        .HasColumnName("IsProfessor");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Name");

                    b.Property<decimal>("Salary")
                        .HasColumnType("money")
                        .HasColumnName("Salary");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Surname");

                    b.HasKey("Id");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("EFTask2.Entities.Department", b =>
                {
                    b.HasOne("EFTask2.Entities.Faculty", "Faculty")
                        .WithMany("Departments")
                        .HasForeignKey("FacultyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Faculty");
                });

            modelBuilder.Entity("EFTask2.Entities.Group", b =>
                {
                    b.HasOne("EFTask2.Entities.Department", "Department")
                        .WithMany("Groups")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("EFTask2.Entities.GroupsCurators", b =>
                {
                    b.HasOne("EFTask2.Entities.Curator", "Curator")
                        .WithMany("GroupsCurators")
                        .HasForeignKey("CuratorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFTask2.Entities.Group", "Group")
                        .WithMany("GroupsCurators")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Curator");

                    b.Navigation("Group");
                });

            modelBuilder.Entity("EFTask2.Entities.GroupsLectures", b =>
                {
                    b.HasOne("EFTask2.Entities.Group", "Group")
                        .WithMany("GroupsLectures")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFTask2.Entities.Lecture", "Lecture")
                        .WithMany("GroupsLectures")
                        .HasForeignKey("LectureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");

                    b.Navigation("Lecture");
                });

            modelBuilder.Entity("EFTask2.Entities.GroupsStudents", b =>
                {
                    b.HasOne("EFTask2.Entities.Group", "Group")
                        .WithMany("GroupsStudents")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFTask2.Entities.Student", "Student")
                        .WithMany("GroupsStudents")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("EFTask2.Entities.Lecture", b =>
                {
                    b.HasOne("EFTask2.Entities.Subject", "Subject")
                        .WithMany("Lecture")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFTask2.Entities.Teacher", "Teacher")
                        .WithMany("Lecture")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Subject");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("EFTask2.Entities.Curator", b =>
                {
                    b.Navigation("GroupsCurators");
                });

            modelBuilder.Entity("EFTask2.Entities.Department", b =>
                {
                    b.Navigation("Groups");
                });

            modelBuilder.Entity("EFTask2.Entities.Faculty", b =>
                {
                    b.Navigation("Departments");
                });

            modelBuilder.Entity("EFTask2.Entities.Group", b =>
                {
                    b.Navigation("GroupsCurators");

                    b.Navigation("GroupsLectures");

                    b.Navigation("GroupsStudents");
                });

            modelBuilder.Entity("EFTask2.Entities.Lecture", b =>
                {
                    b.Navigation("GroupsLectures");
                });

            modelBuilder.Entity("EFTask2.Entities.Student", b =>
                {
                    b.Navigation("GroupsStudents");
                });

            modelBuilder.Entity("EFTask2.Entities.Subject", b =>
                {
                    b.Navigation("Lecture");
                });

            modelBuilder.Entity("EFTask2.Entities.Teacher", b =>
                {
                    b.Navigation("Lecture");
                });
#pragma warning restore 612, 618
        }
    }
}
