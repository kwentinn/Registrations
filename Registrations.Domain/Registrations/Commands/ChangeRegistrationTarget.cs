using Kledex.Domain;

namespace Registrations.Domain.Registrations.Commands
{
	public class ChangeRegistrationTarget : DomainCommand<Registration>
	{
		public RegistrationTarget NewRegistrationTarget { get; set; }
	}
}
