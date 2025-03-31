using CSMWebsite2023.Contracts.LoginInfo;
using CSMWebsite2023.Contracts.Users;
using CSMWebsite2023.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CSMWebsite2023.Web.Pages.Account
{
    public class ChangePassword : PageModel
    {
		public readonly ILoginInfoService _loginInfoService;

		[BindProperty]
		public string? OldPassword { get; set; }

		[BindProperty]
		public string? NewPassword { get; set; }

		[BindProperty]
		public string? ConfirmNewPassword { get; set; }

		public Guid? UserId { get; set; }

		public ChangePassword(ILoginInfoService loginInfoService)
		{
			_loginInfoService = loginInfoService;
		}


		public async Task<IActionResult> OnPost()
		{
			if (string.IsNullOrWhiteSpace(OldPassword) || string.IsNullOrWhiteSpace(NewPassword) || string.IsNullOrWhiteSpace(ConfirmNewPassword))
			{
				ModelState.AddModelError("Error while changing password", "Old,, New and Confirm Passwords are required");
				return Page();
			}

			if(this.NewPassword == this.ConfirmNewPassword)
			{
				ModelState.AddModelError("Error while changing password", "Confirm Password does not match New Password");
				return Page();
			}

			this.UserId = Guid.Parse(HttpContext.Session.GetString("UserId")!);
			var passwordInfo = _loginInfoService.GetPassword(this.UserId);

			if (passwordInfo != null)
			{
				var result = BCrypt.Net.BCrypt.Verify(this.OldPassword, passwordInfo.Value);

				if (result == true)
				{
					var op = await _loginInfoService.ChangePassword(new ChangePasswordDto()
					{
						UserId = this.UserId,
						NewPassword = BCrypt.Net.BCrypt.HashPassword(this.NewPassword)
					});

					if (op != null && op.Status != Contracts.OpStatus.Ok)
					{
						ModelState.AddModelError("Error while changing password", op.Message!);
						return Page();
					}

					return RedirectPermanent("~/index");
				}
				else
				{
					ModelState.AddModelError("Incorrect old password","Old Password is incorrect");
				}
			}
			return Page();
		}
	}
}
