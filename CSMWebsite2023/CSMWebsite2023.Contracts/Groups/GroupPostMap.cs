using AutoMapper;
using CSMWebsite2023.Contracts.Chats;
using CSMWebsite2023.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMWebsite2023.Contracts.GroupPosts
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<GroupPost, GroupPostDto>();
            CreateMap<GroupPostDto, GroupPost>();
            CreateMap<CreateDto, GroupPost>();
        }
    }
}