using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMWebsite2023.Data.Models
{
    public class SchoolPost : BaseModel
    {
        public string? Title { get; set; }
        public Guid? UserId { get; set; }
        public User? User { get; set; }
        public string? Content { get; set; }
    }
}
