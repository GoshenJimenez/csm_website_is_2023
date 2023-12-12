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
        private readonly IRepository<GroupPost> _groupPostRepository;
        private readonly IRepository<GroupPostMedium> _groupPostMediumRepository;
        public GroupPostService(IConfiguration configuration, ILogger<BaseService> logger, IMapper mapper,
              IRepository<GroupPost> groupPostRepository,
              IRepository<GroupPostMedium> groupPostMediumRepository
            )
            : base(configuration, logger, mapper)
        {
            _groupPostRepository = groupPostRepository;
            _groupPostMediumRepository = groupPostMediumRepository;
        }
        public async Task<OperationDto<GroupPostDto>>? Create(CreateDto? dto)
        {
            try
            {

                var groupPost = new GroupPost()
                {
                    Id = dto!.Id != null ? dto.Id : Guid.NewGuid(),
                    Description = dto!.Description,
                    Title = dto!.Title,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    IsActive = true
                };
                var thumbnailGroupPostMedium = new GroupPostMedium()
                {
                    Id = Guid.NewGuid(),
                    GroupPostId = groupPost.Id,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    MediaType = Data.Enums.MediaType.Thumbnail,
                    Value = $"//groupPost//{groupPost.Id}//thumbnail.png"

                };
                var galleryImageGroupPostMedium = new GroupPostMedium()
                {
                    Id = Guid.NewGuid(),
                    GroupPostId = groupPost.Id,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    MediaType = Data.Enums.MediaType.GalleryImage,
                    Value = $"//groupPost//{groupPost.Id}//gallery-image.png"

                };
                var articleImageGroupPostMedium = new GroupPostMedium()
                {
                    Id = Guid.NewGuid(),
                    GroupPostId = groupPost.Id,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    MediaType = Data.Enums.MediaType.ArticleImage,
                    Value = $"//groupPost//{groupPost.Id}//article-image.png"

                };

                await _groupPostMediumRepository.AddAsync(thumbnailGroupPostMedium);
                await _groupPostMediumRepository.AddAsync(galleryImageGroupPostMedium);
                await _groupPostMediumRepository.AddAsync(articleImageGroupPostMedium);

                await _groupPostRepository.SaveChangesAsync();
                await _groupPostRepository.AddAsync(groupPost);

                return new OperationDto<GroupPostDto>()
                {
                    ReferenceId = groupPost.Id,
                    ReferenceData = Mapper.Map<GroupPostDto>(groupPost),
                    Status = OpStatus.Ok,
                    Message = "Success"
                };
            }
            catch (Exception ex)
            {
                return new OperationDto<GroupPostDto>()
                {
                    Status = OpStatus.Fail,
                    Message = ex.Message
                };
            }

            public async Task<OperationDto<GroupPostDto>>? Update(UpdateDto? dto)
            {
                try
                {
                    var groupPost = _groupPostRepository.All().FirstOrDefault(a => a.Id == dto.Id);

                    if (groupPost != null)
                    {
                        groupPost.Description = dto!.Description;
                        groupPost.Title = dto!.Title;
                        groupPost.UpdatedAt = DateTime.Now;

                        _groupPostRepository.Update(groupPost);
                    }

                    await _groupPostRepository.SaveChangesAsync();

                    return new OperationDto<GroupPostDto>()
                    {
                        ReferenceId = groupPost.Id,
                        ReferenceData = Mapper.Map<GroupPostDto>(groupPost),
                        Status = OpStatus.Ok,
                        Message = "Success"
                    };
                }
                catch (Exception ex)
                {
                    return new OperationDto<GroupPostDto>()
                    {
                        Status = OpStatus.Fail,
                        Message = ex.Message
                    };
                }
            }

            public async Task<OperationDto<GroupPostDto>>? Delete(ActivationDto? dto)
            {
                try
                {
                    if (dto == null)
                    {
                        return new OperationDto<GroupPostDto>()
                        {
                            Status = OpStatus.Fail,
                            Message = "dto is null"
                        };
                    }

                    var groupPost = _groupPostRepository.All().FirstOrDefault(a => a.Id == dto.Id);

                    if (groupPost != null)
                    {
                        groupPost.IsActive = false;
                        groupPost.UpdatedAt = DateTime.Now;

                        _groupPostRepository.Update(groupPost);
                    }

                    await _groupPostRepository.SaveChangesAsync();

                    return new OperationDto<GroupPostDto>()
                    {
                        ReferenceId = groupPost.Id,
                        ReferenceData = Mapper.Map<GroupPostDto>(groupPost),
                        Status = OpStatus.Ok,
                        Message = "Success"
                    };
                }
                catch (Exception ex)
                {
                    return new OperationDto<GroupPostDto>()
                    {
                        Status = OpStatus.Fail,
                        Message = ex.Message
                    };
                }
            }

            public async Task<OperationDto<GroupPostDto>>? Restore(ActivationDto? dto)
            {
                try
                {
                    if (dto == null)
                    {
                        return new OperationDto<GroupPostDto>()
                        {
                            Status = OpStatus.Fail,
                            Message = "dto is null"
                        };
                    }

                    var groupPost = _groupPostRepository.All().FirstOrDefault(a => a.Id == dto.Id);

                    if (groupPost != null)
                    {
                        groupPost.IsActive = true;
                        groupPost.UpdatedAt = DateTime.Now;

                        _groupPostRepository.Update(groupPost);
                    }

                    await _groupPostRepository.SaveChangesAsync();

                    return new OperationDto<GroupPostDto>()
                    {
                        ReferenceId = groupPost.Id,
                        ReferenceData = Mapper.Map<GroupPostDto>(groupPost),
                        Status = OpStatus.Ok,
                        Message = "Success"
                    };
                }
                catch (Exception ex)
                {
                    return new OperationDto<GroupPostDto>()
                    {
                        Status = OpStatus.Fail,
                        Message = ex.Message
                    };
                }
            }
        }
    }
}