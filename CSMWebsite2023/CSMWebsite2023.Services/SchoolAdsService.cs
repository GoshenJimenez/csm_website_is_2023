using AutoMapper;
using CSMWebsite2023.Contracts;
using CSMWebsite2023.Contracts.SchoolAds;
using CSMWebsite2023.Contracts.SchoolPosts;
using CSMWebsite2023.Data.Models;
using CSMWebsite2023.Services.Common;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMWebsite2023.Services
{
    public class SchoolAdsService : BaseService, ISchoolAdsService
    {
        private readonly IRepository<SchoolAds> _schooladsRepository;
        private readonly IRepository<SchoolAdsMedium> _schooladsMediumRepository;
        public SchoolAdsService(IConfiguration configuration, ILogger<BaseService> logger, IMapper mapper,
              IRepository<SchoolAds> schooladsRepository,
              IRepository<SchoolAdsMedium> schooladsMediumRepository
            )
            : base(configuration, logger, mapper)
        {
            _schooladsRepository = schooladsRepository;
            _schooladsMediumRepository = schooladsMediumRepository;
        }

        public SchoolAdsDto? GetSchoolAdById(Guid? id)
        {
            var query = _schooladsRepository.All()
                         .FirstOrDefault(a => a.Id == id);

            var result = Mapper.Map<SchoolAdsDto>(query);

            var image = _schooladsMediumRepository.All().Where(a => a.SchoolAdsId == id && a.MediaType == Data.Enums.MediaType.ImageUrl).FirstOrDefault();

            if (image != null)
            {
                result.ArticleImage = image.Value;
            }

            return result;
        }

        public List<SchoolAdsDto>? GetSchoolAds()
        {
            var query = _schooladsRepository.All();

            return Mapper.Map<List<SchoolAdsDto>>(query);
        }
        public List<SchoolAdsDto>? GetSchoolAd()
        {
            throw new NotImplementedException();
        }
    }
}
