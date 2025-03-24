using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CSMWebsite2023.Web.Pages.Account
{
    public class Profile : PageModel
    {

		//UserId, UserName, EmailAddress, Role

		private readonly ILogger<Profile> _logger;

		public Profile(ILogger<Profile> logger)
		{
			_logger = logger;
		}

		[BindProperty]
		public string? UserName { get; set; }

		[BindProperty]
		public string? UserId { get; set; }

		[BindProperty]
		public string? EmailAddress { get; set; }

		[BindProperty]
		public string? Role { get; set; }

		public void OnGet()
		{
			this.UserName = HttpContext.Session.GetString("UserName");
			this.UserId = HttpContext.Session.GetString("UserId");
			this.EmailAddress = HttpContext.Session.GetString("EmailAddress");
			this.Role = HttpContext.Session.GetString("Role");
		}

    }
}
