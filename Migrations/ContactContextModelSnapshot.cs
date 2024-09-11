﻿// <auto-generated />
using Ch04Contacts.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Ch04Contacts.Migrations
{
    [DbContext(typeof(ContactContext))]
    partial class ContactContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Ch04Contacts.Models.Contact", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ContactId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNum")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ContactId");

                    b.ToTable("Contacts");

                    b.HasData(
                        new
                        {
                            ContactId = 1,
                            Address = "111 Test Avenue",
                            Name = "Ted Danson",
                            Note = "From Becker and The Good Place",
                            PhoneNum = "555-0123"
                        },
                        new
                        {
                            ContactId = 2,
                            Address = "166 Testing Street",
                            Name = "Joey Anderson",
                            Note = "Brother",
                            PhoneNum = "555-0124"
                        },
                        new
                        {
                            ContactId = 3,
                            Address = "103 Pretend Ave",
                            Name = "Aaron",
                            Note = "Boyfriend",
                            PhoneNum = "555-0125"
                        },
                        new
                        {
                            ContactId = 4,
                            Address = "201 Fake Boulevard",
                            Name = "Nick Turner",
                            Note = "Nephew",
                            PhoneNum = "555-0126"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
