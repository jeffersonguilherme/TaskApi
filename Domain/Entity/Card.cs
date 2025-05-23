using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Enum;

namespace Domain.Entity;

public class Card
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    [StringLength(60, MinimumLength = 3)]
    public string? Titulo { get; set; }
    [StringLength(120)]
    public string? Description { get; set; }
    public DateTime? CreateAt { get; set; } = DateTime.Now;
    public DateTime? Daedline { get; set; }
    public ListCard? Lis { get; set; }
    public StatusItemEnum Status { get; set; }
}
