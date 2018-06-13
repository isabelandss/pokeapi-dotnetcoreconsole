using System;
using System.Threading.Tasks;
using static System.Console;

namespace HttpClient_dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            var repositorio = new PokemonRepository();
            Write("Escolha um pokemon pelo seu id: ");

            int id = Convert.ToInt32(ReadLine());
            var pokemon = repositorio.get(id);

            WriteLine(pokemon);
            ReadLine();
        }
    }
}