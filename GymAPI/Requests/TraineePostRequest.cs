using GymAPI.Models;

namespace GymAPI.Requests
{
    public record TraineePostRequest(string Name, int Age, int Height, int Weight,Trainer trainer );
}
