﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using v1jobportal.Data;

namespace v1jobportal.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "62b934f5-afe3-4eb9-b7e7-05777637a5f8",
                            ConcurrencyStamp = "f4769726-bee8-4b93-93cf-70b36db78544",
                            Name = "User",
                            NormalizedName = "USER"
                        },
                        new
                        {
                            Id = "67615ce7-518c-4202-a548-b9485e892000",
                            ConcurrencyStamp = "e7dab9ac-8ec6-4957-8d34-5216b682aabb",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("v1jobportal.Models.AllJobListings", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Certificate")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Deadline")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Diploma")
                        .HasColumnType("bit");

                    b.Property<bool>("Doctorate")
                        .HasColumnType("bit");

                    b.Property<string>("Duties")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DutyStation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("MastersDegree")
                        .HasColumnType("bit");

                    b.Property<bool>("bachelorsDegree")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("AllJobListings");
                });

            modelBuilder.Entity("v1jobportal.Models.ApplicantBioData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AlternativePhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmpId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("JobId")
                        .HasColumnType("int");

                    b.Property<int>("LanguagesSpoken")
                        .HasColumnType("int");

                    b.Property<string>("PrimaryPhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Residence")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("WorkedWithIDRC")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("ApplicantBioData");
                });

            modelBuilder.Entity("v1jobportal.Models.ApplicantDocuments", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Emp_Id")
                        .HasColumnType("int");

                    b.Property<int?>("Jd_JobId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<byte>("UploadCoverLetter")
                        .HasColumnType("tinyint");

                    b.Property<byte>("UploadCv")
                        .HasColumnType("tinyint");

                    b.HasKey("Id");

                    b.ToTable("ApplicantDocuments");
                });

            modelBuilder.Entity("v1jobportal.Models.ApplicantSummary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApplicantSummaryData")
                        .HasColumnType("nvarchar(1024)")
                        .HasMaxLength(1024);

                    b.HasKey("Id");

                    b.ToTable("ApplicantSummary");
                });

            modelBuilder.Entity("v1jobportal.Models.CertificationsAndAwards", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CertificationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CertificationName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CertifyingInstitutionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CertificationsAndAwards");
                });

            modelBuilder.Entity("v1jobportal.Models.EducationDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateQualificationWasAttained")
                        .HasColumnType("datetime2");

                    b.Property<string>("NameOfInstitution")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QualificationAttained")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EducaitonDetails");
                });

            modelBuilder.Entity("v1jobportal.Models.EmploymentHistoryModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmployerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EmploymentEndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EmploymentStartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SummaryOfAchievments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SummaryOfDuties")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EmploymentHistoryModel");
                });

            modelBuilder.Entity("v1jobportal.Models.PendingApplications", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bd_AlternativePhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Bd_FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Bd_LanguagesSpoken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Bd_LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Bd_MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Bd_PrimaryPhoneNumber")
                        .HasColumnType("nvarchar(13)")
                        .HasMaxLength(13);

                    b.Property<string>("Bd_Residence")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Bd_WorkedWithIDRC")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("Ca_CertificationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Ca_CertificationName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ca_CertifyingInstitutionName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Deadline")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Ed_DateQualificationWasAttained")
                        .HasColumnType("datetime2");

                    b.Property<string>("Ed_NameOfInstitution")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ed_QualificationAttained")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Eh_EmployerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Eh_EmploymentEndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Eh_EmploymentStartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Eh_JobTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Eh_SummaryOfAchievments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Eh_SummaryOfDuties")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Emp_Id")
                        .HasColumnType("int");

                    b.Property<int?>("Jd_JobId")
                        .HasColumnType("int");

                    b.Property<string>("Ud_CertificationAwardName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Ud_DateOfCertification")
                        .HasColumnType("datetime2");

                    b.Property<string>("Ud_InstitutionName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PendingApplications");
                });

            modelBuilder.Entity("v1jobportal.Models.Schedule", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("ScheduleCoverLeter")
                        .HasColumnType("bigint");

                    b.Property<long>("ScheduleCv")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.ToTable("Schedule");
                });

            modelBuilder.Entity("v1jobportal.Models.SubmittedApplication", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bd_AlternativePhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Bd_FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Bd_LanguagesSpoken")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Bd_LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Bd_MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Bd_PrimaryPhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(13)")
                        .HasMaxLength(13);

                    b.Property<string>("Bd_Residence")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Bd_WorkedWithIDRC")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Ca_CertificationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Ca_CertificationName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ca_CertifyingInstitutionName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Deadline")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Ed_DateQualificationWasAttained")
                        .HasColumnType("datetime2");

                    b.Property<string>("Ed_NameOfInstitution")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ed_QualificationAttained")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Eh_EmployerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Eh_EmploymentEndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Eh_EmploymentStartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Eh_JobTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Eh_SummaryOfAchievments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Eh_SummaryOfDuties")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Jd_JobId")
                        .HasColumnType("int");

                    b.Property<string>("Jd_JobTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ud_CertificationAwardName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Ud_DateOfCertification")
                        .HasColumnType("datetime2");

                    b.Property<string>("Ud_InstitutionName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SubmittedApplication");
                });

            modelBuilder.Entity("v1jobportal.ViewModels.EditRoleViewModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EditRoleViewModels");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
