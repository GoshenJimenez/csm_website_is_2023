﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMWebsite2023.Contracts.SchoolEvents
{
    public class SchoolEventsDto
    {
        public Guid? Id { get; set; }
        public string? Title { get; set; }
        public string? Abstract { get; set; }
        public string? ArticleImage { get; set; }

    }
}
