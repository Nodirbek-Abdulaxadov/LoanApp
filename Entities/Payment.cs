using System.ComponentModel.DataAnnotations;

namespace Entities;
public class Payment : BaseEntity
{
    [Required]
    [StringLength(30)]
    public string PaidDate { get; set; } = string.Empty;
    [Required]
    public decimal Ammount { get; set; }

    [Required]
    public int LoanId { get; set; }
    public Loan? Loan { get; set; }
}