using System.Collections.Generic;
using System.Threading.Tasks;

using OpenWorkAdmin.Domain.ViewModels.Users;

namespace OpenWorkAdmin.Service.Interfaces;

public interface IUserService
{
	public Task<IEnumerable<UserBaseViewModel>> GetAllAsync(int page);
	public Task<UserViewModel> GetAsync(long id);
	public Task<bool> LoginAsync(string email, string password);
}
