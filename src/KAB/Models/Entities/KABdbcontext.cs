using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace KAB.Models.Entities
{
    public partial class KABdbcontext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            optionsBuilder.UseSqlServer(@"Data Source=ACADEMY-6211VF7;Initial Catalog=Project1;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>(entity =>
            {
                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Street)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Town)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Zip)
                    .IsRequired()
                    .HasColumnType("varchar(25)");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Address_Customer");
            });

            modelBuilder.Entity<Admin>(entity =>
            {
                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<Categories>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<CategoriesProducts>(entity =>
            {
                entity.ToTable("Categories_Products");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.CategoriesProducts)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Categories_Products_Categories");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.CategoriesProducts)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Categories_Products_Product");
            });

            modelBuilder.Entity<CategoryCategories>(entity =>
            {
                entity.ToTable("Category_Categories");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.CategoryCategoriesCategory)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Category_Categories_Categories");

                entity.HasOne(d => d.SubCategory)
                    .WithMany(p => p.CategoryCategoriesSubCategory)
                    .HasForeignKey(d => d.SubCategoryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Category_Categories_Categories1");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.Date).HasColumnType("date");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Order_Customer");
            });

            modelBuilder.Entity<OrderRow>(entity =>
            {
                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderRow)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OrderRow_Order");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrderRow)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OrderRow_Product");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.Articlenumber)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Description).HasColumnType("varchar(max)");

                entity.Property(e => e.ImageUrl).HasColumnType("varchar(100)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Price).HasColumnType("money");
            });

            modelBuilder.Entity<StockStatus>(entity =>
            {
                entity.HasOne(d => d.Product)
                    .WithMany(p => p.StockStatus)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_StockStatus_Product");
            });
        }

        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<CategoriesProducts> CategoriesProducts { get; set; }
        public virtual DbSet<CategoryCategories> CategoryCategories { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<OrderRow> OrderRow { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<StockStatus> StockStatus { get; set; }
    }
}