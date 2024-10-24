using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using pokiapiPractica.Models;

namespace pokiapiPractica.Services
{
    public class PokemonService
    {
        private readonly HttpClient _httpClient;

        public PokemonService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<Pokemon> GetPokemonAsync(string name)
        {
            var response = await _httpClient.GetStringAsync($"https://pokeapi.co/api/v2/pokemon/{name}");
            var pokemonData = JsonConvert.DeserializeObject<dynamic>(response);

            var abilities = ((IEnumerable<dynamic>)pokemonData.abilities).Select(a => new Ability
            {
                AbilityData = new AbilityDetails
                {
                    Name = a.ability.name,
                    Url = a.ability.url
                }
            }).ToList();

            var pokemon = new Pokemon
            {
                Name = pokemonData.name,
                Id = pokemonData.id,
                Abilities = abilities
            };

            return pokemon;
        }
    }

}