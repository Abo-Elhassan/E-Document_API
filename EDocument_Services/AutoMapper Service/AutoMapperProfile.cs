using AutoMapper;
using EDocument_Data.DTOs.Attachments;
using EDocument_Data.DTOs.Department;
using EDocument_Data.DTOs.Requests;
using EDocument_Data.DTOs.Requests.PoRequest;
using EDocument_Data.DTOs.Requests.RequestReviewer;
using EDocument_Data.DTOs.Section;
using EDocument_Data.DTOs.User;
using EDocument_Data.Models;
using EDocument_Services.File_Service;
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

            CreateMap<Request, RequestReadDto>();
            CreateMap<Attachment, AttachmentReadDto>()
               .ForMember(x => x.FileName, y => y.MapFrom(z => Path.GetFileName(z.FilePath)));

            //CreateMap<string, AttachmentReadDto>()
            //     .ForMember(x => x.FileName, y => y.MapFrom(z => Path.GetFileName(z)))
            //    .ForMember(x => x.FileUrl, y => y.MapFrom(z => FileService.GetFileUrl(z)));

            CreateMap<RequestReviewer, RequestReviewerReadDto>()
                .ForMember(x => x.AssignedReviewerFullName, y => y.MapFrom(z => z.Reviewer.FullName));

            CreateMap<RequestReviewer, RequestReviewerReadDto>()
              .ForMember(x => x.AssignedReviewerId, y => y.MapFrom(z => z.AssignedReviewerId));


            CreateMap<PoRequest, PoRequestReadDto>()
                .ForMember(x => x.Id, y => y.MapFrom(z => z.Request.Id))
                .ForMember(x => x.CurrentStage, y => y.MapFrom(z => z.Request.CurrentStage))
                .ForMember(x => x.Status, y => y.MapFrom(z => z.Request.Status))
                .ForMember(x => x.Justification, y => y.MapFrom(z => z.Request.Justification))
                .ForMember(x => x.CreatorId, y => y.MapFrom(z => z.Request.CreatorId))
                .ForMember(x => x.DefinedRequestId, y => y.MapFrom(z => z.Request.DefinedRequestId))
                .ForMember(x => x.Attachments, y => y.MapFrom(z => z.Request.Attachments));

             CreateMap<PoRequest, PoRequestReviewerReadDto>()
            .ForMember(x => x.Id, y => y.MapFrom(z => z.Request.Id))
            .ForMember(x => x.CurrentStage, y => y.MapFrom(z => z.Request.CurrentStage))
            .ForMember(x => x.Status, y => y.MapFrom(z => z.Request.Status))
            .ForMember(x => x.Justification, y => y.MapFrom(z => z.Request.Justification))
            .ForMember(x => x.CreatorId, y => y.MapFrom(z => z.Request.CreatorId))
            .ForMember(x => x.DefinedRequestId, y => y.MapFrom(z => z.Request.DefinedRequestId))
            .ForMember(x => x.Attachments, y => y.MapFrom(z => z.Request.Attachments))
            .ForMember(x => x.RequestReviewers, y => y.MapFrom(z => z.Request.RequestReviewers));

            CreateMap<PoRequestCreateDto, PoRequest>();
            CreateMap<PoRequestUpdateDto, PoRequest>();
            CreateMap<DefinedRequestReviewer, RequestReviewer>();
          
        }
    }
}
