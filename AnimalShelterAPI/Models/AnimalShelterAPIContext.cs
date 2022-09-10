using Microsoft.EntityFrameworkCore;

namespace AnimalShelterAPI.Models
{
  public class AnimalShelterAPIContext : DbContext
  {
    public AnimalShelterAPIContext(DbContextOptions<AnimalShelterAPIContext> options)
      : base(options)
    {
    }

    public DbSet<Animal> Animals { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>()
        .HasData(
          
          new Animal {
            AnimalId = 249017, 
            Name = "Domino",
            Type = Type.Cat, 
            Breed = "Domestic Medium Hair",
            Sex = Sex.Male,
            Coloring = "Black",
            Age = 2,
            Weight = 11.8,
            Personality = Personality.Kind,
            About = "Love Cheek and Chin Scratches!",
            Adopted = false,
            },

            new Animal {
            AnimalId = 249281, 
            Name = "Doug", 
            Type = Type.Cat,
            Breed = "Domestic Short Hair",
            Sex = Sex.Male,
            Coloring = "Brown Tabby",
            Age = 0.3,
            Weight = 5.2,
            Personality = Personality.Playful,
            About = "Always PURRing and PURRfect!",
            Adopted = false,
            },

            new Animal {
            AnimalId = 249318, 
            Name = "Bunny",
            Type = Type.Cat, 
            Breed = "Domestic Short Hair",
            Sex = Sex.Male,
            Coloring = "Blue Tabby",
            Age = 2,
            Weight = 7.4,
            Personality = Personality.Shy,
            About = "Anxious around new animals and people, but very sweet!",
            Adopted = false,
            }

            new Animal {
            AnimalId = 248680, 
            Name = "Angus", 
            Type = Type.Dog,
            Breed = "Labrador",
            Sex = Sex.Male,
            Coloring = "Yellow",
            Age = 7,
            Weight = 101.3,
            Personality = Personality.Adventerous,
            About = "Playful biter, loves chassing rabbits!",
            Adopted = false,
            },

            new Animal {
            AnimalId = 227248, 
            Name = "Penny", 
            Type = Type.Dog,
            Breed = "American Pit Bull - Australian Shepherd",
            Sex = Sex.Female,
            Coloring = "White Brown",
            Age = 1.9,
            Weight = 52.1,
            Personality = Personality.Sassy,
            About = "A true HomeBuddy! Knows many tricks and is a quick learner!",
            Adopted = false,
            },

            new Animal {
            AnimalId = 249396, 
            Name = "Churro", 
            Type = Type.Dog,
            Breed = "Dachsund",
            Sex = Sex.Male,
            Coloring = "Red White",
            Age = 1.5,
            Weight = 15,
            Personality = Personality.Grumpy,
            About = "Love to Learn and Love to Cuddle!",
            Adopted = false,
            }
        );
    }
  }
}