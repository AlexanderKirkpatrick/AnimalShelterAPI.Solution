using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimalShelterAPI.Models;

namespace AnimalShelterAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AnimalsController : ControllerBase
  {
    private AnimalShelterAPIContext _db;

    public AnimalsController(AnimalShelterAPIContext db)
    {
      _db = db;
    }

    //GET api/Animals
    //http://localhost:5000/api/Animals?PageNumber=2
    //http://localhost:5000/api/Animals?PageNumber=2&PageSize=1
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Animal>>> Get ([FromQuery] PaginationFilter pagination)
    {
      var animals = await _db.Animals
      .Skip((pagination.PageNumber -1) * pagination.PageSize)
      .Take(pagination.PageSize)
      .ToListAsync();

      return animals;
    }

    //GET api/Animals/3 - Get for specific Animal
    [HttpGet("{AnimalId}")]
    public async Task<ActionResult<Animal>> GetAction(int AnimalId)
    {
      Animal animal = await _db.Animals.FirstOrDefaultAsync(d => d.AnimalId == AnimalId);
      return animal;
    }

    // http://localhost:5000/api/Animals/Search/searchString?searchString=Z
    //GET api/Cats/Search
    [HttpGet("Search/searchString")]
    public async Task<ActionResult<IEnumerable<Animal>>> GetSearch([FromQuery] string searchString, [FromQuery] PaginationFilter pagination)
    {
      var animals = await _db.Animals
      .Where(c => c.Name.Contains(searchString))
      .Skip((pagination.PageNumber -1) * pagination.PageSize)
      .Take(pagination.PageSize)
      .ToListAsync();

      return animals;
    }

    //Get api/Animals/random
    [HttpGet("Random")]
    public async Task<ActionResult<Animal>> GetRandom ()
    {
      Random random = new Random();
      var animals = await _db.Animals.ToListAsync();
      Animal animal = animals.ElementAt(random.Next(0, animals.Count()));
      return animal;
    }

    // POST api/Animals
    [HttpPost]
    public void Post([FromBody] Animal animal)
    {
      _db.Animals.Add(animal);
      _db.SaveChanges();
    }

    //PUT api/Animals/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Animal animal)
    {
      animal.AnimalId = id;
      _db.Entry(animal).State = EntityState.Modified;
      _db.SaveChanges();
    }

    //DELETE api/Animals/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var AnimalToDelete = _db.Animals.FirstOrDefault(d => d.AnimalId == id);
      _db.Animals.Remove(AnimalToDelete);
      _db.SaveChanges();
    }
  }
}