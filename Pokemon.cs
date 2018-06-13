using Newtonsoft.Json;

namespace HttpClient_dotnet
{
    public class Pokemon
    {
        public int id { get; set; }
        public string name { get; set; }
        public int weight { get; set; }
        public int height { get; set; }

        public override string ToString() {
            return $"{name} - {weight}x{height} ";
        }
    }
}