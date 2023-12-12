using CSMWebsite2023.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMWebsite2023.Contracts.GroupPosts
{
    public class GroupPostDto
    {
        public Guid? Id { get; set; }
        public Guid? GroupId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? ArticleImage { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<GroupPostMedium>? GroupPostMedia { get; set; }
    }
}