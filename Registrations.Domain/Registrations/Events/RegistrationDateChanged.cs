using Kledex.Domain;

namespace Registrations.Domain.Registrations.Events
{
	public class RegistrationDateChanged : DomainEvent
	{
		public RegistrationDate NewRegistrationDate { get; set; }
	}
}
