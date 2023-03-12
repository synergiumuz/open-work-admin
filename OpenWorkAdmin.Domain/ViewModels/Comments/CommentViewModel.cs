using System;

using OpenWork.Services.ViewModels.Users;
using OpenWork.Services.ViewModels.Workers;

using OpenWorkAdmin.Domain.Common;

namespace OpenWork.Services.ViewModels.Comments;

public class CommentViewModel : BaseEntity
{
	public string Content { get; set; } = string.Empty;

	public UserBaseViewModel User { get; set; }

	public WorkerBaseViewModel Worker { get; set; }

	public DateTime Created { get; set; }

	public bool Satisfied { get; set; }

}
