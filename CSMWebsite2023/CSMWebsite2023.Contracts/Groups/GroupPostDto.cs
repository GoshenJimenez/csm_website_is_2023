using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMWebsite2023.Contracts.GroupPost
{
    public class GroupPostDto
    {
        public Guid? Id { get; set; }
        public string? GroupId { get; set; }
        public string? Tittle { get; set; }
        public string? Description { get; set; }
        public string? ArticleImage { get; set; }
    }
}