﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace projectDevProg.Models
{
    public class Pokemon
    { 
        [JsonProperty(PropertyName = "pokemon_id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName="pokemon_name")]
        public String Name { get; set; }

        [JsonProperty(PropertyName = "form")]
        public String Form { get; set; }

        [JsonProperty(PropertyName = "type")]
        public List<String> Type { get; set; }

        public String FirstType { get; set; }

        public String SecondType { get; set; }

        [JsonProperty(PropertyName = "base_stamina")]
        public int Stamina { get; set; }

        [JsonProperty(PropertyName = "base_defense")]
        public int Defense { get; set; }

        [JsonProperty(PropertyName = "base_attack")]
        public int Attack { get; set; }

        public String Image { get; set; }
    }
}
