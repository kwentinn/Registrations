using Kledex.Domain;

namespace Registrations.Domain.Registrations.Events
{
	/// <summary>
	/// Représente une inscription résiliée.
	/// </summary>
	public class RegistrationTerminated : DomainEvent
	{
		/// <summary>
		/// Raison pour laquelle l'inscription a été résiliée.
		/// </summary>
		public string TerminationReason { get; set; }
	}
}
