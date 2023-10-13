using AutoMapper;
using CSMWebsite2023.Contracts.Chats;
using CSMWebsite2023.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMWebsite2023.Contracts.SchoolEvents
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<SchoolEvent, SchoolEventDto>();
            CreateMap<SchoolEventDto, SchoolEvent>();
        }
    }
}
