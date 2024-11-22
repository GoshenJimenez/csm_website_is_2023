using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMWebsite2023.Data.Models
{
    public class LoginInfo : BaseModel
    {
        public Guid? UserId { get; set; }
        public User? User { get; set; }
        public string? Key { get; set; }
        public string? Value { get; set; }
    }
}
