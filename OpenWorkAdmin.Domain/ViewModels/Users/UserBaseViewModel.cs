using OpenWorkAdmin.Domain.Common;

namespace OpenWork.Services.ViewModels.Users;

public class UserBaseViewModel : BaseEntity
{
	public string Name { get; set; } = string.Empty;

	public string Surname { get; set; } = string.Empty;

	public bool Admin { get; set; }

}
