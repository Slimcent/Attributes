using ValidationComponent.CustomAttributes;

namespace AttributesExamples.Models
{
    public class Employee
    {
        [Required]
        public int Id { get; set; }
        
        [Required]
        public string FirstName { get; set; }
        
        [Required]
        public string LastName { get; set; }

        [Required]
        public string PhoneNumber { get; set; }
        
        [Required]
        public string EmailAddress { get; set; }
    }
}
