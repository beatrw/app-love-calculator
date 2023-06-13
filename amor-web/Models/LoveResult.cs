using Newtonsoft.Json;

namespace LoveCalculator.Models
{
    public class LoveResult
    {
        [JsonProperty("fname")]
        public string FirstName { get; set; }

        [JsonProperty("sname")]
        public string SecondName { get; set; }

        [JsonProperty("percentage")]
        public string Percentage { get; set; }

        [JsonProperty("result")]
        public string Result { get; set; }
    }
}
