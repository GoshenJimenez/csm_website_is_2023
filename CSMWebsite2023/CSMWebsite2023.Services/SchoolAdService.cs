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
    public class SchoolAdService : BaseService, ISchoolAdService
    {
        private readonly IRepository<SchoolAd> _schooladsRepository;
        private readonly IRepository<SchoolAdMedium> _schooladsMediumRepository;
        public SchoolAdService(IConfiguration configuration, ILogger<BaseService> logger, IMapper mapper,
              IRepository<SchoolAd> schooladsRepository,
              IRepository<SchoolAdMedium> schooladsMediumRepository
            )
            : base(configuration, logger, mapper)
        {
            _schooladsRepository = schooladsRepository;
            _schooladsMediumRepository = schooladsMediumRepository;
        }

        public SchoolAdDto? GetSchoolAdById(Guid? id)
        {
            var query = _schooladsRepository.All()
                         .FirstOrDefault(a => a.Id == id);

            var result = Mapper.Map<SchoolAdDto>(query);

            var image = _schooladsMediumRepository.All().Where(a => a.SchoolAdsId == id && a.MediaType == Data.Enums.MediaType.ImageUrl).FirstOrDefault();

            if (image != null)
            {
                result.ArticleImage = image.Value;
            }

            return result;
        }

        public List<SchoolAdDto>? GetSchoolAds()
        {
            var query = _schooladsRepository.All();

            return Mapper.Map<List<SchoolAdDto>>(query);
        }

    }
}
