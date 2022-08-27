using GymAPI.Models;

namespace GymAPI.Data
{
    public interface ITrainerRepository
    {
        Task<List<Trainer>> GetAllTrainers();
        Task<Trainer> GetTrainerById(int Id);
        Task<Trainer> AddTrainer(Trainer trainer);
        Task<Trainer> UpdateTrainer(Trainer trainer);
        Task Delete(int Id);
    }
}