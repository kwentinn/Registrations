using Kledex.Domain;

namespace Registrations.Domain.Registrations.Commands
{
	public class CreateRegistration : DomainCommand<Registration>
	{
		public Person Person { get; set; }
		public RegistrationTarget RegistrationTarget { get; set; }
		public RegistrationDate RegistrationDate { get; set; }

		public CreateRegistration()
		{
			ValidateCommand = true;
		}
	}
}
