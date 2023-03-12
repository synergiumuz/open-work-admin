using System.Collections.Generic;

using OpenWork.Domain.Entities;

namespace OpenWork.Services.ViewModels.Workers;

public class WorkerViewModel : WorkerBaseViewModel
{
	public string Email { get; set; } = string.Empty;

	public string Phone { get; set; } = string.Empty;

	public IList<Skill> Skills { get; set; } = new List<Skill>();

	public IList<Comment> Comments { get; set; } = new List<Comment>();

}
