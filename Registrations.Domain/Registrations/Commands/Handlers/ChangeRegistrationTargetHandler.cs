using Kledex.Commands;
using Kledex.Domain;
using System;
using System.Threading.Tasks;

namespace Registrations.Domain.Registrations.Commands.Handlers
{
	public class ChangeRegistrationTargetHandler : ICommandHandlerAsync<ChangeRegistrationTarget>
	{
		private readonly IRepository<Registration> _repository;

		public ChangeRegistrationTargetHandler(IRepository<Registration> repository)
		{
			_repository = repository;
		}

		public async Task<CommandResponse> HandleAsync(ChangeRegistrationTarget command)
		{
			var registration = await _repository.GetByIdAsync(command.AggregateRootId);
			if (registration == null)
			{
				throw new ApplicationException($"Registration not found. Id: {command.AggregateRootId}");
			}

			registration.ChangeRegistrationTarget(command.NewRegistrationTarget);

			return await Task.FromResult(new CommandResponse
			{
				Events = registration.Events
			});
		}
	}
}
