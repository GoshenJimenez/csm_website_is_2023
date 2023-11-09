using AutoMapper;
using CSMWebsite2023.Contracts;
using CSMWebsite2023.Contracts.SchoolPosts;
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
    public class SchoolPostService : BaseService, ISchoolPostService
    {
        private readonly IRepository<SchoolPost> _schoolPostRepository;
        private readonly IRepository<SchoolPostMedium> _schoolPostMediaRepository;
        public SchoolPostService(IConfiguration configuration, ILogger<BaseService> logger, IMapper mapper,
              IRepository<SchoolPost> schoolPostRepository,
              IRepository<SchoolPostMedium> schoolPostMediaRepository
            )
            : base(configuration, logger, mapper)
        {
            _schoolPostRepository = schoolPostRepository;
            _schoolPostMediaRepository = schoolPostMediaRepository;
        }

        public async Task<OperationDto<SchoolPostDto>>? Create(CreateDto? dto)
        {
            try
            {
                if (dto == null)
                {
                    return new OperationDto<SchoolPostDto>()
                    {
                        Status = OpStatus.Fail,
                        Message = "dto is null"
                    };
                }

                var schoolPost = new SchoolPost()
                {
                    Id = dto!.Id,
                    Content = dto!.Content,
                    Title = dto!.Title,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    UserId = dto!.UserId,
                };

                await _schoolPostRepository.AddAsync(schoolPost);
                await _schoolPostRepository.SaveChangesAsync();

                return new OperationDto<SchoolPostDto>()
                {
                    ReferenceId = schoolPost.Id,
                    ReferenceData = Mapper.Map<SchoolPostDto>(schoolPost),
                    Status = OpStatus.Ok,
                    Message = "Success"
                };
            }
            catch (Exception ex)
            {
                return new OperationDto<SchoolPostDto>()
                {
                    Status = OpStatus.Fail,
                    Message = ex.Message
                };
            }
        }

        public SchoolPostDto? GetSchoolPostById(Guid? id)
        {
            var query = _schoolPostRepository.All()
                         .Include(a => a.User)
                         .FirstOrDefault(a => a.Id == id);

            var result = Mapper.Map<SchoolPostDto>(query);

            var media = _schoolPostMediaRepository.All().Where(a => a.SchoolPostId == id).ToList();

            result.SchoolPostMedia = media;

            return result;
        }
    }
}
