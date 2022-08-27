using GymAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace GymAPI.Data
{
    public class TrainerRepository : ITrainerRepository
    {
        private readonly AppDbContext _context;

        private readonly DbSet<Trainer> _trainer;

        public TrainerRepository(AppDbContext context)
        {
            _context = context;
            _trainer = _context.Set<Trainer>();
        }

        public async Task<Trainer> AddTrainer(Trainer trainer)
        {
            var createdEntity = await _trainer.AddAsync(trainer);
            await _context.SaveChangesAsync();
            return createdEntity.Entity;
        }


        public async Task Delete(int Id)
        {
            var trainerToRemove = await _trainer.FirstOrDefaultAsync<Trainer>(p => p.Id == Id);
            if (trainerToRemove != null)
                _trainer.Remove(trainerToRemove);
        }

        public async Task<List<Trainer>> GetAllTrainers() => await _trainer.ToListAsync();

        public async Task<Trainer> GetTrainerById(int Id) => await _trainer.FirstOrDefaultAsync(a => a.Id == Id);

        public async Task<Trainer> UpdateTrainer(Trainer trainer)
        {
            var updatedEntity = _trainer.Update(trainer);
            await _context.SaveChangesAsync();
            return updatedEntity.Entity;
        }
    }
}