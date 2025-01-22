﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using wisecorp.Context;

#nullable disable

namespace wisecorp.Migrations
{
    [DbContext(typeof(WisecorpContext))]
    [Migration("20241104172535_subprojectsaccess")]
    partial class subprojectsaccess
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("wisecorp.Models.DBModels.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("DepartementId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DisableDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("EmploymentDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double>("HourBank")
                        .HasColumnType("double");

                    b.Property<bool>("IsEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<double>("NbHour")
                        .HasColumnType("double");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PersonalEmail")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Picture")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Pseudo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<double>("Salary")
                        .HasColumnType("double");

                    b.Property<int>("TitleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DepartementId");

                    b.HasIndex("RoleId");

                    b.HasIndex("TitleId");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("wisecorp.Models.DBModels.Departement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Departements");
                });

            modelBuilder.Entity("wisecorp.Models.DBModels.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("Budget")
                        .HasColumnType("double");

                    b.Property<int>("CreatorId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double>("NbHour")
                        .HasColumnType("double");

                    b.Property<int?>("ParentProjectId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("CreatorId");

                    b.HasIndex("ParentProjectId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("wisecorp.Models.DBModels.ProjectAssignement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("AccountId")
                        .HasColumnType("int");

                    b.Property<int?>("DepartementId")
                        .HasColumnType("int");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("DepartementId");

                    b.HasIndex("ProjectId");

                    b.ToTable("ProjectAssignements");
                });

            modelBuilder.Entity("wisecorp.Models.DBModels.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("wisecorp.Models.DBModels.Title", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Titles");
                });

            modelBuilder.Entity("wisecorp.Models.DBModels.Work", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("AccountId")
                        .HasColumnType("int");

                    b.Property<decimal>("HourWorkedFri")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("HourWorkedMon")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("HourWorkedSat")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("HourWorkedSun")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("HourWorkedThur")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("HourWorkedTue")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("HourWorkedWed")
                        .HasColumnType("decimal(65,30)");

                    b.Property<bool>("IsEnable")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.Property<DateTime>("WeekStartDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("ProjectId");

                    b.ToTable("Works");
                });

            modelBuilder.Entity("wisecorp.Models.DBModels.Account", b =>
                {
                    b.HasOne("wisecorp.Models.DBModels.Departement", "Departement")
                        .WithMany()
                        .HasForeignKey("DepartementId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("wisecorp.Models.DBModels.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("wisecorp.Models.DBModels.Title", "Title")
                        .WithMany()
                        .HasForeignKey("TitleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Departement");

                    b.Navigation("Role");

                    b.Navigation("Title");
                });

            modelBuilder.Entity("wisecorp.Models.DBModels.Project", b =>
                {
                    b.HasOne("wisecorp.Models.DBModels.Account", "Creator")
                        .WithMany()
                        .HasForeignKey("CreatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("wisecorp.Models.DBModels.Project", "ParentProject")
                        .WithMany("SubProjects")
                        .HasForeignKey("ParentProjectId");

                    b.Navigation("Creator");

                    b.Navigation("ParentProject");
                });

            modelBuilder.Entity("wisecorp.Models.DBModels.ProjectAssignement", b =>
                {
                    b.HasOne("wisecorp.Models.DBModels.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId");

                    b.HasOne("wisecorp.Models.DBModels.Departement", "Departement")
                        .WithMany()
                        .HasForeignKey("DepartementId");

                    b.HasOne("wisecorp.Models.DBModels.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("Departement");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("wisecorp.Models.DBModels.Work", b =>
                {
                    b.HasOne("wisecorp.Models.DBModels.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId");

                    b.HasOne("wisecorp.Models.DBModels.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("wisecorp.Models.DBModels.Project", b =>
                {
                    b.Navigation("SubProjects");
                });
#pragma warning restore 612, 618
        }
    }
}
