using OpenWork.Services.Dtos.Admins;
using OpenWork.Services.ViewModels.Admins;
using OpenWorkAdmin.Service.Common;
using OpenWorkAdmin.Service.Interfaces;
using OpenWorkAdmin.Service.Utils;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpenWorkAdmin.Service.Services
{
	public class CategoryService : ICategorieService
	{
		private readonly ApiHelper _api;
		public CategoryService()
		{
			_api = new ApiHelper();
		}
		public async Task<bool> CreateAsync(CategoryCreateDto dto)
		{
			string query = "/categories";
			var response = await _api.PostAsync(query, dto);
			if ((int)response.StatusCode is > 199 and < 300)
				return true;
			else
				throw new StatusCodeException(response.StatusCode, response.Content);
			throw new NotImplementedException();
		}

		public async Task<bool> DeleteAsync(long id)
		{
			string query = "/categories/" + id.ToString();
			var response = await _api.DeleteAsync(query);
			if ((int)response.StatusCode is > 199 and < 300)
				return true;
			else
				throw new StatusCodeException(response.StatusCode, response.Content);
		}

		public async Task<IEnumerable<CategoryViewModel>> GetAllAsync()
		{
			string query = "/categories";
			var response = await _api.GetAsync(query);
			if ((int)response.StatusCode is > 199 and < 300)
				return Newtonsoft.Json.JsonConvert.DeserializeObject<IEnumerable<CategoryViewModel>>(response.Content);
			else
				throw new StatusCodeException(response.StatusCode, response.Content);

		}

		public async Task<CategoryViewModel> GetAsync(long id)
		{
			string query = $"/categories/{id}";
			var response = await _api.GetAsync(query);
			if ((int)response.StatusCode is > 199 and < 300)
				return Newtonsoft.Json.JsonConvert.DeserializeObject<CategoryViewModel>(response.Content);
			else
				throw new StatusCodeException(response.StatusCode, response.Content);
		}

		public async Task<bool> UpdateAsync(CategoryCreateDto dto, long id)
		{
			string query = $"/categories/{id}";
			var response = await _api.PutAsync(query, dto);
			if ((int)response.StatusCode is > 199 and < 300)
				return true;
			else
				throw new StatusCodeException(response.StatusCode, response.Content);
			throw new NotImplementedException();
		}
	}
}
