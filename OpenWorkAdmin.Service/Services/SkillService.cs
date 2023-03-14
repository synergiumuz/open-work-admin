using OpenWork.Services.Dtos.Admins;
using OpenWorkAdmin.Service.Common;
using OpenWorkAdmin.Service.Interfaces;
using OpenWorkAdmin.Service.Utils;
using System;
using System.Threading.Tasks;

namespace OpenWorkAdmin.Service.Services
{
	public class SkillService : ISkillService
	{
		private readonly ApiHelper _api;
		public SkillService()
		{
			_api = new ApiHelper();
		}
		public async Task<bool> CreateAsync(SkillCreateDto dto)
		{
			string query = "/skills";
			var response = await _api.PostAsync(query, dto);
			if ((int)response.StatusCode is > 199 and < 300)
				return true;
			else
				throw new StatusCodeException(response.StatusCode, response.Content);
			throw new NotImplementedException();
		}

		public async Task<bool> DeleteAsync(long id)
		{
			string query = "/skills" + id.ToString();
			var response = await _api.DeleteAsync(query);
			if ((int)response.StatusCode is > 199 and < 300)
				return true;
			else
				throw new StatusCodeException(response.StatusCode, response.Content);
		}

		public async Task<bool> UpdateAsync(SkillCreateDto dto, long id)
		{
			string query = $"/skills/{id}";
			var response = await _api.PutAsync(query, dto);
			if ((int)response.StatusCode is > 199 and < 300)
				return true;
			else
				throw new StatusCodeException(response.StatusCode, response.Content);
			throw new NotImplementedException();
		}
	}
}
