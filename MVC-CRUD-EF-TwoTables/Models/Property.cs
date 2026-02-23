using System.ComponentModel.DataAnnotations;

namespace MVC_CRUD_EF_TwoTables.Models
{
    public class Property
    {
        [Key]
        public int PropertyId { get; set; }
        [Required(ErrorMessage="Please enter the property name")]
        [StringLength(100)]
        public string PropertyName { get; set; }
        [Required]
        [StringLength(255)]
        public string Address { get; set; }
        [Required]
        [StringLength(20)]
        public string UnitNumber { get; set; }
        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Please enter a valid rent amount")]
        public decimal MonthlyRent { get; set; }

        // Navigation property for related tenants
        public virtual ICollection<Tenant> Tenants { get; set; }= new List<Tenant>();
    }
}
