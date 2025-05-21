namespace Domain.Entity;

public class Workspace{
    public Guid Id { get; set; }
    public string? Title { get; set; }
    public User? User { get; set; }
    public ICollection<ListCard>? ListsCards { get; set; }
    public StatusItemEnum Status { get; set; }
    public DateTime CreateAt { get; set; } = DateTime.Now;
}