using System;
using System.Collections.Generic;
using System.Text;

namespace Store.BLL.DTO
{
    public class PublisherDTO
    {
        public string Name { get; set; }

        public List<GameDTO> Games { get; set; }
    }
}
