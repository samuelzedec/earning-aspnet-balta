﻿// <auto-generated />
using System;
using Library.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Library.Migrations
{
    [DbContext(typeof(LibraryDataContext))]
    [Migration("20241231204731_InitialCreation")]
    partial class InitialCreation
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ClientBook", b =>
                {
                    b.Property<int>("BookId")
                        .HasColumnType("INT");

                    b.Property<int>("ClientId")
                        .HasColumnType("INT");

                    b.HasKey("BookId", "ClientId");

                    b.HasIndex("ClientId");

                    b.ToTable("ClientBook");
                });

            modelBuilder.Entity("GenderBook", b =>
                {
                    b.Property<int>("BookId")
                        .HasColumnType("INT");

                    b.Property<int>("GenderId")
                        .HasColumnType("INT");

                    b.HasKey("BookId", "GenderId");

                    b.HasIndex("GenderId");

                    b.ToTable("GenderBook");
                });

            modelBuilder.Entity("Library.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("City");

                    b.Property<int>("ClientId")
                        .HasColumnType("INT");

                    b.Property<string>("Neighborhood")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("Neighborhood");

                    b.Property<int>("Number")
                        .HasColumnType("INT")
                        .HasColumnName("Number");

                    b.Property<string>("Road")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("Road");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("State");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("ZipCode");

                    b.HasKey("Id");

                    b.HasIndex("ClientId")
                        .IsUnique();

                    b.ToTable("Address", (string)null);
                });

            modelBuilder.Entity("Library.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<byte>("Age")
                        .HasColumnType("TINYINT")
                        .HasColumnName("Age");

                    b.Property<string>("Biography")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NVARCHAR")
                        .HasDefaultValue("## Não há registro informado sobre sua biografia ##")
                        .HasColumnName("Biography");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("DATE")
                        .HasColumnName("BirthDate");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("Name");

                    b.Property<string>("Nationality")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("Nationality");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "Name" }, "IX_Author_Name")
                        .IsUnique();

                    b.ToTable("Author", (string)null);
                });

            modelBuilder.Entity("Library.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("INT");

                    b.Property<short>("PublicationYear")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("SMALLINT")
                        .HasDefaultValue((short)2024)
                        .HasColumnName("PublicationYear");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("Title");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex(new[] { "Title" }, "IX_Book_Title")
                        .IsUnique();

                    b.ToTable("Book", (string)null);
                });

            modelBuilder.Entity("Library.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("DATE")
                        .HasColumnName("BirthDate");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("Email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("Name");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("Phone");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "Email" }, "IX_Client_Email")
                        .IsUnique();

                    b.ToTable("Client", (string)null);
                });

            modelBuilder.Entity("Library.Models.Gender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "Name" }, "IX_Gender_Name")
                        .IsUnique();

                    b.ToTable("Gender", (string)null);
                });

            modelBuilder.Entity("ClientBook", b =>
                {
                    b.HasOne("Library.Models.Book", null)
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_ClientBook_BookId");

                    b.HasOne("Library.Models.Client", null)
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_ClientBook_ClientId");
                });

            modelBuilder.Entity("GenderBook", b =>
                {
                    b.HasOne("Library.Models.Book", null)
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_GenderBook_BookId");

                    b.HasOne("Library.Models.Gender", null)
                        .WithMany()
                        .HasForeignKey("GenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_GenderBook_GenderId");
                });

            modelBuilder.Entity("Library.Models.Address", b =>
                {
                    b.HasOne("Library.Models.Client", "Client")
                        .WithOne("Address")
                        .HasForeignKey("Library.Models.Address", "ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Address_ClientId");

                    b.Navigation("Client");
                });

            modelBuilder.Entity("Library.Models.Book", b =>
                {
                    b.HasOne("Library.Models.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Book_AuthorId");

                    b.Navigation("Author");
                });

            modelBuilder.Entity("Library.Models.Author", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("Library.Models.Client", b =>
                {
                    b.Navigation("Address")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}