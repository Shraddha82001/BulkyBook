using Bulky.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Bulky.DataAcess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<OrderHeader> OrderHeaders { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Scifi", DisplayOrder = 2 },
                new Category { Id = 3, Name = "History", DisplayOrder = 3 }
            );

            modelBuilder.Entity<Company>().HasData(
                new Company { 
                    Id = 1, 
                    Name = "Tech Solution",
                    StreetAddress = "123 tech st",
                    City="Tech city",
                    PostalCode= "123456",
                    State="IL",
                    PhoneNumber="7766554433"
                },
                new Company {
                    Id = 2,
                    Name = "Tech1 Solution",
                    StreetAddress = "133 tech st",
                    City = "Tech1 city",
                    PostalCode = "123459",
                    State = "IL1",
                    PhoneNumber = "7766554430"
                },
                new Company {
                    Id = 3,
                    Name = "Tech2 Solution",
                    StreetAddress = "124 tech st",
                    City = "Tech2 city",
                    PostalCode = "123486",
                    State = "IL2",
                    PhoneNumber = "7766554437"
                }
           );

            modelBuilder.Entity<Product>().HasData(
            new Product
            {
                Id = 1,
                Title = "Fortune of Time",
                Author = "Billy Spark",
                Description = "Present model",
                ISBN = "er9090009",
                ListPrice = 99,
                Price = 89,
                //Pricee50 = 87,
                Price100 = 78,
                CategoryId = 1
            },
           new Product
           {
               Id = 2,
               Title = "Fortune of Time",
               Author = "Billy Spark",
               Description = "Present model",
               ISBN = "er9090009",
               ListPrice = 99,
               Price = 89,
               Price50 = 87,
               Price100 = 78,
               CategoryId = 1
           },
              new Product
              {
                  Id = 3,
                  Title = "Fortune of world",
                  Author = "Billy world",
                  Description = "Present world",
                  ISBN = "er9090889",
                  ListPrice = 79,
                  Price = 69,
                  Price50 = 67,
                  Price100 = 68,
                  CategoryId = 2
              },
              new Product
              {
                  Id = 4,
                  Title = "Fortune of world",
                  Author = "Billy world",
                  Description = "Present world",
                  ISBN = "er9090889",
                  ListPrice = 79,
                  Price = 69,
                  Price50 = 67,
                  Price100 = 68,
                  CategoryId = 2
              },
              new Product
              {
                  Id = 5,
                  Title = "Fortune of world",
                  Author = "Billy world",
                  Description = "Present world",
                  ISBN = "er9090889",
                  ListPrice = 79,
                  Price = 69,
                  Price50 = 67,
                  Price100 = 68,
                  CategoryId = 3
              },
              new Product
              {
                  Id = 6,
                  Title = "Fortune of world",
                  Author = "Billy world",
                  Description = "Present world",
                  ISBN = "er9090889",
                  ListPrice = 79,
                  Price = 69,
                  Price50 = 67,
                  Price100 = 68,
                  CategoryId = 3
              });
            modelBuilder.Entity<OrderDetail>().ToTable("OrderDetails");
     //       modelBuilder.Entity<ApplicationUser>()
     //.Property(u => u.LockoutEnd)
     //.HasConversion(
     //    v => v.HasValue ? v.Value.UtcDateTime : (DateTime?)null, // Convert to datetime for DB
     //    v => v.HasValue ? new DateTimeOffset(DateTime.SpecifyKind(v.Value, DateTimeKind.Utc)) : (DateTimeOffset?)null // Convert back
     //);
        }
    }
}
