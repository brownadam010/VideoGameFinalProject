using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VideoGameFinalProject.Models
{
    public class Game
    {
        public int GameId { get; set; }
        [Required(ErrorMessage = "Please enter a Game Name")]
        public string GameName { get; set; }
        [Required(ErrorMessage = "Please enter a Game Release")]
        public string GameRelease { get; set; }
        [Required(ErrorMessage = "Please enter a Game Producer")]
        public string GameProducer { get; set; }

        public string Slug =>
            GameName?.Replace(' ', '-').ToLower() + '-' + GameRelease?.ToString();
    }
}
