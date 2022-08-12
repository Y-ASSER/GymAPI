using GymAPI.Models;

namespace GymAPI.Data
{
    public interface ITrainerRepository
    {
        List<Trainer> GetAllTrainer();
        Trainer GetTrainerById(int Id);
        Trainer AddTrainer(string Name, int Time_experience);
        Trainer PostTrainer(int Id, string Name, int Time_experience);
        Trainer UpdateTrainer(int Id, string Name,int Time_experience);
        void Delete(int Id);
    }
}