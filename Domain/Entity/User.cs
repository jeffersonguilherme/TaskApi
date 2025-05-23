using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entity;

[Table("Usuario")]
public class User
{
    [Key]
    [Required]
    public Guid Id { get; set; }

    [Required]
    [StringLength(50, MinimumLength = 3)]
    [Column(TypeName = "NVARCHAR(50)")]
    public string? Name { get; set; }

    [Required]
    [StringLength(50, MinimumLength = 3)]
    [Column(TypeName = "NVARCHAR(50)")]
    public string? Surname { get; set; }

    [Required]
    [EmailAddress]
    public string? Email { get; set; }

    [Required]
    public string? PasswordHash { get; set; }

    [Required]
    [Column("NomeUsuario")]
    public string? Username { get; set; }
    public ICollection<Workspace>? Workspace { get; set; }
    public string? RefreshToken { get; set; }
    public string? RefreshTokenExpiration { get; set; }
}