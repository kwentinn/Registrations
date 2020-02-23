using FluentValidation;

namespace Registrations.Domain.Registrations.Commands.Validators
{
	public class CreateRegistrationValidator : AbstractValidator<CreateRegistration>
	{
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
		}
	}
}
