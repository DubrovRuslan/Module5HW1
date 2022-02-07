namespace Module5HW1.Configs
{
    public class UserServiceReguest
    {
        public string ListUsers { get; set; } = default!;
        public string SingleUser { get; set; } = default!;
        public string SingleUserNotFound { get; set; } = default!;
        public string Create { get; set; } = default!;
        public string Update { get; set; } = default!;
        public string DelayedResponse { get; set; } = default!;
    }
}
