using System.Collections.Generic;
using System.Threading.Tasks;

using OpenWork.Services.ViewModels.Comments;

namespace OpenWorkAdmin.Service.Interfaces;

public interface ICommentService
{
	public Task<IEnumerable<CommentViewModel>> GetByUserAsync(long userId);
	public Task<IEnumerable<CommentViewModel>> GetByWorkerAsync(long workerId);
	public Task<bool> DeleteAsync(long id);
}
