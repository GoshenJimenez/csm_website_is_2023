using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMWebsite2023.Data.Models
{
    public class ChatMember : BaseModel
    {
        public Guid? ChatId { get; set; }
        public Chat? Chat { get; set; }
        public Guid? UserId { get; set; }
        public User? User { get; set; }

    }
}
