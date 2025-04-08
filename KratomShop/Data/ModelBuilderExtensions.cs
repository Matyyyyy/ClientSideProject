using KratomShop.Models.Database;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace KratomShop.Data
{
    public static class ModelBuilderExtensions
    {
        public static ModelBuilder SeedUsers(this ModelBuilder builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();

            var user1 = new ApplicationUser
            {
                Id = "f9c0980f-0fac-44b1-a59e-d55a64d9ad01",
                UserName = "test@example.com",
                NormalizedUserName = "TEST@EXAMPLE.COM",
                Email = "test@example.com",
                NormalizedEmail = "TEST@EXAMPLE.COM",
                EmailConfirmed = true,
                SecurityStamp = "a7985672-2bb6-4d79-87e9-50b50b1547d3",
                ConcurrencyStamp = "c83c7a5b-384f-4931-9519-9cb38c9d5587",
                PhoneNumberConfirmed = false,
                LockoutEnabled = true,
                TwoFactorEnabled = false,
                AccessFailedCount = 0,
                FirstName = "Jan",
                LastName = "Novák",
                PasswordHash = "AQAAAAIAAYagAAAAELoBI1bJ+o6zQGobyYB41a8Ik1OMUq2ssHB/pVWg2ywvMyvdRoqrBmhGVQpG8RLtkg=="
            };

            var user2 = new ApplicationUser
            {
                Id = "f9c0980f-0fac-44b1-a59e-d55a64d9ad04",
                UserName = "user2@example.com",
                NormalizedUserName = "USER2@EXAMPLE.COM",
                Email = "user2@example.com",
                NormalizedEmail = "USER2@EXAMPLE.COM",
                EmailConfirmed = true,
                SecurityStamp = "5b9391c6-5c06-47f8-8ca6-cb12b6f45c2e",
                ConcurrencyStamp = "64bcc02f-f78b-4e96-bc91-23eefd7d60ad",
                FirstName = "Petr",
                LastName = "Novotný",
                PhoneNumberConfirmed = false,
                LockoutEnabled = true,
                TwoFactorEnabled = false,
                AccessFailedCount = 0,     
                PasswordHash = "AQAAAAIAAYagAAAAELoBI1bJ+o6zQGobyYB41a8Ik1OMUq2ssHB/pVWg2ywvMyvdRoqrBmhGVQpG8RLtkg=="
            };

            builder.Entity<ApplicationUser>().HasData(user1, user2);

            return builder; 
        }

        //seed items
        public static ModelBuilder SeedItems(this ModelBuilder builder)
        {
            builder.Entity<Item>().HasData(
                new Item
                {
                    Id = new Guid("e05c5364-c6ed-48a2-854b-c22aafd9b543"),
                    Name = "Kratom Red Bali",
                    Description = "A popular strain known for its relaxing effects.",
                    Price = 799.00m,
                    Stock = 100,
                    ImageUrl = "/images/green-bali.png",
                    CreatedAt = new DateTime(2024, 4, 6, 16, 20, 0, DateTimeKind.Utc).AddTicks(3306),
                    IsActive = true,
                    VatRate = 0.21m
                },
                new Item
                {
                    Id = new Guid("94734818-e8a8-4142-937e-af6d71dd2823"),
                    Name = "Kratom Green Maeng Da",
                    Description = "A potent strain with energizing effects.",
                    Price = 850.99m,
                    Stock = 50,
                    ImageUrl = "/images/green-bali.png",
                    CreatedAt = new DateTime(2024, 4, 6, 16, 20, 0, DateTimeKind.Utc).AddTicks(3306),
                    IsActive = true,
                    VatRate = 0.21m
                }
            );
            return builder;
        }

        //seed reviews
        public static ModelBuilder SeedReviews(this ModelBuilder builder)
        {
            builder.Entity<Review>().HasData(
                new Review
                {
                    Id = new Guid("03c02b6e-524e-4fed-9ac8-809acd6eef12"),
                    ItemId = new Guid("e05c5364-c6ed-48a2-854b-c22aafd9b543"),
                    UserId = "f9c0980f-0fac-44b1-a59e-d55a64d9ad01",
                    Rating = 5,
                    Comment = "Kratom byl výborný, určitě objednám znovu!",
                    CreatedAt = new DateTime(2024,4,6,16,20,0, DateTimeKind.Utc).AddTicks(3315)
                },
                new Review
                {
                    Id = new Guid("88b1a6fb-c1ae-4210-af91-282daad1e2b1"),
                    ItemId = new Guid("e05c5364-c6ed-48a2-854b-c22aafd9b543"),
                    UserId = "f9c0980f-0fac-44b1-a59e-d55a64d9ad04".ToString(),
                    Rating = 4,
                    Comment = "Velmi kvalitní kratom, jeden z nejlepších, co jsem vyzkoušel.",
                    CreatedAt = new DateTime(2024, 4, 6, 16, 25, 0, DateTimeKind.Utc).AddTicks(3315),
                }
            );
            return builder;
        }
    }
}
