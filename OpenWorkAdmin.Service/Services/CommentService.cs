using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using OpenWork.Domain.Entities;

using OpenWorkAdmin.Domain.ViewModels.Comments;
using OpenWorkAdmin.Service.Common;
using OpenWorkAdmin.Service.Interfaces;
using OpenWorkAdmin.Service.Utils;

namespace OpenWorkAdmin.Service.Services;

public class CommentService : ICommentService
{
	private readonly ApiHelper _api;
	public CommentService()
	{
		_api = new ApiHelper();
	}
	public async Task<bool> DeleteAsync(long id)
	{
		string query = "/comments/" + id.ToString();
		var response = await _api.DeleteAsync(query);
		if((int)response.StatusCode is > 199 and < 300)
			return true;
		else
			throw new StatusCodeException(response.StatusCode, response.Content);
	}

	public async Task<IEnumerable<CommentViewModel>> GetByUserAsync(long userId, int page)
	{
		string query = $"/comments/user/{userId}?page={page}";
		var response = await _api.GetAsync(query);
		if((int)response.StatusCode is > 199 and < 300)
			return Newtonsoft.Json.JsonConvert.DeserializeObject<IEnumerable<CommentViewModel>>(response.Content);
		else
			throw new StatusCodeException(response.StatusCode, response.Content);
	}

	public async Task<IEnumerable<CommentViewModel>> GetByWorkerAsync(long workerId, int page)
	{
		string query = $"/comments/worker/{workerId}?page={page}";
		var response = await _api.GetAsync(query);
		if((int)response.StatusCode is > 199 and < 300)
			return Newtonsoft.Json.JsonConvert.DeserializeObject<IEnumerable<CommentViewModel>>(response.Content);
		else
			throw new StatusCodeException(response.StatusCode, response.Content);
	}
}
