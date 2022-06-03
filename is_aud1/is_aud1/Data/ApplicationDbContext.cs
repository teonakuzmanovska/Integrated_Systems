using is_aud1.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace is_aud1.Data
{
    public class ApplicationDbContext : IdentityDbContext<ShopApplicationUser>
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<ProductsInShoppingCart> ProductsInShoppingCarts { get; set; }
        public DbSet<ShopApplicationUser> ShopApplicationUsers { get; set; }

        // this is in order to obtain composite key for ProductsInShoppingCarts
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<ProductsInShoppingCart>().HasKey(c => new { c.CartId, c.ProductId });
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
