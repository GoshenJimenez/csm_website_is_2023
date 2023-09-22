using CSMWebsite2023.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMWebsite2023.Contracts.SchoolPosts
{
    public class SchoolPostDto
    {
        public Guid? Id { get; set; }
        public string? Title { get; set; }
        public Guid? UserId { get; set; }
        public User? User { get; set; }
        public string? Content { get; set; }
        public List<SchoolPostMedium>? SchoolPostMedia { get; set; }
    }
}
