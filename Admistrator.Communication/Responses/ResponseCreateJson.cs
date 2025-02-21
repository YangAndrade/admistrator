using Admistrator.Communication.Enums;

namespace Admistrator.Communication.Responses
{
    public class ResponseCreateJson
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public Status Status { get; set; }
    }
}
