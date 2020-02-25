using Itenso.TimePeriod;
using Kledex.Queries;
using System;

namespace Registrations.Domain.Registrations.Commands.Validators.Queries
{
	public class UserExistsWithEmail : IQuery<bool>
	{
		public string EmailAddress { get; }
		
		public UserExistsWithEmail(string emailAddress)
		{
			EmailAddress = emailAddress;
		}
	}
}
