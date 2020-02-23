using FluentValidation;

namespace Registrations.Domain.Registrations.Commands.Validators
{
	public class TerminateRegistrationValidator : AbstractValidator<TerminateRegistration>
	{
		public TerminateRegistrationValidator()
		{
			RuleFor(c => c.TerminationReason)
				.NotEmpty().WithMessage("Termination reason is required")
			;
		}
	}
}
