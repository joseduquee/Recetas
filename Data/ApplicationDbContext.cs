using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Recetas.Models;

namespace Recetas.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Receta>()
                .HasMany(x => x.Ingredient)
                .WithMany(r => r.Recetas)
                .UsingEntity<RecetaIngredient>(
                ri => ri.HasOne(prop => prop.Ingredient)
                .WithMany()
                .HasForeignKey(prop => prop.IngredientId),
                ri => ri.HasOne(prop => prop.Receta)
                .WithMany()
                .HasForeignKey(prop => prop.RecetaId),
                ri =>
                {
                    ri.Property(prop => prop.Cantidad);
                    ri.HasKey(prop => new
                    {
                        prop.RecetaId,
                        prop.IngredientId
                    });
                }
                    
                );

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Receta> Recetas { get; set; }
        public DbSet<MenuCategory> MenuCategories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<CuisineType> CuisineTypes { get; set; }
        public DbSet<RecetaIngredient> RecetaIngredients { get; set; }
        
        
    }
}
