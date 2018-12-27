﻿// <auto-generated />
using System;
using AtlasCompanyTracker.Database.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AtlasCompanyTracker.Database.Migrations
{
    [DbContext(typeof(ResourceContext))]
    [Migration("20181227203623_Resource-Initial")]
    partial class ResourceInitial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AtlasCompanyTracker.Models.Models.ResourceModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<Guid>("ResourceGuid");

                    b.Property<string>("Thumbnail");

                    b.HasKey("ID");

                    b.ToTable("Resources");
                });
#pragma warning restore 612, 618
        }
    }
}