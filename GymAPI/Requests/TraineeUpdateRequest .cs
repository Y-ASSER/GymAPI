using GymAPI.Models;
namespace GymAPI.Requests
{
    public record TraineeUpdateRequest(int Age, int Height, int Weight,Trainer Trainer);
}
