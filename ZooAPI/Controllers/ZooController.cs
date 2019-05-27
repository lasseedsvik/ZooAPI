using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ZooAPI.Data;
using ZooAPI.Models;

namespace ZooAPI.Controllers
{
    [Route("zoo/api")]
    [ApiController]
    public class ZooController : ControllerBase
    {
        private AnimalRepository _rep = new AnimalRepository();

        [HttpGet]
        public IEnumerable<Animal> Get()
        {
            return _rep.GetAnimals();
        }

        [HttpGet("{id}")]
        public ActionResult<Animal> Get(int id)
        {
            return _rep.GetAnimal(id);
        }
    }
}
