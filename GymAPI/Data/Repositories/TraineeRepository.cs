using GymAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace GymAPI.Data
{
    public class TraineeRepository : ITraineeRepository
    {
        private readonly AppDbContext _context;

        private readonly DbSet<Trainee> _trainee;
        public TraineeRepository(AppDbContext context)
        {
            _context = context;
            _trainee = _context.Set<Trainee>();
        }

        public async Task<Trainee> AddTrainee(Trainee trainee)
        {
            var createdEntity = await _trainee.AddAsync(trainee);
            await _context.SaveChangesAsync();
            return createdEntity.Entity;
        }


        public async Task Delete(int Id)
        {
            var traineeToRemove =  await _trainee.FirstOrDefaultAsync<Trainee>(p => p.Id == Id);
            if (traineeToRemove != null)
                 _trainee.Remove(traineeToRemove);
        }


        public async Task<List<Trainee>> GetAllTrainee() => await _trainee.ToListAsync();

        public async Task<Trainee> GetTraineeById(int Id) => await _trainee.FirstOrDefaultAsync(a => a.Id == Id);
        public async Task<Trainee> UpdateTrainee(Trainee trainee)
        {
            var updatedEntity = _trainee.Update(trainee);
            await _context.SaveChangesAsync();
            return updatedEntity.Entity;
        }


    }
}