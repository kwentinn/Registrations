using Kledex.Domain;

namespace Registrations.Domain.Registrations.Commands
{
	public class TerminateRegistration : DomainCommand<Registration>
	{
		public string TerminationReason { get; set; }
	}
}
