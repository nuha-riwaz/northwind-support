
using System.ComponentModel.DataAnnotations;

namespace SupportDesk.Application.Contracts.Tickets;

public sealed class EscalateTicketRequest
{
    [Required]
    [StringLength(500, MinimumLength = 5)]
    [RegularExpression(@"(?s).*\S.*", ErrorMessage = "Reason cannot be blank.")]
    public string Reason { get; init; } = string.Empty;

    // Temporary for Task 2; Task 3 will derive this from the JWT.
    [Required]
    [StringLength(100, MinimumLength = 1)]
    public string EscalatedBy { get; init; } = string.Empty;
}
