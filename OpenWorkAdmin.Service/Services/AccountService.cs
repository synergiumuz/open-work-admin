using System;
using System.Threading.Tasks;

using OpenWorkAdmin.Service.Common;
using OpenWorkAdmin.Service.Interfaces;
using OpenWorkAdmin.Service.Utils;

namespace OpenWorkAdmin.Service.Services;

public class AccountService : IAccountService
{
	private readonly ApiHelper _api;
	public AccountService()
	{
		_api = new ApiHelper();
	}
	public async Task<bool> BanAsync(string email)
	{
		string query = "/admin/" + email;
		var response = await _api.DeleteAsync(query);
		if((int)response.StatusCode is > 199 and < 300)
			return true;
		else
			throw new StatusCodeException(response.StatusCode, response.Content);
	}
	public async Task<bool> MakeAdminAsync(long id)
	{
		string query = "/admin/" + id.ToString();
		var response = await _api.PostAsync(query);
		if((int)response.StatusCode is > 199 and < 300)
			return true;
		else
			throw new StatusCodeException(response.StatusCode, response.Content);
	}
}
