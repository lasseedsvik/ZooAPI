using System.Collections.Generic;
using System.Linq;
using ZooAPI.Models;

namespace ZooAPI.Data
{
    public class AnimalRepository : IAnimalRepository
    {
        public IQueryable<Animal> Animals = new AnimalMock().GetAnimalData();
        
        public Animal GetAnimal(int id)
        {
            return Animals.Where(x => x.ID == id).FirstOrDefault();
        }

        public IEnumerable<Animal> GetAnimals()
        {
            return Animals.OrderBy(x => x.Name).ToList();
        }
    }
}
