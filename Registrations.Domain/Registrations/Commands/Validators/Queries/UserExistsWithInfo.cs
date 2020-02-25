using Itenso.TimePeriod;
using Kledex.Queries;

namespace Registrations.Domain.Registrations.Commands.Validators.Queries
{
	public class UserExistsWithInfo : IQuery<bool>
	{
		public string Firstname{ get; }
		public string Lastname{ get; }
		public Date DateofBirth { get; }
		
		public UserExistsWithInfo(string firstname, string lastname, Date dateOfBirth)
		{
			Firstname = firstname;
			Lastname = lastname;
			DateofBirth = dateOfBirth;
		}
	}
}
