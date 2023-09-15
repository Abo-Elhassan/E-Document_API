using AutoMapper;
using EDocument_Data.DTOs.User;
using EDocument_Data.Models;
using EDocument_Data.ViewModels;
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
            CreateMap<RegisterUserDto, User>();
           

        }
    }
}
