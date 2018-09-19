﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Store.DAL.Entities
{
    public class GenreGame
    {
        public int GenreId { get; set; }
        public Genre Genre { get; set; }

        public int GameId { get; set; }
        public Game Game { get; set; }
    }
}
