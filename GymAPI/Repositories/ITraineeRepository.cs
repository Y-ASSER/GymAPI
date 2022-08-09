using GymAPI.Models;

namespace GymAPI.Data
{
    public interface ITraineeRepository
    {
        List<Trainee> GetAllTrainee();
        Trainee GetTraineeById(int Id);
        Trainee AddTrainee(string Name, int Age,int Height,int Weight,int trainer_id);
        Trainee UpdateTrainee(int Id, string Name, int Age,int Height,int Weight,int trainer_id );
        void Delete(int Id);
    }
}