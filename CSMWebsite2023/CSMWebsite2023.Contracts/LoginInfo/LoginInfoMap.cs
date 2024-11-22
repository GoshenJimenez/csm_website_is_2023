using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CSMWebsite2023.Data.Models;

namespace CSMWebsite2023.Contracts.LoginInfo
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<CSMWebsite2023.Data.Models.LoginInfo, LoginInfoDto>();
            CreateMap<LoginInfoDto, CSMWebsite2023.Data.Models.LoginInfo>();
        }
    }
}
