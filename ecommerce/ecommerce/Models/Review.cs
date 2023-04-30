using System.ComponentModel.DataAnnotations.Schema;

namespace ecommerce.Models;

public class Review
{
    public int Id { get; set; }

    public string Comment { get; set; } = string.Empty;

    public DateTime CreatedOn { get; set; }

    public int? Rating { get; set; }

    [ForeignKey(nameof(User))]
    public string UserId { get; set; }

    public int ProductId { get; set; }

    public ApplicationUser? User { get; set; }

    public Product? Product { get; set; }
}
