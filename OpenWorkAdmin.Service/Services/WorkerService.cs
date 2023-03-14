using OpenWork.Services.ViewModels.Admins;
using OpenWork.Services.ViewModels.Workers;
using OpenWorkAdmin.Service.Common;
using OpenWorkAdmin.Service.Interfaces;
using OpenWorkAdmin.Service.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWorkAdmin.Service.Services
{
	public class WorkerService : IWorkerService
	{
		private readonly ApiHelper _api;
		public  WorkerService()
		{
			_api = new ApiHelper();
		}
		public async Task<IEnumerable<WorkerBaseViewModel>> GetAllAsync(int page)
		{
			string query = $"/workers?page={page}";
			var response = await _api.GetAsync(query);
			if ((int)response.StatusCode is > 199 and < 300)
				return Newtonsoft.Json.JsonConvert.DeserializeObject<IEnumerable<WorkerViewModel>>(response.Content);
			else
				throw new StatusCodeException(response.StatusCode, response.Content);

		}

		public async Task<WorkerViewModel> GetAsync(int id)
		{
			string query = $"/workers/{id}";
			var response = await _api.GetAsync(query);
			if ((int)response.StatusCode is > 199 and < 300)
				return Newtonsoft.Json.JsonConvert.DeserializeObject<WorkerViewModel>(response.Content);
			else
				throw new StatusCodeException(response.StatusCode, response.Content);
		}
	}
}
