using Kledex.Domain;

namespace Registrations.Domain.Registrations.Events
{
	public class RegistrationCreated : DomainEvent
	{
		public Person Person { get; set; }
		public RegistrationTarget RegistrationTarget { get; set; }
		public RegistrationDate RegistrationDate { get; set; }
	}
}
