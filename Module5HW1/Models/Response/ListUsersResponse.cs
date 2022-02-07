using System.Collections.Generic;
using Newtonsoft.Json;

namespace Module5HW1.Models.Response
{
    public class ListUsersResponse
    {
        [JsonProperty("page")]
        public int Page { get; set; }
        [JsonProperty("per_page")]
        public int PerPage { get; set; }
        [JsonProperty("total")]
        public int Total { get; set; }
        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }
        [JsonProperty("data")]
        public List<UserDto> Users { get; set; } = new List<UserDto>();
        [JsonProperty("support")]
        public SupportDto Support { get; set; } = default!;
    }
}
