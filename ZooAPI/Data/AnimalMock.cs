using System.Collections.Generic;
using System.Linq;
using ZooAPI.Models;

namespace ZooAPI.Data
{
    public class AnimalMock
    {
        public IQueryable<Animal> GetAnimalData()
        {
            var animals = new List<Animal>() {
                new Animal { ID = 1, Name = "Bear" },
                new Animal { ID = 2, Name = "Lion" },
                new Animal { ID = 3, Name = "Rhino" },
                new Animal { ID = 4, Name = "Tiger" },
                new Animal { ID = 5, Name = "Seal" },
                new Animal { ID = 6, Name = "Eagle" },
                new Animal { ID = 7, Name = "Walrus" },
                new Animal { ID = 8, Name = "Panther" },
                new Animal { ID = 9, Name = "Snake" }
            };

            return animals.AsQueryable();
        }
    }
}
