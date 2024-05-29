using Newtonsoft.Json;
using Pokemon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.Servicios
{
    public class PokemonApis
    {
        public HttpClient _httpClient;


        public PokemonApis() { 
            _httpClient = new HttpClient();
        }
       public async Task<List<PokemonInfo>> DevuelveListaPokemon()
        {
            string url = "https://pokeapi.co/api/v2/pokemon/?limit=40&offset=0";

            string json =  await _httpClient.GetStringAsync(url);

            ResourceList resourcelist_pokemon= JsonConvert.DeserializeObject<ResourceList>(json);

            return resourcelist_pokemon.results;
        }


        public async Task<CaracteristicasPokemon> DevuelveCaracteristicas( string url)
        {
            string json = await _httpClient.GetStringAsync(url);

            CaracteristicasPokemon caracteristicas_ = JsonConvert.DeserializeObject<CaracteristicasPokemon>(json);

            return caracteristicas_;
        }
    }
}
