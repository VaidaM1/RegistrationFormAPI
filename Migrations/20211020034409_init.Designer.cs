﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RegistrationFormAPI.Data;

namespace RegistrationFormAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20211020034409_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RegistrationFormAPI.Entities.DropDownOption", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("DropDownOption");
                });

            modelBuilder.Entity("RegistrationFormAPI.Entities.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Question");
                });

            modelBuilder.Entity("RegistrationFormAPI.Entities.SelectedValue", b =>
                {
                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.Property<int>("DropDownOptionId")
                        .HasColumnType("int");

                    b.Property<int>("RegistrationId")
                        .HasColumnType("int");

                    b.HasKey("QuestionId", "DropDownOptionId");

                    b.HasIndex("DropDownOptionId");

                    b.ToTable("SelectedValue");
                });

            modelBuilder.Entity("RegistrationFormAPI.Entities.DropDownOption", b =>
                {
                    b.HasOne("RegistrationFormAPI.Entities.Question", "Question")
                        .WithMany("DropDownOptions")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");
                });

            modelBuilder.Entity("RegistrationFormAPI.Entities.SelectedValue", b =>
                {
                    b.HasOne("RegistrationFormAPI.Entities.DropDownOption", "DropDownOption")
                        .WithMany()
                        .HasForeignKey("DropDownOptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RegistrationFormAPI.Entities.Question", "Question")
                        .WithMany()
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DropDownOption");

                    b.Navigation("Question");
                });

            modelBuilder.Entity("RegistrationFormAPI.Entities.Question", b =>
                {
                    b.Navigation("DropDownOptions");
                });
#pragma warning restore 612, 618
        }
    }
}
