using GymAPI.Data;
using GymAPI.Models;
using GymAPI.Requests;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GymAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]

    public class TraineeController : ControllerBase
    {
        private readonly ITraineeRepository _traineeRepository;

        public TraineeController(ITraineeRepository traineeRepository)
        {
            _traineeRepository = traineeRepository;
        }


       [HttpGet]
        public ActionResult<IEnumerable<Trainee>> Get()
        {
            var Trainee = _traineeRepository.GetAllTrainee();
            return Ok(Trainee);
        }

        // GET api/<TraineeController>/5
        [HttpGet("{id}")]
        public Trainee Get(int id)
        {
            return _traineeRepository.GetTraineeById(id);
        }

        // POST api/<TraineeController>
        [HttpPost]
        public Trainee Post(Trainee trainee)
        {
            return _traineeRepository.AddTrainee(trainee);
        }

        // PUT api/<TraineeController>/5
        [HttpPut("{id}")]
        public Trainee Put(Trainee trainee)
        {
            return _traineeRepository.UpdateTrainee(trainee);
        }

        // DELETE api/<TraineeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _traineeRepository.Delete(id);
        }
    }
}