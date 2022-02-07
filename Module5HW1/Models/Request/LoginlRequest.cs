using Newtonsoft.Json;

namespace Module5HW1.Models.Request
{
    public class LoginlRequest
    {
        [JsonProperty("email")]
        public string Email { get; set; } = default!;
        [JsonProperty("password")]
        public string? Password { get; set; }
    }
}
