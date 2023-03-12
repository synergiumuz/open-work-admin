using OpenWorkAdmin.Domain.Common;

namespace OpenWork.Services.Dtos.Admins;

public class CategoryCreateDto : Dto
{
	public string Name { get; set; } = string.Empty;
}
