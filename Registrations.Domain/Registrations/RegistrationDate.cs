using Itenso.TimePeriod;
using Kledex.Domain;
using System.Collections.Generic;

namespace Registrations.Domain.Registrations
{
	public class RegistrationDate : ValueObject
	{
		public TimeRange Period { get; }

		protected override IEnumerable<object> GetAtomicValues()
		{
			yield return Period;
		}
	}
}