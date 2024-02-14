using System.Text.Json.Serialization;

namespace FacilitiesTicketingAPI.Models.ViewModels
{
    public class BaseModel
    {
        public Guid Id { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
