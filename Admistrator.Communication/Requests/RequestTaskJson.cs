using Admistrator.Communication.Enums;

namespace Admistrator.Communication.Requests
{
    public class RequestTaskJson
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public Priority Priority { get; set; }
        public DateTime Limit { get; set; }
        public Status Status { get; set; }

    }
}
