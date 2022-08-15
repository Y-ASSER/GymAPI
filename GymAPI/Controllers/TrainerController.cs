 GymAPI.Data;
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
        private readonly ITrainerRepository_trainerRepository;

        public TrainerController(ITrainerRepository trainerRepository)
        {
            _trainerRepository=trainerRepository;
        }


       [HttpGet]
        public ActionResult<IEnumerable<Trainer>> Get()
        {
            var Trainer = _trainerRepository.GetAllTrainer();
            return Ok(Trainer);
        }

        // GET api/<TrainerController>/5
        [HttpGet("{id}")]
        public Trainer Get(int Id)
        {
            return _trainerRepository.GetTrainerById(Id);
        }

        // POST api/<TrainerController>
        [HttpPost]
        public Trainer Post(string name,int Time_experience)
        {
            return _trainerRepository.AddTrainer(name, Time_experience);
        }

        // PUT api/<TrainerController>/5
        [HttpPut("{Id}")]
        public Trainer Put(int Id, string name,int Time_experience)
        {
            return _trainerRepository.UpdateTrainer(Id, name, Time_experience);
        }

        // DELETE api/<TrainerController>/5
        [HttpDelete("{Id}")]
        public voId Delete(int Id)
        {
            _trainerRepository.Delete(Id);
        }
    }
}