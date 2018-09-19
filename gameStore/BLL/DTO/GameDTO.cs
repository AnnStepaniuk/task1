using System;
using System.Collections.Generic;
using System.Text;

namespace Store.BLL.DTO
{
    public class GameDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public PublisherDTO Publisher { get; set; }
        public List<CommentDTO> Comments { get; set; }
    }
}
