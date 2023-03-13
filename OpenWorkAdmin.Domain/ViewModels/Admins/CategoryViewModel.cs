using OpenWorkAdmin.Domain.Common;
using OpenWorkAdmin.Domain.Entities;

namespace OpenWorkAdmin.Domain.ViewModels.Admins;

public class CategoryViewModel : BaseEntity
{
	public string Name { get; set; } = string.Empty;

	public List<Skill> Skills { get; set; } = new List<Skill>();
}
