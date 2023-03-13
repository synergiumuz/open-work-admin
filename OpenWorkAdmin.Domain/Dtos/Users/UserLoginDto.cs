using OpenWorkAdmin.Domain.Common;

namespace OpenWorkAdmin.Domain.Dtos.Users;

public class UserLoginDto : Dto
{
	public string Email { get; set; } = string.Empty;
	public string Password { get; set; } = string.Empty;
}
