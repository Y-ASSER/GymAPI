using System.ComponentModel.DataAnnotations;


namespace GymAPI.Models
{
    public class Trainer
    {

        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int Time_experience { get; set; }
        public Trainer()
        {

        }
        public Trainer(string name, int time_experience)
        {
            Name = name;
            Time_experience = time_experience;
        }
        public void Update( int time_experience)
        {
           Time_experience = time_experience;
        }
    }
}
