using CSMWebsite2023.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMWebsite2023.Contracts.Researches
{
    public class ResearchDto
    {
        public Guid? Id { get; set; }
        public Guid? UserId { get; set; }
        public string? Title { get; set; }
        public string? Abstract { get; set; }
        public string? ArticleImage { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<ResearchMedium>? ResearchMedia { get; set; }

    }
}
