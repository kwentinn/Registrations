using FluentValidation;
using Kledex;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Registrations.Domain.Registrations.Commands.Validators
{
	public class CreateRegistrationValidator : AbstractValidator<CreateRegistration>
	{
		private readonly IDispatcher _dispatcher;


		public CreateRegistrationValidator(IDispatcher dispatcher)
		{
			_dispatcher = dispatcher;

			RuleFor(c => c.Person)
				.NotNull().WithMessage("Person is required")
				.MustAsync(UserExistAsync).WithMessage("User does not exist");

			RuleFor(c => c.RegistrationTarget)
				.NotNull().WithMessage("Registration target is required");

			RuleFor(c => c.RegistrationDate)
				.NotNull().WithMessage("Registration date is required");

			RuleFor(c => c)
				.MustAsync(RegistrationNotExistAsync).WithMessage("Registration already exists");
		}

		private async Task<bool> RegistrationNotExistAsync(CreateRegistration obj, CancellationToken cancellationToken)
		{
			return await _dispatcher.GetResultAsync(new Queries.RegistrationExists
			(
				obj.Person.Id, 
				obj.RegistrationTarget.Id,
				obj.RegistrationDate
			));
		}
		private async Task<bool> UserExistAsync(Person p, CancellationToken cancellationToken)
		{
			return await _dispatcher.GetResultAsync(new Queries.UserExistsWithEmail(p.EmailAddress));
		}
	}
}
