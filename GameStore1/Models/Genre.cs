using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore1.Models
{
    public class Genre
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Game> GenreGame { get; set; }
    }
}
