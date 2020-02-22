using Kledex.Domain;

namespace Registrations.Domain.Registrations.Commands
{
	public class ChangeRegistrationDate : DomainCommand<Registration>
	{
		public RegistrationDate NewRegistrationDate { get; set; }
	}
}
