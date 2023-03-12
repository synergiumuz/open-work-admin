using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenWork.Services.Dtos.Admins;

namespace OpenWorkAdmin.Service.Interfaces;

public interface ISkillService
{
	public Task<bool> CreateAsync(SkillCreateDto dto);
	public Task<bool> UpdateAsync(SkillCreateDto dto, long id);
	public Task<bool> DeleteAsync(long id);
}
