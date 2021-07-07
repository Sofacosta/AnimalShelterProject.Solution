using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
    public class AnimalShelterContext : DbContext
    {
        public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Animal>()
            .HasData(
            new Animal { AnimalId = 1, Name = "Floffy", Species = "Dog", Age = 1, Gender = "Female" },
            new Animal { AnimalId = 2, Name = "Rex", Species = "Cat", Age = 3, Gender = "Female" },
            new Animal { AnimalId = 3, Name = "Ziggy", Species = "Dog", Age = 8, Gender = "Female" },
            new Animal { AnimalId = 4, Name = "Hadouken", Species = "Cat", Age = 11, Gender = "Male" },
            new Animal { AnimalId = 5, Name = "Rufo", Species = "Cat", Age = 2, Gender = "Male" }
            );
        }

        public DbSet<Animal> Animals { get; set; }
    }
}