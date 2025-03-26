using CSMWebsite2023.Contracts.Users;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CSMWebsite2023.Web.Pages.Account
{
    public class UpdateProfile : PageModel
    {

		private readonly ILogger<Profile> _logger;
		private readonly IUserService _userService;

		public UpdateProfile(ILogger<Profile> logger, IUserService userService)
		{
			_logger = logger;
			_userService = userService;
		}

		[BindProperty]
		public string? FirstName { get; set; }

		[BindProperty]
		public string? LastName { get; set; }

		[BindProperty]
		public string? UserId { get; set; }

		[BindProperty]
		public string? EmailAddress { get; set; }

		[BindProperty]
		public string? Role { get; set; }

		public void OnGet()
		{
			this.UserId = HttpContext.Session.GetString("UserId");
			this.EmailAddress = HttpContext.Session.GetString("EmailAddress");
			this.Role = HttpContext.Session.GetString("Role");

			if (string.IsNullOrEmpty(this.UserId))
			{
				var user = _userService.GetUserById(Guid.Parse(this.UserId!));

				if (user != null) { 
					this.FirstName = user.FirstName;
					this.LastName = user.LastName;
				}
			}
		}

		public IActionResult OnPost()
		{
			if (!string.IsNullOrEmpty(this.FirstName) && !string.IsNullOrEmpty(this.LastName))
			{

				var user = _userService.GetUserById(Guid.Parse(this.UserId!));

				if (user != null)
				{
					user.FirstName = this.FirstName;
					user.LastName = this.LastName;

					_userService.UpdateUserProfile(user);
					HttpContext.Session.SetString("UserName", user.FirstName + " " + user.LastName);
				}
			}

			return RedirectPermanent("~/account/profile");
		}
	}
}
