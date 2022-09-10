using System;

namespace AnimalShelterAPI.Models
{
  public abstract class Animal
  {
    public int AnimalId { get; set; }
    [Required]
    [StringLength(25)]
    public string Name { get; set; }
    [Required]
    public Type Type { get; set; }
    [Required]
    public string Breed { get; set; }
    [Required]
    public Sex Sex { get; set; }
    [Required]
    public string Coloring { get; set; }
    [Required]
    [Range(0, 25, ErrorMessage = "Age must be between 0 and 25.")]
    public double Age{ get; set; }
    [Required]
    public double Weight { get; set; }
    [Required]
    public Personality Personality { get; set; }
    [Required]
    public string About { get; set; }
    [Required]
    public bool Adopted { get; set; }
    [Required]
    public DateTime AdoptionDate { get; set; }

  }

  public enum Type
  {
    Cat,
    Dog
  }

  public enum Sex
  {
    Male,
    Female
  }

  public enum Personality
  {
    Grumpy,
    Sassy,
    Sweet,
    Kind,
    Playful,
    Shy,
    Adventerous,
    Energetic
  }
}