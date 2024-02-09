using AutoMapper;
using CSMWebsite2023.Contracts;
using CSMWebsite2023.Contracts.Researches;
using CSMWebsite2023.Data.Models;
using CSMWebsite2023.Services.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMWebsite2023.Services
{
    public class ResearchesService : BaseService, IResearchService
    {
        private readonly IRepository<Research> _researchesRepository;
        private readonly IRepository<ResearchMedium> _researchesMediumRepository;
        public ResearchesService(IConfiguration configuration, ILogger<BaseService> logger, IMapper mapper,
              IRepository<Research> researchesRepository,
              IRepository<ResearchMedium> researchesMediumRepository
            )
            : base(configuration, logger, mapper)
        {
            _researchesRepository = researchesRepository;
            _researchesMediumRepository = researchesMediumRepository;
        }

        public async Task<OperationDto<ResearchDto>>? Create(CreateDto? dto)
        {
            try
            {
                if (dto == null)
                {
                    return new OperationDto<ResearchDto>()
                    {
                        Status = OpStatus.Fail,
                        Message = "dto is null"
                    };
                }

                var researches = new Research()
                {
                    Id = dto!.Id != null ? dto.Id : Guid.NewGuid(),
                    Abstract = dto!.Abstract,
                    Title = dto!.Title,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,

                    IsActive = true
                };

                await _researchesRepository.AddAsync(researches);

                var thumbnailResearchMedium = new ResearchMedium()
                {
                    Id = Guid.NewGuid(),
                    ResearchId = researches.Id,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    MediaType = Data.Enums.MediaType.Thumbnail,
                    Value = $"/researches/{researches.Id}/thumbnail.png"
                };

                var galleryImageResearchMedium = new ResearchMedium()
                {
                    Id = Guid.NewGuid(),
                    ResearchId = researches.Id,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    MediaType = Data.Enums.MediaType.GalleryImage,
                    Value = $"/researches/{researches.Id}/gallery-image.png"
                };

                var articleImageResearchMedium = new ResearchMedium()
                {
                    Id = Guid.NewGuid(),
                    ResearchId = researches.Id,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    MediaType = Data.Enums.MediaType.ArticleImage,
                    Value = $"/researches/{researches.Id}/article-image.png"
                };

                await _researchesMediumRepository.AddAsync(thumbnailResearchMedium);
                await _researchesMediumRepository.AddAsync(galleryImageResearchMedium);
                await _researchesMediumRepository.AddAsync(articleImageResearchMedium);

                await _researchesRepository.SaveChangesAsync();

                return new OperationDto<ResearchDto>()
                {
                    ReferenceId = researches.Id,
                    ReferenceData = Mapper.Map<ResearchDto>(researches),
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

        public async Task<OperationDto<ResearchDto>>? Update(UpdateDto? dto)
        {
            try
            {
                if (dto == null)
                {
                    return new OperationDto<ResearchDto>()
                    {
                        Status = OpStatus.Fail,
                        Message = "dto is null"
                    };
                }

                var researches = _researchesRepository.All().FirstOrDefault(a => a.Id == dto.Id);

                if (researches != null)
                {
                    researches.Abstract = dto!.Abstract;
                    researches.Title = dto!.Title;
                    researches.UpdatedAt = DateTime.Now;

                    _researchesRepository.Update(researches);
                }

                await _researchesRepository.SaveChangesAsync();

                return new OperationDto<ResearchDto>()
                {
                    ReferenceId = researches.Id,
                    ReferenceData = Mapper.Map<ResearchDto>(researches),
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

        public async Task<OperationDto<ResearchDto>>? Delete(ActivationDto? dto)
        {
            try
            {
                if (dto == null)
                {
                    return new OperationDto<ResearchDto>()
                    {
                        Status = OpStatus.Fail,
                        Message = "dto is null"
                    };
                }

                var researches = _researchesRepository.All().FirstOrDefault(a => a.Id == dto.Id);

                if (researches != null)
                {
                    researches.IsActive = false;
                    researches.UpdatedAt = DateTime.Now;

                    _researchesRepository.Update(researches);
                }

                await _researchesRepository.SaveChangesAsync();

                return new OperationDto<ResearchDto>()
                {
                    ReferenceId = researches.Id,
                    ReferenceData = Mapper.Map<ResearchDto>(researches),
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

        public async Task<OperationDto<ResearchDto>>? Restore(ActivationDto? dto)
        {
            try
            {
                if (dto == null)
                {
                    return new OperationDto<ResearchDto>()
                    {
                        Status = OpStatus.Fail,
                        Message = "dto is null"
                    };
                }

                var researches = _researchesRepository.All().FirstOrDefault(a => a.Id == dto.Id);

                if (researches != null)
                {
                    researches.IsActive = true;
                    researches.UpdatedAt = DateTime.Now;

                    _researchesRepository.Update(researches);
                }

                await _researchesRepository.SaveChangesAsync();

                return new OperationDto<ResearchDto>()
                {
                    ReferenceId = researches.Id,
                    ReferenceData = Mapper.Map<ResearchDto>(researches),
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

        public ResearchDto? GetResearchById(Guid? id)
        {
            var query = _researchesRepository.All()
                         .FirstOrDefault(a => a.Id == id);

            var result = Mapper.Map<ResearchDto>(query);

            var media = _researchesMediumRepository.All().Where(a => a.ResearchId == id).ToList();

            result.ResearchMedia = media;

            return result;
        }

        public async Task<Paged<ResearchDto>>? Search(bool? isActive = true, int? pageIndex = 1, int? pageSize = 10, string? keyword = "")
        {
            var query = _researchesRepository.All().AsQueryable();

            query = query.Where(a => a.IsActive == isActive);

            var count = query.Count();
            var skip = ((pageIndex - 1) * pageSize)!.Value;
            var list = query.Skip(skip).Take(pageSize!.Value).ToList();

            var result = Mapper.Map<List<ResearchDto>>(list);

            return new Paged<ResearchDto>()
            {
                PageIndex = pageIndex.Value,
                PageSize = pageSize.Value,
                Items = result,
                TotalItems = count,
                IsActive = isActive,
            };
        }
    }
}