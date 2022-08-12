using GymAPI.Models;

namespace GymAPI.Data
{
    public class TraineeRepository : ITraineeRepository
    {
        public Trainee AddTrainee(string Name, int Age, int Height, int Weight, Trainer trainer)
        {
            Trainee trainee = new(Name, Age, Weight, Height, trainer);
            Add(trainee);
            return trainee;
        }
        public void Delete(int Id)
        {
            if (Id != null)
                Remove(Trainee);
        }

        public List<Trainee> GetAllTrainee()
        {
            throw new NotImplementedException();
        }

        public Trainee GetTraineeById(int Id)
        {
            throw new NotImplementedException();
        }

        public Trainee PostTrainee(int Id, string Name, int Age, int Height, int Weight, Trainer trainer)
        {
            throw new NotImplementedException();
        }

        public Trainee UpdateTrainee(int Id, string Name, int Age, int Height, int Weight, Trainer trainer)
        {
            var updatedTrainee = Trainee.Update(name, Age, Weight, Height, trainer);
            return updatedTrainee;
        }

    }
}