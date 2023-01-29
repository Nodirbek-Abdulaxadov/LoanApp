using System.ComponentModel.DataAnnotations;

namespace Entities;
public class User : BaseEntity
{
    [Required]
    [StringLength(50)]
    public string FirstName { get; set; } = string.Empty;
    [StringLength(50)]
    public string LastName { get; set; } = string.Empty;
    [StringLength(20)]
    public string PhoneNumber { get; set; } = string.Empty;

    public UserRole Role { get; set; }
}
