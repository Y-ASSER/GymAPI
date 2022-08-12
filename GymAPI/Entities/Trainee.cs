using System.ComponentModel.DataAnnotations;


namespace GymAPI.Models
{
    public class Trainee
    {

        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public Trainee()
        {

        }
        public Trainee(string name, int age, int height, int weight)
        {
            Name = name;
            Age = age;
            Height = height;
            Weight = weight;
        }
        public void Update(int age, int height, int weight)
        {
            Age = age;
            Height = height;
            Weight = weight;
        }
    }
}
