using GymAPI.Models;

namespace GymAPI.Data
{
    public interface ITraineeRepository
    {
        List<Trainee> GetAllTrainee();
        Trainee AddTrainee(string Name, int Age, int Height, int Weight, Trainer trainer);
        Trainee PostTrainee(int Id, string Name, int Age, int Height, int Weight, Trainer trainer);
        Trainee UpdateTrainee(int Id, string Name, int Age, int Height, int Weight, Trainer trainer);
        void Delete(int Id);
    }
}