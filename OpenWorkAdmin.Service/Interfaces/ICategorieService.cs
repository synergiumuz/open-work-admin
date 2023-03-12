using System.Collections.Generic;
using System.Threading.Tasks;

using OpenWork.Services.Dtos.Admins;
using OpenWork.Services.ViewModels.Admins;

namespace OpenWorkAdmin.Service.Interfaces;

public interface ICategorieService
{
	public Task<IEnumerable<CategoryViewModel>> GetAllAsync();
	public Task<CategoryViewModel> GetAsync(long id);
	public Task<bool> DeleteAsync(long id);
	public Task<bool> UpdateAsync(CategoryCreateDto dto, long id);
	public Task<bool> CreateAsync(CategoryCreateDto dto);
}
