using CSMWebsite2023.Contracts.LoginInfo;
using CSMWebsite2023.Contracts.Users;
using CSMWebsite2023.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace CSMWebsite2023.Web.Pages.Account
{
    public class Logout : PageModel
    {
        public readonly ILoginInfoService _loginInfoService;
        public readonly IUserService _userService;

        public Logout(ILoginInfoService loginInfoService, IUserService userService)
        {
            _userService = userService;
            _loginInfoService = loginInfoService;
        }

        public void OnGet()
        {
            HttpContext.Session.SetString("UserName", string.Empty);
            HttpContext.Session.SetString("EmailAddress", string.Empty);
            HttpContext.Session.Clear();
        }
    }
}
