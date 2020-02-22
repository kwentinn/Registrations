using Kledex.Domain;

namespace Registrations.Domain.Registrations.Events
{
	public class RegistrationTargetChanged : DomainEvent
	{
		public RegistrationTarget NewRegistrationTarget { get; set; }
	}
}
