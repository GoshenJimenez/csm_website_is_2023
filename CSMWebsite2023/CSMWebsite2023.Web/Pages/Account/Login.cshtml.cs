using CSMWebsite2023.Contracts.LoginInfo;
using CSMWebsite2023.Contracts.SchoolPosts;
using CSMWebsite2023.Contracts.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.WebSockets;


namespace CSMWebsite2023.Web.Pages.Account
{
    public class Login : PageModel
    {
        public readonly ILoginInfoService _loginInfoService;
        public readonly IUserService _userService;

        [BindProperty]
        public string? EmailAddress { get; set; }

        [BindProperty]
        public string? Password { get; set; }

        public Login(ILoginInfoService loginInfoService, IUserService userService)
        {
            _userService = userService;
            _loginInfoService = loginInfoService;
        }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            var user = _userService.GetUserByEmail(this.EmailAddress);

            if (user != null)
            {
                var loginInfos = _loginInfoService.GetPerUser(user.Id);

                if (loginInfos != null)
                {
                    var accountStatusInfo = loginInfos.FirstOrDefault(a => a.Key != null && a.Key.ToLower() == "accountstatus");

                    if (accountStatusInfo != null && accountStatusInfo.Value != null && accountStatusInfo.Value.ToLower() == "active")
                    {
                        var passwordInfo = loginInfos.FirstOrDefault(a => a.Key != null && a.Key.ToLower() == "password");

                        if (passwordInfo != null)
                        {
                            var result = BCrypt.Net.BCrypt.Verify(this.Password, passwordInfo.Value);

                            if (result == true)
                            {
                                //Tama yung password
                            }
                            else
                            {
                                //Mali yung password
                                var loginAttemptInfo = loginInfos.FirstOrDefault(a => a.Key != null && a.Key.ToLower() == "loginattempt");

                                int? attempts = 1;
                                if (loginAttemptInfo != null)
                                {
                                    attempts = int.Parse(loginAttemptInfo.Value!) + 1;

                                    if (attempts > 3)
                                    {
                                        accountStatusInfo.Value = "lockedout";
                                        //Inactive account
                                    }
                                }
                                else
                                {
                                    loginAttemptInfo = new LoginInfoDto()
                                    {
                                        UserId = user.Id,
                                        Key = "loginattempt",
                                        Value = attempts.ToString()
                                    };

                                    //Mali ang password
                                }

                            }
                        }
                    }
                    else
                    {
                        //Inactive account
                    }
                }            
            }
        }
    }
}
