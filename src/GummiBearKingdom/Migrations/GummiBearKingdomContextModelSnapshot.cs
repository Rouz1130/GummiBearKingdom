using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using GummiBearKingdom.Models;

namespace GummiBearKingdom.Migrations
{
    [DbContext(typeof(GummiBearKingdomContext))]
    partial class GummiBearKingdomContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GummiBearKingdom.Models.Blog", b =>
                {
                    b.Property<int>("BlogId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Author");

                    b.Property<string>("TextBody");

                    b.Property<string>("Title");

                    b.HasKey("BlogId");

                    b.ToTable("Blog");
                });

            modelBuilder.Entity("GummiBearKingdom.Models.Product", b =>
                {
                    b.Property<int>("ProductsId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cost");

                    b.Property<string>("Country");

                    b.Property<string>("Name");

                    b.HasKey("ProductsId");

                    b.ToTable("Products");
                });
        }
    }
}
