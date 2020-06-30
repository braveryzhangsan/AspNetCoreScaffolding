﻿// <auto-generated />
using System;
using Kay.Boilerplate.Infrastructure.BoundedContext.Ef;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Kay.Boilerplate.Infrastructure.BoundedContext.Ef.Migrations
{
    [DbContext(typeof(BoilerplateDbContext))]
    [Migration("20200623013953_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Kay.Boilerplate.Domain.Entities.TbUserEntity", b =>
                {
                    b.Property<long>("Id");

                    b.Property<DateTime?>("AddTime");

                    b.Property<DateTime?>("ModTime");

                    b.Property<string>("Password");

                    b.Property<int>("Status");

                    b.Property<string>("UserName");

                    b.Property<int>("UserType");

                    b.HasKey("Id");

                    b.ToTable("TbAccount");
                });
#pragma warning restore 612, 618
        }
    }
}