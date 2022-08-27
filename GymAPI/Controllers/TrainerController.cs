using GymAPI.Data;
using GymAPI.Models;
using GymAPI.Requests;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
            var Trainer = _trainerRepository.GetAllTrainers();
            return Ok(Trainer);
        }

        // GET api/<TrainerController>/5
        [HttpGet("{id}")]
        public Trainer Get(int Id)
        {
            return  _trainerRepository.GetTrainerById(Id);
        }

        // POST api/<TrainerController>
        [HttpPost]
        public Trainer Post(Trainer trainer)
        {
            return _trainerRepository.AddTrainer(trainer);
        }

        // PUT api/<TrainerController>/5
        [HttpPut("{Id}")]
        public Trainer Put(Trainer trainer)
        {
            return _trainerRepository.UpdateTrainer(trainer);
        }

        // DELETE api/<TrainerController>/5
        [HttpDelete("{Id}")]
        public void Delete(int Id)
        {
            _trainerRepository.Delete(Id);
        }
    }
}