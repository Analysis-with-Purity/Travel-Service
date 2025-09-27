using System.ComponentModel.DataAnnotations;

namespace Travel_Service.Models.Entity
{
    public class User
    {
        [Key]
        public Guid CustomerId { get; set; }
        public string Name { get; set; }
        public string Email {get; set; }
        public string Password {get; set; }
        public string Country {get; set; }
    }
}
