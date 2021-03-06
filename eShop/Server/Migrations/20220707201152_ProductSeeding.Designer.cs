// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using eShop.Server.Data;

#nullable disable

namespace eShop.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220707201152_ProductSeeding")]
    partial class ProductSeeding
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("eShop.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "The reclusive Kya Clark is suspected in the death of Chase Andrews",
                            ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/51-uh7zesTL._SL300.jpg",
                            Price = 9.99m,
                            Title = "Where the Crawdads Sing"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Youth: Belly has an unforgettable summer with old friends and new experiences",
                            ImageUrl = "https://booklist.usatoday.com/covers/isbn/9781416968290.jpg",
                            Price = 19.99m,
                            Title = "The Summer I Turned Pretty"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Ryle Kincaid's relationship with Lily becomes complicated when a man from her past shows up",
                            ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/51KZalxuryL._SL300.jpg",
                            Price = 3.99m,
                            Title = "It Ends With Us"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
