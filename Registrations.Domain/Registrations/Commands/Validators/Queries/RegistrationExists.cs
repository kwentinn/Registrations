using Kledex.Queries;
using System;

namespace Registrations.Domain.Registrations.Commands.Validators.Queries
{
	public class RegistrationExists : IQuery<bool>
	{
		public Guid PersonId { get; }
		public Guid RegistrationTarget { get; }
		public RegistrationDate RegistrationDate { get; }

		public RegistrationExists(Guid personId, Guid registrationTarget, RegistrationDate registrationDate)
		{
			PersonId = personId;
			RegistrationTarget = registrationTarget;
			RegistrationDate = registrationDate;
		}
	}
}
