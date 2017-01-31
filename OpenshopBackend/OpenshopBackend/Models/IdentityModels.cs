﻿using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace OpenshopBackend.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public System.Data.Entity.DbSet<OpenshopBackend.Models.Category> Categories { get; set; }

        public System.Data.Entity.DbSet<OpenshopBackend.Models.Product> Products { get; set; }

        public System.Data.Entity.DbSet<OpenshopBackend.Models.ProductVariant> ProductVariants { get; set; }

        public System.Data.Entity.DbSet<OpenshopBackend.Models.Brand> Brands { get; set; }

        public System.Data.Entity.DbSet<OpenshopBackend.Models.Color> Colors { get; set; }

        public System.Data.Entity.DbSet<OpenshopBackend.Models.Size> Sizes { get; set; }

        public System.Data.Entity.DbSet<OpenshopBackend.Models.Shop> Shops { get; set; }

        public System.Data.Entity.DbSet<OpenshopBackend.Models.Banner> Banners { get; set; }

        public System.Data.Entity.DbSet<OpenshopBackend.Models.Device> Devices { get; set; }

        public System.Data.Entity.DbSet<OpenshopBackend.Models.DeviceUser> DeviceUser { get; set; }

        public System.Data.Entity.DbSet<OpenshopBackend.Models.Cart> Carts { get; set; }

        public System.Data.Entity.DbSet<OpenshopBackend.Models.CartProductItem> CartProductItems { get; set; }

        public System.Data.Entity.DbSet<OpenshopBackend.Models.CartProductVariant> CartProductVariants { get; set; }

        public System.Data.Entity.DbSet<OpenshopBackend.Models.Order> Orders { get; set; }
        public System.Data.Entity.DbSet<OpenshopBackend.Models.OrderItem> OrderItems { get; set; }
    }
}