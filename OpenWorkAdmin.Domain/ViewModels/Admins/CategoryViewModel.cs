using OpenWork.Domain.Entities;

using OpenWorkAdmin.Domain.Common;

namespace OpenWork.Services.ViewModels.Admins;

public class CategoryViewModel : BaseEntity
{
	public string Name { get; set; } = string.Empty;

	public List<Skill> Skills { get; set; } = new List<Skill>();
}
