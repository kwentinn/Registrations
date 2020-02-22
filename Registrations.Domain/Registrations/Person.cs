using System;

namespace Registrations.Domain.Registrations
{
	public class Person
	{
		public Guid	Id { get; set; }
		public string Firstname { get; set; }
		public string Lastname { get; set; }
		public string EmailAddress { get; set; }
	}
}