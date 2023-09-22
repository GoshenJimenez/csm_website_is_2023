using CSMWebsite2023.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMWebsite2023.Data.Models
{
    public class SchoolPostComment : BaseModel
    {
        public Guid? SchoolPostId { get; set; }
        public SchoolPost? SchoolPost { get; set; }
        public Guid? UserId { get; set; }
        public User? User { get; set; }
        public string? Message { get; set; }
        public Guid? ReplyToId { get; set; }
    }
}
