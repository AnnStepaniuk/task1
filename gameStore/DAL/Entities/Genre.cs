using System;
using System.Collections.Generic;
using System.Text;

namespace Store.DAL.Entities
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int? ParentId { get; set; }
        public Genre Parent { get; set; }

        public List<GenreGame> GenreGames { get; set; }
        public Genre()
        {
            GenreGames = new List<GenreGame>();
        }
    }
}
