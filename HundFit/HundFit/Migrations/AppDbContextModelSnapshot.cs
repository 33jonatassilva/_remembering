﻿// <auto-generated />
using System;
using HundFit.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HundFit.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HundFit.Data.Models.Exercise", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(2500)
                        .HasColumnType("nvarchar(2500)");

                    b.Property<float>("Load")
                        .HasColumnType("real");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("RepetitionsPerSeries")
                        .HasColumnType("int");

                    b.Property<int>("Series")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Exercises");
                });

            modelBuilder.Entity("HundFit.Data.Models.Instructor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("SpecialtyEnum")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Instructors");
                });

            modelBuilder.Entity("HundFit.Data.Models.PhysicalAssessment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("ActualWeight")
                        .HasColumnType("real");

                    b.Property<float>("FatBody")
                        .HasColumnType("real");

                    b.Property<Guid>("InstructorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("LeanMass")
                        .HasColumnType("real");

                    b.Property<DateTime>("PhysicalAssessmentDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("InstructorId");

                    b.HasIndex("StudentId");

                    b.ToTable("PhysicalAssessments");
                });

            modelBuilder.Entity("HundFit.Data.Models.Plan", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("DurationInMonths")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("Plans");
                });

            modelBuilder.Entity("HundFit.Data.Models.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<float>("Height")
                        .HasColumnType("real");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid>("PlanId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("TrainingId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("Weight")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("PlanId");

                    b.HasIndex("TrainingId")
                        .IsUnique()
                        .HasFilter("[TrainingId] IS NOT NULL");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("HundFit.Data.Models.Training", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(2500)
                        .HasColumnType("nvarchar(2500)");

                    b.Property<int>("DurationInMinutes")
                        .HasColumnType("int");

                    b.Property<Guid>("InstructorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid?>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("InstructorId");

                    b.ToTable("Trainings");
                });

            modelBuilder.Entity("HundFit.Data.Models.TrainingExercises", b =>
                {
                    b.Property<Guid>("TrainingId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ExerciseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("TrainingId", "ExerciseId");

                    b.HasIndex("ExerciseId");

                    b.ToTable("TrainingExercises");
                });

            modelBuilder.Entity("HundFit.Data.Models.PhysicalAssessment", b =>
                {
                    b.HasOne("HundFit.Data.Models.Instructor", "Instructor")
                        .WithMany()
                        .HasForeignKey("InstructorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("HundFit.Data.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Instructor");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("HundFit.Data.Models.Student", b =>
                {
                    b.HasOne("HundFit.Data.Models.Plan", "Plan")
                        .WithMany("Students")
                        .HasForeignKey("PlanId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("HundFit.Data.Models.Training", "Training")
                        .WithOne("Student")
                        .HasForeignKey("HundFit.Data.Models.Student", "TrainingId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Plan");

                    b.Navigation("Training");
                });

            modelBuilder.Entity("HundFit.Data.Models.Training", b =>
                {
                    b.HasOne("HundFit.Data.Models.Instructor", "Instructor")
                        .WithMany("Trainings")
                        .HasForeignKey("InstructorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("HundFit.Data.Models.TrainingExercises", b =>
                {
                    b.HasOne("HundFit.Data.Models.Exercise", "Exercise")
                        .WithMany("TrainingExercises")
                        .HasForeignKey("ExerciseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HundFit.Data.Models.Training", "Training")
                        .WithMany("TrainingExercises")
                        .HasForeignKey("TrainingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exercise");

                    b.Navigation("Training");
                });

            modelBuilder.Entity("HundFit.Data.Models.Exercise", b =>
                {
                    b.Navigation("TrainingExercises");
                });

            modelBuilder.Entity("HundFit.Data.Models.Instructor", b =>
                {
                    b.Navigation("Trainings");
                });

            modelBuilder.Entity("HundFit.Data.Models.Plan", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("HundFit.Data.Models.Training", b =>
                {
                    b.Navigation("Student")
                        .IsRequired();

                    b.Navigation("TrainingExercises");
                });
#pragma warning restore 612, 618
        }
    }
}
