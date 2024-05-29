using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.Models
{
    public class ResourceList
    {
        public int count {  get; set; }

        public string next {  get; set; }

        public string previus { get; set; }

        public List<PokemonInfo> results { get; set; }
    }
}
