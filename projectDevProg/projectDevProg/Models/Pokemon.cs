using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace projectDevProg.Models
{
    public class Pokemon
    {
        [JsonProperty(PropertyName="pokemon_id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName="pokemon_name")]
        public String Name { get; set; }

        [JsonProperty(PropertyName = "form")]
        public String Form { get; set; }

    }
}
