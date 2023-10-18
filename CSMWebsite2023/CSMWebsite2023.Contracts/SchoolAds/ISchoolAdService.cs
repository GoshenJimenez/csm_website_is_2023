using CSMWebsite2023.Contracts.Chats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMWebsite2023.Contracts.SchoolAds
{
    public interface ISchoolAdService : IService
    {
        List<SchoolAdDto>? GetSchoolAds();
        SchoolAdDto? GetSchoolAdById(Guid? id);
    }
}
