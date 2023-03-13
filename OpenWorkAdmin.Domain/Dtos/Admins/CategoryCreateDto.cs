using OpenWorkAdmin.Domain.Common;

namespace OpenWorkAdmin.Domain.Dtos.Admins;

public class CategoryCreateDto : Dto
{
	public string Name { get; set; } = string.Empty;
}
