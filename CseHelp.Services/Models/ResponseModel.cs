using System.Net;

namespace CseHelp.Services.Models
{
    public class ResponseModel
    {
        public Guid ?Id { get; set; }
        public string ?Message { get; set; }
        public bool? IsSuccess { get; set; }
    }
}
