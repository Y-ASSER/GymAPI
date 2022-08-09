using Microsoft.AspNetCore.Mvc;
using GymAPI.Models;
using GymAPI.Data;

namespace GymAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]

    public class TrainerController : ControllerBase
    {
        private readonly ITrainerRepository _trainerRepository;

        public TrainerController(ITrainerRepository trainerRepository)
        {
            _trainerRepository = trainerRepository;
        }


        [HttpGet]
        public ActionResult<IEnumerable<Trainer>> Get()
        {
            var Trainer = _trainerRepository.GetAllTrainer();
            return Ok(Trainer);
        }

        // GET api/<TrainerController>/5
        [HttpGet("{id}")]
        public Trainer Get(int id)
        {
            return _trainerRepository.GetTrainerById(id);
        }

        // POST api/<TrainerController>
        [HttpPost]
        public Trainer Post(string name, int time_experience)
        {
            return _trainerRepository.AddTrainer(name, time_experience);
        }

        // PUT api/<TrainerController>/5
        [HttpPut("{id}")]
        public Trainer Put(int id, string name, int time_experience)
        {
            return _trainerRepository.UpdateTrainer(id, name, time_experience);
        }

        // DELETE api/<TrainerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _trainerRepository.Delete(id);
        }
    }
}
