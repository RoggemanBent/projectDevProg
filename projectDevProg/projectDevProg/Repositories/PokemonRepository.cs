using Newtonsoft.Json;
using projectDevProg.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace projectDevProg.Repositories
{
    class PokemonRepository
    {
        private const String _APIKEY = "382a226b57mshe6f9f5b64a18f49p134457jsn3c82ca71deb7";

        private static String AddKey(String url)
        {
            return $"{url}?rapidapi-key={_APIKEY}";
        }

        private static async Task<HttpClient> GetClient()
        {
            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
            return httpClient;
        }

        public async static Task<List<Pokemon>> GetPokemons()
        {
            // HttpClient
            using (HttpClient client = await GetClient())
            {
                String url = AddKey("https://pokemon-go1.p.rapidapi.com/pokemon_stats.json");
                String json = await client.GetStringAsync(url);

                // json --> List
                if (json != null)
                {
                    List<Pokemon> pokemons = JsonConvert.DeserializeObject<List<Pokemon>>(json);
                    List<Pokemon> pokemonsGood = new List<Pokemon>();
                    foreach (Pokemon p in pokemons)
                    {
                        if (p.Form == "Normal" || p.Form == "Galarian")
                        {
                            p.Image = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/" + p.Id + ".png";
                            pokemonsGood.Add(p);
                        }
                    }
                    return pokemonsGood;
                }
                else
                {
                    return null;
                }
            }
        }

        public async static Task<List<Pokemon>> GetPokemonTypes()
        {
            // HttpClient
            using (HttpClient client = await GetClient())
            {
                String url = AddKey("https://pokemon-go1.p.rapidapi.com/pokemon_types.json");
                String json = await client.GetStringAsync(url);

                // json --> List
                if (json != null)
                {
                    List<Pokemon> pokemons = JsonConvert.DeserializeObject<List<Pokemon>>(json);
                    List<Pokemon> pokemonsGood = new List<Pokemon>();
                    foreach (Pokemon p in pokemons)
                    {
                        if (p.Form == "Normal" || p.Form == "Galarian")
                        {
                            p.FirstType = p.Type[0];
                            if (p.Type.Count > 1)
                            {
                                p.SecondType = p.Type[1];
                            }
                            pokemonsGood.Add(p);
                        }
                    }
                    return pokemonsGood;
                }
                else
                {
                    return null;
                }
            }
        }

        public async static Task<List<PokemonAPI>> GetPokemonsAPI()
        {
            // HttpClient
            using (HttpClient client = await GetClient())
            {
                String url = "https://devprogpokemon.azurewebsites.net/api/pokemon";
                
                String json = await client.GetStringAsync(url);


                json = json.Replace(@"\", "");
                
                json = json.Substring(1);
                json = json.Remove(json.Length - 1);
                Debug.Write(json);
                
                // json --> List
                if (json != null)
                {
                    List<PokemonAPI> pokemons = JsonConvert.DeserializeObject<List<PokemonAPI>>(json);
                    Debug.WriteLine(pokemons);
                    List<PokemonAPI> pokemonsGood = new List<PokemonAPI>();
                    foreach (PokemonAPI p in pokemons)
                    {
                        if (p.Form == "Normal" || p.Form == "Galarian")
                        {
                            pokemonsGood.Add(p);
                        }
                    }
                    return pokemonsGood;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
