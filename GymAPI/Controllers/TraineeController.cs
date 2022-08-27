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
            _traineeRepository=traineeRepository;
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
        public Trainee Post(string name, int Age,int Weight,int Height,Trainer trainer)
        {
            return _traineeRepository.AddTrainee(name, Age,Weight,Height,trainer);
        }

        // PUT api/<TraineeController>/5
        [HttpPut("{id}")]
        public Trainee Put(int id, string name, int Age,int Weight,int Height,Trainer trainer)
        {
            return _traineeRepository.UpdateTrainee(id, name, Age,Weight,Height,trainer);
        }

        // DELETE api/<TraineeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _traineeRepository.Delete(id);
        }
    }
}