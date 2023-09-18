using AutoMapper;
using EDocument_Data.DTOs.Department;
using EDocument_Data.DTOs.Section;
using EDocument_Data.DTOs.User;
using EDocument_Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDocument_Services.AutoMapper_Service
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            
            CreateMap<CreateUserDto, User>();
            CreateMap<UserWriteDto, User>();
            CreateMap<User, SearchUserDto>();
            CreateMap<User, LockedUserDto>();
            CreateMap<User, UserReadDto>()
                .ForMember(
                x => x.DepartmentName,
                y => y.MapFrom(
                    z => z.Department.DepartmentName))
                .ForMember(
                x => x.SectionName,
                y => y.MapFrom(
                    z => z.Section.SectionName))
                .ForMember(x => x.Roles, opt => opt.Ignore()).ReverseMap();
            CreateMap<Department, DepartmentReadDto>();

            CreateMap<Section, SectionReadDto>();

        }
    }
}
