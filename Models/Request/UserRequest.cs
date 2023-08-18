﻿using Newtonsoft.Json;

namespace Module5HW1.Models.Request
{
    public class UserRequest
    {
        [JsonProperty("name")]
        public string Name { get; set; } = default!;
        [JsonProperty("job")]
        public string Job { get; set; } = default!;
    }
}
