using AutoMapper;
using CSMWebsite2023.Contracts;
using CSMWebsite2023.Contracts.SchoolEvents;
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
        public async Task<OperationDto<SchoolEventDto>>? Create(CreateDto? dto)
        {
            try
            {

                var schoolEvent = new SchoolEvent()
                {
                    Id = dto!.Id != null ? dto.Id : Guid.NewGuid(),
                    Description = dto!.Description,
                    Title = dto!.Title,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    IsActive = true
                };
                var thumbnailSchoolEventMedium = new SchoolEventMedium()
                {
                    Id = Guid.NewGuid(),
                    SchoolEventId = schoolEvent.Id,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    MediaType = Data.Enums.MediaType.Thumbnail,
                    Value = $"//schoolEvent//{schoolEvent.Id}//thumbnail.png"

                };
                var galleryImageSchoolEventMedium = new SchoolEventMedium()
                {
                    Id = Guid.NewGuid(),
                    SchoolEventId = schoolEvent.Id,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    MediaType = Data.Enums.MediaType.GalleryImage,
                    Value = $"//schoolEvent//{schoolEvent.Id}//gallery-image.png"

                };
                var articleImageSchoolEventMedium = new SchoolEventMedium()
                {
                    Id = Guid.NewGuid(),
                    SchoolEventId = schoolEvent.Id,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    MediaType = Data.Enums.MediaType.ArticleImage,
                    Value = $"//schoolEvent//{schoolEvent.Id}//article-image.png"

                };

                await _schoolEventMediumRepository.AddAsync(thumbnailSchoolEventMedium);
                await _schoolEventMediumRepository.AddAsync(galleryImageSchoolEventMedium);
                await _schoolEventMediumRepository.AddAsync(articleImageSchoolEventMedium);

                await _schoolEventRepository.SaveChangesAsync();
                await _schoolEventRepository.AddAsync(schoolEvent);

                return new OperationDto<SchoolEventDto>()
                {
                    ReferenceId = schoolEvent.Id,
                    ReferenceData = Mapper.Map<SchoolEventDto>(schoolEvent),
                    Status = OpStatus.Ok,
                    Message = "Success"
                };
            }
            catch (Exception ex)
            {
                return new OperationDto<SchoolEventDto>()
                {
                    Status = OpStatus.Fail,
                    Message = ex.Message
                };
            }

            public async Task<OperationDto<SchoolEventDto>>? Update(UpdateDto? dto)
            {
                try
                {
                    var schoolEvent = _schoolEventRepository.All().FirstOrDefault(a => a.Id == dto.Id);

                    if (schoolEvent != null)
                    {
                        schoolEvent.Description = dto!.Description;
                        schoolEvent.Title = dto!.Title;
                        schoolEvent.UpdatedAt = DateTime.Now;

                        _schoolEventRepository.Update(schoolEvent);
                    }

                    await _schoolEventRepository.SaveChangesAsync();

                    return new OperationDto<SchoolEventDto>()
                    {
                        ReferenceId = schoolEvent.Id,
                        ReferenceData = Mapper.Map<SchoolEventDto>(schoolEvent),
                        Status = OpStatus.Ok,
                        Message = "Success"
                    };
                }
                catch (Exception ex)
                {
                    return new OperationDto<SchoolEventDto>()
                    {
                        Status = OpStatus.Fail,
                        Message = ex.Message
                    };
                }
            }

            public async Task<OperationDto<SchoolEventDto>>? Delete(ActivationDto? dto)
            {
                try
                {
                    if (dto == null)
                    {
                        return new OperationDto<SchoolEventDto>()
                        {
                            Status = OpStatus.Fail,
                            Message = "dto is null"
                        };
                    }

                    var schoolEvent = _schoolEventRepository.All().FirstOrDefault(a => a.Id == dto.Id);

                    if (schoolEvent != null)
                    {
                        schoolEvent.IsActive = false;
                        schoolEvent.UpdatedAt = DateTime.Now;

                        _schoolEventRepository.Update(schoolEvent);
                    }

                    await _schoolEventRepository.SaveChangesAsync();

                    return new OperationDto<SchoolEventDto>()
                    {
                        ReferenceId = schoolEvent.Id,
                        ReferenceData = Mapper.Map<SchoolEventDto>(schoolEvent),
                        Status = OpStatus.Ok,
                        Message = "Success"
                    };
                }
                catch (Exception ex)
                {
                    return new OperationDto<SchoolEventDto>()
                    {
                        Status = OpStatus.Fail,
                        Message = ex.Message
                    };
                }
            }

            public async Task<OperationDto<SchoolEventDto>>? Restore(ActivationDto? dto)
            {
                try
                {
                    if (dto == null)
                    {
                        return new OperationDto<SchoolEventDto>()
                        {
                            Status = OpStatus.Fail,
                            Message = "dto is null"
                        };
                    }

                    var schoolEvent = _schoolEventRepository.All().FirstOrDefault(a => a.Id == dto.Id);

                    if (schoolEvent != null)
                    {
                        schoolEvent.IsActive = true;
                        schoolEvent.UpdatedAt = DateTime.Now;

                        _schoolEventRepository.Update(schoolEvent);
                    }

                    await _schoolEventRepository.SaveChangesAsync();

                    return new OperationDto<SchoolEventDto>()
                    {
                        ReferenceId = schoolEvent.Id,
                        ReferenceData = Mapper.Map<SchoolEventDto>(schoolEvent),
                        Status = OpStatus.Ok,
                        Message = "Success"
                    };
                }
                catch (Exception ex)
                {
                    return new OperationDto<SchoolEventDto>()
                    {
                        Status = OpStatus.Fail,
                        Message = ex.Message
                    };
                }
            }
        }
    }
}
