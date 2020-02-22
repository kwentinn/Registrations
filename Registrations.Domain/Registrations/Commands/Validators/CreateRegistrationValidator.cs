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
		}
	}
}
