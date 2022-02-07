using Newtonsoft.Json;

namespace Module5HW1.Models.Response
{
    public class SingleUserResponse
    {
        [JsonProperty("data")]
        public UserDto User { get; set; } = default!;
        [JsonProperty("support")]
        public SupportDto Support { get; set; } = default!;
    }
}
