using System.ComponentModel.DataAnnotations;


namespace GymAPI.Models
{
    public class Trainee
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public Trainer Trainer { get; set; }
        public Trainee()
        {

        }
        public Trainee(string name, int age, int height, int weight,Trainer trainer)
        {
            Name = name;
            Age = age;
            Height = height;
            Weight = weight;
            Trainer = trainer;
        }
        public void Update(int age, int height, int weight,Trainer trainer)
        {
            Age = age;
            Height = height;
            Weight = weight;
            Trainer= trainer;
        }
    }
}
