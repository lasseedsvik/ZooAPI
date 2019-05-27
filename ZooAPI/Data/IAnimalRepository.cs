using System.Collections.Generic;
using ZooAPI.Models;

namespace ZooAPI.Data
{
    public interface IAnimalRepository
    {
        Animal GetAnimal(int id);
        IEnumerable<Animal> GetAnimals();
    }
}
