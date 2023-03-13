using System;

using OpenWorkAdmin.Domain.Common;
using OpenWorkAdmin.Domain.ViewModels.Users;
using OpenWorkAdmin.Domain.ViewModels.Workers;

namespace OpenWorkAdmin.Domain.ViewModels.Comments;

public class CommentViewModel : BaseEntity
{
	public string Content { get; set; } = string.Empty;

	public UserBaseViewModel User { get; set; }

	public WorkerBaseViewModel Worker { get; set; }

	public DateTime Created { get; set; }

	public bool Satisfied { get; set; }

}
