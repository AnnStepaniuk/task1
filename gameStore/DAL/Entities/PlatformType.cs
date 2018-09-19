using System;
using System.Collections.Generic;
using System.Text;

namespace Store.DAL.Entities
{
    public class PlatformType
    {
        public int Id { get; set; }
        public string Type { get; set; }

        public List<GamePlatformType> GamePlatformTypes { get; set; }
        public PlatformType()
        {
            GamePlatformTypes = new List<GamePlatformType>();
        }

    }
}
