using System;

using OpenWorkAdmin.Domain.Common;

namespace OpenWorkAdmin.Domain.ViewModels.Workers;

public class WorkerBaseViewModel : BaseEntity
{
	public string Name { get; set; } = string.Empty;

	public string Surname { get; set; } = string.Empty;

	public DateTime LastSeen { get; set; }

	public double? Rating { get; set; }
}
