using AutoMapper;
using CSMWebsite2023.Contracts;
using CSMWebsite2023.Contracts.Researches;
using CSMWebsite2023.Data.Models;
using CSMWebsite2023.Services.Common;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

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
        public async Task<OperationDto<ResearchDto>>? Create(CreateDto? dto)
        {
            try
            {
                var research = new Research()
                {
                    Id = dto!.Id != null ? dto.Id : Guid.NewGuid(),
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Title = dto.Title,
                    Abstract = dto.Abstract,
                };
                var thumbnailResearchMedium = new ResearchMedium()
                {
                    Id = Guid.NewGuid(),
                    ResearchId = research.Id,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    MediaType = Data.Enums.MediaType.Thumbnail,
                    Value = $"//research//{research.Id}//thumbnail.png"

                };
                var galleryImageResearchMedium = new ResearchMedium()
                {
                    Id = Guid.NewGuid(),
                    ResearchId = research.Id,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    MediaType = Data.Enums.MediaType.GalleryImage,
                    Value = $"//research//{research.Id}//gallery-image.png"

                };
                var articleImageResearchMedium = new ResearchMedium()
                {
                    Id = Guid.NewGuid(),
                    ResearchId = research.Id,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    MediaType = Data.Enums.MediaType.ArticleImage,
                    Value = $"//research//{research.Id}//article-image.png"

                };

                await _researchMediumRepository.AddAsync(thumbnailResearchMedium);
                await _researchMediumRepository.AddAsync(galleryImageResearchMedium);
                await _researchMediumRepository.AddAsync(articleImageResearchMedium);

                await _researchRepository.SaveChangesAsync();
                await _researchRepository.AddAsync(research);

                return new OperationDto<ResearchDto>()
                {
                    ReferenceId = research.Id,
                    ReferenceData = Mapper.Map<ResearchDto>(research),
                    Status = OpStatus.Ok,
                    Message = "Success"
                };
            }
            catch (Exception ex)
            {
                return new OperationDto<ResearchDto>()
                {
                    Status = OpStatus.Fail,
                    Message = ex.Message
                };
            }
        }
    }
}
