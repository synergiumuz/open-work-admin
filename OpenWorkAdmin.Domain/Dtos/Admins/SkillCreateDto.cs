using OpenWorkAdmin.Domain.Common;

namespace OpenWorkAdmin.Domain.Dtos.Admins;
public class SkillCreateDto : Dto
{
	public string Name { get; set; } = string.Empty;
	public string Description { get; set; } = string.Empty;
	public int CategoryId { get; set; }
}
