using AutoMapper;
using CSMWebsite2023.Contracts.Chats;
using CSMWebsite2023.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMWebsite2023.Contracts.SchoolPosts
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<SchoolPost, SchoolPostDto>();
            CreateMap<SchoolPostDto, SchoolPost>();
        }
    }
}
