using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace projectDevProg.Models
{
    public class PokemonType
    {
        [JsonProperty(PropertyName = "type[0]")]
        public String FirstType { get; set; }

        [JsonProperty(PropertyName = "type[1]")]
        public String SecondType { get; set; }
    }
}
