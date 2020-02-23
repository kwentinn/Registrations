using FluentValidation;
using Kledex;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Registrations.Domain.Registrations.Commands.Validators
{
	public class CreateRegistrationValidator : AbstractValidator<CreateRegistration>
	{
		private readonly IDispatcher dispatcher;
		public CreateRegistrationValidator()
		{
			RuleFor(c => c.Person)
				.NotNull().WithMessage("Person is required")
			;

			RuleFor(c => c.RegistrationTarget)
				.NotNull().WithMessage("Registration target is required")
			;

			RuleFor(c => c.RegistrationDate)
				.NotNull().WithMessage("Registration date is required")
			;

			RuleFor(c => c).MustAsync(RegistrationNotExist).WithMessage("Registration already exists");
		}

		private async Task<bool> RegistrationNotExist(CreateRegistration obj, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}
	}
}
