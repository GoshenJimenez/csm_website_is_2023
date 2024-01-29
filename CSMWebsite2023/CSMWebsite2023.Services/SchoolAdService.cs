using AutoMapper;
using CSMWebsite2023.Contracts;
using CSMWebsite2023.Contracts.SchoolAds;
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

        public async Task<OperationDto<SchoolAdDto>>? Create(CreateDto? dto)
        {
            try
            {
                var schoolads = new SchoolAd()
                {
                    Id = Guid.NewGuid(),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                    Title = dto.Title,
                    Description = dto.Description,
                };
                await _schooladsRepository.AddAsync(schoolads);
                await _schooladsRepository.SaveChangesAsync();

                return new OperationDto<SchoolAdDto>()
                {
                    ReferenceId = schoolads.Id,
                    ReferenceData = Mapper.Map<SchoolAdDto>(schoolads),
                    Status = OpStatus.Ok,
                    Message = "Success"
                };
            }
            catch (Exception ex)
            {
                return new OperationDto<SchoolAdDto>()
                {
                    Status = OpStatus.Fail,
                    Message = ex.Message
                };
            }
        }

        public Task<OperationDto<SchoolAdDto>>? Update(UpdateDto? dto)
        {
            throw new NotImplementedException();
        }

        public Task<OperationDto<SchoolAdDto>>? Delete(ActivationDto? dto)
        {
            throw new NotImplementedException();
        }

        public Task<OperationDto<SchoolAdDto>>? Restore(ActivationDto? dto)
        {
            throw new NotImplementedException();
        }

        public Task<Paged<SchoolAdDto>>? Search(bool? isActive = true, int? pageIndex = 1, int? pageSize = 10, string? keyword = "")
        {
            throw new NotImplementedException();
        }
    }
}
