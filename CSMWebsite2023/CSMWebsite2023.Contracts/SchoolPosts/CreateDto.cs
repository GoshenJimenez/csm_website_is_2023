using CSMWebsite2023.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMWebsite2023.Contracts.SchoolPosts
{
    public class CreateDto
    {
        public Guid? Id { get; set; }
        public string? Title { get; set; }
        public Guid? UserId { get; set; }
        public string? Content { get; set; }
    }
}
