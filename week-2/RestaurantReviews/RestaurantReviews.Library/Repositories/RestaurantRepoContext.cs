using Microsoft.EntityFrameworkCore;
using RestaurantReviews.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantReviews.Library.Repositories
{
    public class RestaurantRepoContext : DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Review> Review { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Data Source=../../../restaurants.db";
            optionsBuilder.UseSqlite(connectionString);
        }
    }
}
