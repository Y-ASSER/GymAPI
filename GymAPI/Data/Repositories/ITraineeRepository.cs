using GymAPI.Models;

namespace GymAPI.Data
{
    public interface ITraineeRepository
    {
        Task<List<Trainee>> GetAllTrainee();
        Task<Trainee> GetTraineeById(int Id, CancellationToken cancellationToken);
        Task<Trainee> AddTrainee(Trainee trainee);
        Task<Trainee> UpdateTrainee(Trainee trainee);
        Task Delete(int Id, CancellationToken cancellationToken);
    }
}