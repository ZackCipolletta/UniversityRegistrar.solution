﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UniversityRegistrar.Models;

#nullable disable

namespace UniversityRegistrar.Migrations
{
    [DbContext(typeof(UniversityRegistrarContext))]
    [Migration("20230314215823_booleanToRelationshipStudentCourses3")]
    partial class booleanToRelationshipStudentCourses3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("UniversityRegistrar.Models.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("longtext");

                    b.HasKey("CourseId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("UniversityRegistrar.Models.CourseDepartment", b =>
                {
                    b.Property<int>("CourseDepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.HasKey("CourseDepartmentId");

                    b.HasIndex("CourseId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("CourseDepartments");
                });

            modelBuilder.Entity("UniversityRegistrar.Models.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("DepartmentId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("UniversityRegistrar.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Completed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("EnrollmentDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("StudentId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("UniversityRegistrar.Models.StudentCourse", b =>
                {
                    b.Property<int>("StudentCourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Completed")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("StudentCourseId");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentCourses");
                });

            modelBuilder.Entity("UniversityRegistrar.Models.StudentDepartment", b =>
                {
                    b.Property<int>("StudentDepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("StudentDepartmentId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentDepartments");
                });

            modelBuilder.Entity("UniversityRegistrar.Models.CourseDepartment", b =>
                {
                    b.HasOne("UniversityRegistrar.Models.Course", "Course")
                        .WithMany("JoinEntitiesCourseDepartments")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UniversityRegistrar.Models.Department", "Department")
                        .WithMany("JoinEntitiesCourseDepartments")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("UniversityRegistrar.Models.StudentCourse", b =>
                {
                    b.HasOne("UniversityRegistrar.Models.Course", "Course")
                        .WithMany("JoinEntitiesStudentCourses")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UniversityRegistrar.Models.Student", "Student")
                        .WithMany("JoinEntitiesStudentCourses")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("UniversityRegistrar.Models.StudentDepartment", b =>
                {
                    b.HasOne("UniversityRegistrar.Models.Department", "Department")
                        .WithMany("JoinEntitiesStudentDepartments")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UniversityRegistrar.Models.Student", "Student")
                        .WithMany("JoinEntitiesStudentDepartments")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("UniversityRegistrar.Models.Course", b =>
                {
                    b.Navigation("JoinEntitiesCourseDepartments");

                    b.Navigation("JoinEntitiesStudentCourses");
                });

            modelBuilder.Entity("UniversityRegistrar.Models.Department", b =>
                {
                    b.Navigation("JoinEntitiesCourseDepartments");

                    b.Navigation("JoinEntitiesStudentDepartments");
                });

            modelBuilder.Entity("UniversityRegistrar.Models.Student", b =>
                {
                    b.Navigation("JoinEntitiesStudentCourses");

                    b.Navigation("JoinEntitiesStudentDepartments");
                });
#pragma warning restore 612, 618
        }
    }
}
