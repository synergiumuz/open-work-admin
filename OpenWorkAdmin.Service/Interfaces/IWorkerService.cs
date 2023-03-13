using System.Collections.Generic;
using System.Threading.Tasks;

using OpenWorkAdmin.Domain.ViewModels.Workers;

namespace OpenWorkAdmin.Service.Interfaces;

public interface IWorkerService
{
	public Task<IEnumerable<WorkerBaseViewModel>> GetAllAsync(int page);
	public Task<WorkerViewModel> GetAsync(int id);
}
