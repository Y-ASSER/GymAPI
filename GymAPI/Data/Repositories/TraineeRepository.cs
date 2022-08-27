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


        public async Task Delete(int Id, CancellationToken cancellationToken)
        {
            _trainee.Remove(await _trainee.FindAsync(new object?[] { Id }, cancellationToken: cancellationToken));
        }


        public async Task<List<Trainee>> GetAllTrainee() => await _trainee.ToListAsync();

        public async Task<Trainee> GetTraineeById(int Id, CancellationToken cancellationToken) => await _trainee.FindAsync(new object?[] { Id }, cancellationToken: cancellationToken);

        public async Task<Trainee> UpdateTrainee(Trainee trainee)
        {
            var updatedEntity = _trainee.Update(trainee);
            await _context.SaveChangesAsync();
            return updatedEntity.Entity;
        }


    }
}