using AutoMapper;
using CSMWebsite2023.Contracts;
using CSMWebsite2023.Contracts.Researches;
using CSMWebsite2023.Contracts.SchoolEvents;
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
    public class SchoolEventService : BaseService, ISchoolEventService
    {
        private readonly IRepository<SchoolEvent> _schoolEventRepository;
        private readonly IRepository<SchoolEventMedium> _schoolEventMediumRepository;
        public SchoolEventService(IConfiguration configuration, ILogger<BaseService> logger, IMapper mapper,
              IRepository<SchoolEvent> schoolEventRepository,
              IRepository<SchoolEventMedium> schoolEventMediumRepository
            )
            : base(configuration, logger, mapper)
        {
            _schoolEventRepository = schoolEventRepository;
            _schoolEventMediumRepository = schoolEventMediumRepository;
        }
        public SchoolEventDto? GetSchoolEventById(Guid? id)
        {
            var query = _schoolEventRepository.All()
                         .FirstOrDefault(a => a.Id == id);

            var result = Mapper.Map<SchoolEventDto>(query);

            var image = _schoolEventMediumRepository.All().Where(a => a.SchoolEventId == id && a.MediaType == Data.Enums.MediaType.ArticleImage).FirstOrDefault();

            if (image != null)
            {
                result.ArticleImage = image.Value;
            }

            return result;
        }

        public List<SchoolEventDto>? GetSchoolEvents()
        {
            var query = _schoolEventRepository.All();

            return Mapper.Map<List<SchoolEventDto>>(query);
        }
    }
}
