using Domain.Enum;
namespace Domain.Entity;


public class Card
{
    public Guid Id { get; set; }
    public string? Titlu { get; set; }
    public string? Description { get; set; }
    public DateTime? CreateAt { get; set; } = DateTime.Now;
    public DateTime? Daedline { get; set; }
    public ListCard? Lis { get; set; }
    public StatusItemEnum Status { get; set; }
}
