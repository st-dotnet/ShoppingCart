using Microsoft.EntityFrameworkCore;
using ShoppingProject.Data.Entities;

namespace ShoppingProject.Data
{
    public class ShoppingDbContext : DbContext
    {
        public ShoppingDbContext(DbContextOptions<ShoppingDbContext> options) : base(options)
        {
        }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImages> ProductImages { get; set; }
        public DbSet<Addresses> Address { get; set; }
        public DbSet<UserAddress> UsersAddresses { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItems> OrdersItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(x => x.Id);
                entity.ToTable("Role");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.HasOne(d => d.Roles)
                .WithMany(p=>p.Users)
                .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<ProductCategory>(entity =>
            {
                entity.HasKey(e=>e.Id);
                entity.ToTable("ProductCategory");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.HasOne(d => d.ProductCategory)
                .WithMany(p => p.products)
                .HasForeignKey(d => d.CategoryId);
            });

            modelBuilder.Entity<ProductImages>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.HasOne(d => d.Product)
                .WithMany(p => p.ProductImages)
                .HasForeignKey(d => d.ProductId);
            });

            modelBuilder.Entity<Addresses>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.ToTable("Adddresses");
            });

            modelBuilder.Entity<UserAddress>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.HasOne(d => d.Addresses)
                .WithMany(e => e.UserAddresses)
                .HasForeignKey(x => x.AddressId);
            });

            modelBuilder.Entity<UserAddress>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.HasOne(d => d.Users)
                .WithMany(p => p.UserAddresses)
                .HasForeignKey(x => x.UserId);
            });

            modelBuilder.Entity<Cart>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.HasOne(d => d.User)
                    .WithMany(p => p.Carts)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<CartItem>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.HasOne(d => d.Cart)
                    .WithMany(p => p.CartItems)
                    .HasForeignKey(d => d.CartId);
            });
            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.HasOne(d => d.User)
                .WithMany(p => p.Orders)
                .HasForeignKey(k => k.UserId);
            });
            modelBuilder.Entity<OrderItems>(entity =>
            {
                entity.HasKey(x => x.Id);
                entity.HasOne(v => v.Order)
                .WithMany(x => x.OrdersItems)
                .HasForeignKey(i => i.ProductId);
            });

            modelBuilder.Entity<OrderItems>(entity =>
            {
                entity.HasKey(x => x.Id);
                entity.HasOne(v => v.Order)
                .WithMany(x => x.OrdersItems)
                .HasForeignKey(i => i.OrderId);
            });
        }
    }
}
