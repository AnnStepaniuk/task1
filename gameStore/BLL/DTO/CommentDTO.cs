using System;
using System.Collections.Generic;
using System.Text;

namespace Store.BLL.DTO
{
    public class CommentDTO
    {
        public string Name { get; set; }

        public string Body { get; set; }

        public GameDTO Game { get; set; }
        
        public CommentDTO Parent { get; set; }
    }
}
