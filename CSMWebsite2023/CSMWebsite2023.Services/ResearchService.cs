using AutoMapper;
using CSMWebsite2023.Contracts;
using CSMWebsite2023.Contracts.Researches;
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
    public class ResearchService : BaseService, IResearchService
    {
        private readonly IRepository<Research> _researchRepository;
        private readonly IRepository<ResearchMedium> _researchMediumRepository;
        public ResearchService(IConfiguration configuration, ILogger<BaseService> logger, IMapper mapper,
              IRepository<Research> researchRepository,
              IRepository<ResearchMedium> researchMediumRepository
            )
            : base(configuration, logger, mapper)
        {
            _researchRepository = researchRepository;
            _researchMediumRepository = researchMediumRepository;
        }
        public ResearchDto? GetResearchById(Guid? id)
        {
            var query = _researchRepository.All()
                         .FirstOrDefault(a => a.Id == id);

            var result = Mapper.Map<ResearchDto>(query);

            var image = _researchMediumRepository.All().Where(a => a.ResearchId == id && a.MediaType == Data.Enums.MediaType.ImageUrl).FirstOrDefault();

            if (image != null)
            {
                result.ArticleImage = image.Value;
            }

            return result;
        }

        public List<ResearchDto>? GetResearches()
        {
            var query = _researchRepository.All();

            return Mapper.Map<List<ResearchDto>>(query);
        }
    }
}
