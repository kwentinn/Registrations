using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Registrations.Controllers
{
	public class RegistrationController : Controller
	{
		[HttpPost]
		public async Task<IActionResult> Create()
		{
			return Ok();
		}
	}
}
