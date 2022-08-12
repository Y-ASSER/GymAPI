namespace GymAPI.Requests
{
    public record TraineePostRequest(string Name, int Age, int Height, int Weight, int trainer_id);
}
