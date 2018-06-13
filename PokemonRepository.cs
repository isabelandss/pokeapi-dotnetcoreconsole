using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HttpClient_dotnet
{
    public class PokemonRepository
    {
        HttpClient cliente = new HttpClient();

        public PokemonRepository()
        {
            cliente.DefaultRequestHeaders.Accept.Clear();
            cliente.BaseAddress = new Uri("http://pokeapi.co/api/v2/");
            cliente.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public dynamic get(int id) {
            var result = new object();

            HttpResponseMessage response = cliente.GetAsync($"pokemon/{id}").Result;
            response.EnsureSuccessStatusCode();

            string conteudo = response.Content.ReadAsStringAsync().Result;
            dynamic resultado = JsonConvert.DeserializeObject(conteudo);

            result = resultado;

            return result;
        }    
    }
}