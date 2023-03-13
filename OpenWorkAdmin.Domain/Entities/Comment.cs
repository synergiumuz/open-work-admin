namespace OpenWorkAdmin.Domain.Entities;

public class Comment : Auditable
{
	public long UserId { get; set; }

	public virtual User User { get; set; } = default!;

	public long WorkerId { get; set; }

	public virtual Worker Worker { get; set; } = default!;

	public string Content { get; set; } = string.Empty;

	public bool Satisfied { get; set; }
}
