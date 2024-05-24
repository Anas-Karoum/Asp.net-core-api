using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Entities;

public class ContactEntity
{
    public string Id {  get; set; } = Guid.NewGuid().ToString();

    [StringLength(100)]
    public string FullName { get; set; } = null!;
    [StringLength(100)]
    public string Email { get; set; } = null!;
    [StringLength(100)]
    public string? Service {  get; set; }

    public string Message { get; set; } = null!;
}
