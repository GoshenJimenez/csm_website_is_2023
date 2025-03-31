using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMWebsite2023.Contracts.LoginInfo
{
	public class ChangePasswordDto
	{
		public Guid? UserId { get; set; }

		public string? NewPassword { get; set; }
	}
}
