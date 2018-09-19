using System;
using System.Collections.Generic;
using System.Text;

namespace Store.BLL.DTO
{
    public class GenreDTO
    {
        public string Name { get; set; }

        public GenreDTO Parent { get; set; }
    }
}
