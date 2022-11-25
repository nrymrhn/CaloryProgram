using Nau.Dal.EntityConfiguration;
using Nau.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nau.Dal
{
    public class NauDbContext: DbContext
    {
        public NauDbContext()
        {
            Database.Connection.ConnectionString = @"Server= DESKTOP-KER4I6U; Database= NauCaloryDB; Uid= sa; Pwd= 123;"; ;
        }

        public DbSet<ActivityType> ActivityTypes { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<MealDetail> MealDetails { get; set; }
        public DbSet<MealType> MealTypes { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Configurations.Add(new ActivityTypeConfiguration());
            modelBuilder.Configurations.Add(new UserConfiguration());
            modelBuilder.Configurations.Add(new MealTypeConfiguration());
            modelBuilder.Configurations.Add(new CategoryConfiguration());
            modelBuilder.Configurations.Add(new MealConfiguration());
            modelBuilder.Configurations.Add(new FoodConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
