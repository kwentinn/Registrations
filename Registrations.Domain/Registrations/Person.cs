using Kledex.Domain;

namespace Registrations.Domain.Registrations
{
	public class Person : Entity
	{
		public string Firstname { get; set; }
		public string Lastname { get; set; }
		public string EmailAddress { get; set; }
	}
}