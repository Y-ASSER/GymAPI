using GymAPI.Models;

namespace GymAPI.Data
{
    public class TrainerRepository : ITrainerRepository
    {

        public Trainer AddTrainer(string name, int Time_experience)
        {
            Trainer Trainer = new(name, Time_experience);
            Add(Trainer);
            return Trainer;
        }
        public void Delete(int id)
        {
            if (Trainer != null)
                Remove(Trainer);
        }

        public Trainer UpdateTrainer(int Id, string name, int Time_experience)
        {
            var updatedTrainer = Trainer.Update(name, Time_experience);
            return updatedTrainer;
        }
    }
}