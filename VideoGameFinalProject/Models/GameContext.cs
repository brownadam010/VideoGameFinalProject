using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VideoGameFinalProject.Models
{
    public class GameContext : DbContext
    {
        public GameContext(DbContextOptions<GameContext> options)
            : base(options) { }

        public DbSet<Game> Games { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Game>().HasData(
                new Game
                {
                    GameId = 3,
                    GameName = "Minecraft",
                    GameRelease = "2011",
                    GameProducer = "Mojang Studios"
                },
                new Game
                {
                    GameId = 2,
                    GameName = "Tom Clancy's Rainbow Six Siege",
                    GameRelease = "2015",
                    GameProducer = "Ubisoft Montreal"
                },
                new Game
                {
                    GameId = 1,
                    GameName = "Super Mario Bros.",
                    GameRelease = "1985",
                    GameProducer = "Nintendo"
                }
            );
        }
    }
}
