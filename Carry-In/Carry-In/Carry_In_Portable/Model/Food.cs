using Microsoft.WindowsAzure.MobileServices;
using Newtonsoft.Json;

namespace Carry_In.Model
{
    public class Food
    {
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "price")]
        public decimal Price { get; set; }

        [JsonProperty(PropertyName = "ingredients")]
        public string Ingredients { get; set; }

        [JsonProperty(PropertyName = "icon_uri")]
        public string IconUri { get; set; }

        public string IconCacheUri { get; set; }

        [Version]
        public string Version { get; set; }
    }
}
