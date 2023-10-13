using CSMWebsite2023.Contracts.Chats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMWebsite2023.Contracts.SchoolAds
{
    public interface ISchoolAdsService : IService
    {
        List<SchoolAdsDto>? GetSchoolAd();
        SchoolAdsDto? GetSchoolAdById(Guid? id);
        SchoolAdsDto? GetSchoolAdsById(Guid? id);
    }
}
