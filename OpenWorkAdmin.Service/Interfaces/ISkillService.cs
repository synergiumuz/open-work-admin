using System.Threading.Tasks;

using OpenWorkAdmin.Domain.Dtos.Admins;

namespace OpenWorkAdmin.Service.Interfaces;

public interface ISkillService
{
	public Task<bool> CreateAsync(SkillCreateDto dto);
	public Task<bool> UpdateAsync(SkillCreateDto dto, long id);
	public Task<bool> DeleteAsync(long id);
}
