using System.ComponentModel.DataAnnotations;

namespace Entities;
public class Loan : BaseEntity
{
    [Required]
    [StringLength(30)]
    public string GivenDate { get; set; } = string.Empty;
    [StringLength(4)]
    public uint ReturnAfterDays { get; set; }
    [Required]
    public decimal Quantity { get; set; }

    [Required]
    public int ClientId { get; set; }
    [Required]
    public int SellerId { get; set; }

    public List<Payment> Payments { get; set; } = new List<Payment>();
}