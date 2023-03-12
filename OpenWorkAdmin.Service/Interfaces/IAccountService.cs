using System.Threading.Tasks;

namespace OpenWorkAdmin.Service.Interfaces;

public interface IAccountService
{
	public Task<bool> BanAsync(string email);
	public Task<bool> MakeAdminAsync(long id);
}
