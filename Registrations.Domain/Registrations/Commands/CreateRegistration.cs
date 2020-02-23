using Kledex.Domain;

namespace Registrations.Domain.Registrations.Commands
{
	/// <summary>
	/// Command for creating a new registration.
	/// </summary>
	public class CreateRegistration : DomainCommand<Registration>
	{
		/// <summary>
		/// Person who is being registered to.
		/// </summary>
		public Person Person { get; set; }

		/// <summary>
		/// What the person is registering to.
		/// </summary>
		public RegistrationTarget RegistrationTarget { get; set; }

		/// <summary>
		/// Registration Date/Period
		/// </summary>
		public RegistrationDate RegistrationDate { get; set; }

		/// <summary>
		/// Constructor
		/// </summary>
		public CreateRegistration()
		{
			ValidateCommand = true;
		}
	}
}
