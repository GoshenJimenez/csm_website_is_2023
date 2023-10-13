using AutoMapper;
using CSMWebsite2023.Contracts.Chats;
using CSMWebsite2023.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMWebsite2023.Contracts.GroupPost
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Research, GroupPostDto>();
            CreateMap<GroupPostDto, Research>();
        }
    }
}