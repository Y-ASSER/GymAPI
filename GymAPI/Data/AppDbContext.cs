
using Microsoft.EntityFrameworkCore;
using GymAPI.Models;


namespace GymAPI.Data
{
    public class AppDbContext : DbContext 
    {
	  // the below DbSet type contains the Model class which is in this case gym, change it to the new model name and change it's object name (clients => Foods)
        // Keep the DbPath part as is	
        public DbSet<Trainee> Trainees { get; set; }
        public DbSet<Trainer> Trainers { get; set; }

        public string DbPath { get; private set; }


        public AppDbContext(DbContextOptions options) : base(options)
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = Path.Join(path, "Gym.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
       => options.UseSqlite($"Data Source={DbPath}");


    }
}
