using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace projectDevProg.Models
{
    public class PokemonAPI
    {
        [JsonProperty(PropertyName = "pokemon_id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "pokemon_name")]
        public String Name { get; set; }

        [JsonProperty(PropertyName = "type1")]
        public String FirstType { get; set; }

        [JsonProperty(PropertyName = "type2")]
        public String SecondType { get; set; }

        [JsonProperty(PropertyName = "base_stamina")]
        public int Stamina { get; set; }

        [JsonProperty(PropertyName = "base_defense")]
        public int Defense { get; set; }

        [JsonProperty(PropertyName = "base_attack")]
        public int Attack { get; set; }
    }
}
