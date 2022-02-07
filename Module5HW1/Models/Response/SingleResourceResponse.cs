using Newtonsoft.Json;

namespace Module5HW1.Models.Response
{
    public class SingleResourceResponse
    {
        [JsonProperty("data")]
        public ResourceDto Resource { get; set; } = default!;
        [JsonProperty("support")]
        public SupportDto Support { get; set; } = default!;
    }
}
