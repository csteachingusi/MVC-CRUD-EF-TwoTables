using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_CRUD_EF_TwoTables.Models
{
    public class Tenant
    {
        [Key]
        public int TenantID { get; set; }
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }
        [Required]
        [Phone(ErrorMessage = "Please enter a valid phone number")]
        public string PhoneNumber { get; set; }
        [Required]
        [ForeignKey("Property")]
        public int PropertyID { get; set; }

        // Navigation property for related property
        public virtual Property? Property { get; set; }
    }
}
