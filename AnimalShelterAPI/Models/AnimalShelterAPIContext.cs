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
            AnimalId = 1, 
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
            AnimalId = 2, 
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
            AnimalId = 3, 
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
            },

            new Animal {
            AnimalId = 4, 
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
            AnimalId = 5, 
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
            AnimalId = 6, 
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
            },

            new Animal {
            AnimalId = 7, 
            Name = "Milo", 
            Type = Type.Dog,
            Breed = "Cattle",
            Sex = Sex.Female,
            Coloring = "Black White",
            Age = 3,
            Weight = 50,
            Personality = Personality.Energetic,
            About = "Fun fun fun!",
            Adopted = false,
            },

            new Animal {
            AnimalId = 8, 
            Name = "Mitsy", 
            Type = Type.Cat,
            Breed = "Calico",
            Sex = Sex.Female,
            Coloring = "Black White Orange",
            Age = 5,
            Weight = 15,
            Personality = Personality.Grumpy,
            About = "Wild heart!",
            Adopted = false,
            },

            new Animal {
            AnimalId = 9, 
            Name = "Brutus", 
            Type = Type.Dog,
            Breed = "Hound",
            Sex = Sex.Male,
            Coloring = "Brown White",
            Age = 7,
            Weight = 75,
            Personality = Personality.Adventerous,
            About = "I love to explore!",
            Adopted = false,
            },

            new Animal {
            AnimalId = 10, 
            Name = "Baron", 
            Type = Type.Dog,
            Breed = "Collie",
            Sex = Sex.Male,
            Coloring = "Black Tan",
            Age = 8,
            Weight = 55,
            Personality = Personality.Kind,
            About = "Follow my leader!",
            Adopted = false,
            },

            new Animal {
            AnimalId = 11, 
            Name = "Brew", 
            Type = Type.Dog,
            Breed = "Mix",
            Sex = Sex.Female,
            Coloring = "Golden",
            Age = 1.5,
            Weight = 35,
            Personality = Personality.Sweet,
            About = "Lets play!",
            Adopted = false,
            },

            new Animal {
            AnimalId = 12, 
            Name = "Midge", 
            Type = Type.Cat,
            Breed = "Tabby",
            Sex = Sex.Male,
            Coloring = "Brown Grey",
            Age = 5,
            Weight = 22,
            Personality = Personality.Sassy,
            About = "Shop cat!",
            Adopted = false,
            },

            new Animal {
            AnimalId = 13, 
            Name = "Chubs", 
            Type = Type.Dog,
            Breed = "Chow",
            Sex = Sex.Male,
            Coloring = "Grey",
            Age = 6.5,
            Weight = 65,
            Personality = Personality.Playful,
            About = "Throw the ball please!",
            Adopted = false,
            }
        );
    }
  }
}