using Kledex.Domain;
using Registrations.Domain.Registrations.Events;
using System;

namespace Registrations.Domain.Registrations
{
	public class Registration : AggregateRoot
	{
		/// <summary>
		/// Who is being registered ?
		/// </summary>
		public Person Person { get; private set; }

		/// <summary>
		/// What is being registered ?
		/// </summary>
		public RegistrationTarget RegistrationTarget { get; private set; }

		/// <summary>
		/// When is the registration happening ?
		/// </summary>
		public RegistrationDate RegistrationDate { get; private set; }

		public Registration()
		{
		}

		public Registration(Guid id, Person person, RegistrationTarget registrationTarget, RegistrationDate registrationDate) : base(id)
		{
			if (id.Equals(Guid.Empty)) throw new ArgumentException(nameof(person), "Id cannot be an empty guid.");
			if (person is null) throw new ArgumentNullException(nameof(person), "Person cannot be null.");
			if (registrationTarget is null) throw new ArgumentNullException(nameof(registrationTarget), "RegistrationSubject cannot be null.");
			if (registrationDate is null) throw new ArgumentNullException(nameof(registrationDate), "RegistrationDate cannot be null.");

			AddAndApplyEvent(new RegistrationCreated
			{
				AggregateRootId = id,
				Person = person,
				RegistrationTarget = registrationTarget,
				RegistrationDate = registrationDate
			});
		}

		public void ChangeRegistrationTarget(RegistrationTarget newRegistrationTarget)
		{
			AddAndApplyEvent(new RegistrationTargetChanged
			{
				AggregateRootId = Id,
				NewRegistrationTarget = newRegistrationTarget
			});
		}
		public void ChangeRegistrationDate(RegistrationDate newRegistrationDate)
		{
			AddAndApplyEvent(new RegistrationDateChanged
			{
				AggregateRootId = Id,
				NewRegistrationDate = newRegistrationDate
			});
		}
		public void Terminate(string reason)
		{
			AddAndApplyEvent(new RegistrationTerminated
			{
				AggregateRootId = Id,
				TerminationReason = reason
			});
		}

		private void Apply(RegistrationCreated @event)
		{
			Id = @event.AggregateRootId;
			Person = @event.Person;
			RegistrationTarget = @event.RegistrationTarget;
			RegistrationDate = @event.RegistrationDate;
		}
		private void Apply(RegistrationTargetChanged @event)
		{
			RegistrationTarget = @event.NewRegistrationTarget;
		}
		private void Apply(RegistrationDateChanged @event)
		{
			RegistrationDate = @event.NewRegistrationDate;
		}
	}
}
