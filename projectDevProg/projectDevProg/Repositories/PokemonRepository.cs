using Newtonsoft.Json;
using projectDevProg.Models;
using System;
using System.Collections.Generic;
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
                String url = AddKey("https://pokemon-go1.p.rapidapi.com/pokemon_types.json");
                String json = await client.GetStringAsync(url);

                // json --> List
                if (json != null)
                {
                    List<Pokemon> pokemons = JsonConvert.DeserializeObject<List<Pokemon>>(json);
                    return pokemons;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
