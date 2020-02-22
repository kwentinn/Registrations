using Kledex.Commands;
using System;
using System.Threading.Tasks;

namespace Registrations.Domain.Registrations.Commands.Handlers
{
	public class CreateRegistrationHandler : ICommandHandlerAsync<CreateRegistration>
	{
		public async Task<CommandResponse> HandleAsync(CreateRegistration command)
		{
			var registration = new Registration(command.AggregateRootId, command.Person, command.RegistrationTarget, command.RegistrationDate);

			return await Task.FromResult(new CommandResponse
			{
				Events = registration.Events
			});
		}
	}
}
