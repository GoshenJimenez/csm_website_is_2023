using AutoMapper;
using CSMWebsite2023.Contracts;
using CSMWebsite2023.Contracts.GroupPosts;
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
    public class GroupPostService : BaseService, IGroupPostService
    {
        private readonly IRepository<GroupPost> _grouppostRepository;
        private readonly IRepository<GroupPostMedium> _grouppostMediumRepository;
        public GroupPostService(IConfiguration configuration, ILogger<BaseService> logger, IMapper mapper,
              IRepository<GroupPost> grouppostRepository,
              IRepository<GroupPostMedium> grouppostMediumRepository
            )
            : base(configuration, logger, mapper)
        {
            _grouppostRepository = grouppostRepository;
            _grouppostMediumRepository = grouppostMediumRepository;
        }
        public GroupPostDto? GetGroupPostById(Guid? id)
        {
            var query = _grouppostRepository.All()
                         .FirstOrDefault(a => a.Id == id);

            var result = Mapper.Map<GroupPostDto>(query);

            var image = _grouppostMediumRepository.All().Where(a => a.GroupPostId == id && a.MediaType == Data.Enums.MediaType.ImageUrl).FirstOrDefault();

            if (image != null)
            {
                result.ArticleImage = image.Value;
            }

            return result;
        }

        public List<GroupPostDto>? GetGroupPost()
        {
            var query = _grouppostRepository.All();

            return Mapper.Map<List<GroupPostDto>>(query);

        }

        public async Task<CreateDto>? Create(CreateDto? dto)
        {
            await _grouppostRepository.AddAsync(new GroupPost()
            {
                Id = Guid.NewGuid(),
                GroupId = dto!.GroupId,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                Title = dto.Title,
                Description = dto.Description,
            });
            await _grouppostRepository.SaveChangesAsync();
            return dto;

        }

        Task<OperationDto<GroupPostDto>>? IGroupPostService.Create(CreateDto? dto)
        {
            throw new NotImplementedException();
        }

        public Task<OperationDto<GroupPostDto>>? Update(UpdateDto? dto)
        {
            throw new NotImplementedException();
        }

        public Task<OperationDto<GroupPostDto>>? Delete(ActivationDto? dto)
        {
            throw new NotImplementedException();
        }

        public Task<OperationDto<GroupPostDto>>? Restore(ActivationDto? dto)
        {
            throw new NotImplementedException();
        }

        public Task<Paged<GroupPostDto>>? Posts(bool? isActive = true, int? pageIndex = 1, int? pageSize = 10, string? keyword = "")
        {
            throw new NotImplementedException();
        }
    }
}
