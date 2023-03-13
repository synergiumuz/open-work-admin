using System.Collections.Generic;
using System.Threading.Tasks;

using OpenWorkAdmin.Domain.ViewModels.Comments;

namespace OpenWorkAdmin.Service.Interfaces;

public interface ICommentService
{
	public Task<IEnumerable<CommentViewModel>> GetByUserAsync(long userId, int page);
	public Task<IEnumerable<CommentViewModel>> GetByWorkerAsync(long workerId, int page);
	public Task<bool> DeleteAsync(long id);
}
