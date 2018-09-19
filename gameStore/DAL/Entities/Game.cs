using System;
using System.Collections.Generic;
using System.Text;

namespace Store.DAL.Entities
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int? PublisherId { get; set; }
        public Publisher Publisher { get; set; }

        public List<Comment> Comments { get; set; }
        public List<GenreGame> GenreGames { get; set; }
        public List<GamePlatformType> GamePlatformTypes { get; set; }
        public Game()
        {
            Comments = new List<Comment>();
            GenreGames = new List<GenreGame>();
            GamePlatformTypes = new List<GamePlatformType>();
        }
    }
}
