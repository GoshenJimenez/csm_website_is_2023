using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMWebsite2023.Contracts.GroupPosts
{
    public class ActivationDto
    {
        public Guid? Id { get; set; }
        public bool? IsActive { get; set; }

    }
}
