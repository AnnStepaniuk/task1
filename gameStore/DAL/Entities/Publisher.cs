using System;
using System.Collections.Generic;
using System.Text;

namespace Store.DAL.Entities
{
    public class Publisher
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Game> Games { get; set; }
    }
}
