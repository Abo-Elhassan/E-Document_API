﻿using AutoMapper;
using EDocument_Data.Consts.Enums;
using EDocument_Data.DTOs.Attachments;
using EDocument_Data.DTOs.Department;
using EDocument_Data.DTOs.Requests;
using EDocument_Data.DTOs.Requests.PoRequest;
using EDocument_Data.DTOs.Requests.RequestReviewer;
using EDocument_Data.DTOs.Requests.TravelDeskRequest;
using EDocument_Data.DTOs.Requests.VehicleRequest;
using EDocument_Data.DTOs.Section;
using EDocument_Data.DTOs.User;
using EDocument_Data.Models;
using EDocument_Services.AutoMapper_Service.Converter;
using EDocument_Services.AutoMapper_Service.Resolvers;

namespace EDocument_Services.AutoMapper_Service
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<CreateUserDto, User>();
            CreateMap<UserWriteDto, User>();
            CreateMap<User, UserReadSearchDto>()
                .ForMember(dest => dest.Department, src => src.MapFrom(opts => opts.Department.DepartmentName))
                .ForMember(dest => dest.Section, src => src.MapFrom(opts => opts.Section.SectionName));
            CreateMap<User, LockedUserReadDto>();
            CreateMap<User, UserReadDto>()
                .ForMember( dest => dest.DepartmentName,src => src.MapFrom(opts => opts.Department.DepartmentName))
                .ForMember(  dest => dest.SectionName, src => src.MapFrom( opts => opts.Section.SectionName))
                .ForMember(dest => dest.Roles, opt => opt.Ignore()).ReverseMap();
            CreateMap<Department, DepartmentReadDto>();

            CreateMap<Section, SectionReadDto>();

            CreateMap<RequestStatus, string>()
                .ConvertUsing(src => Enum.GetName(typeof(RequestStatus), src));
            CreateMap<string, RequestStatus>()
                .ConvertUsing(src => Enum.Parse<RequestStatus>(src));



            CreateMap<Request, RequestReadDto>();
            CreateMap<Attachment, AttachmentReadDto>()
               .ForMember(dest => dest.FileName, src => src.MapFrom(opts => Path.GetFileName(opts.FilePath)))
               .ForMember(dest => dest.FileUrl, src => src.MapFrom<AttachmentUrlResolver>());

            CreateMap<string, AttachmentReadDto>()
                 .ForMember(dest => dest.FileName, src => src.MapFrom(opts => Path.GetFileName(opts)))
                .ForMember(dest => dest.FileUrl, src => src.MapFrom<PathToUrlResolver>());

            CreateMap<RequestReviewer, RequestReviewerReadDto>()
                .ForMember(dest => dest.AssignedReviewerFullName, src => src.MapFrom(opts => opts.Reviewer.FullName));

            CreateMap<RequestReviewer, RequestReviewerReadDto>()
              .ForMember(dest => dest.AssignedReviewerId, src => src.MapFrom(opts => opts.AssignedReviewerId));
            CreateMap<DefinedRequestReviewer, RequestReviewer>()
              .ForMember(dest => dest.RequestId, src => src.Ignore())
              .ForMember(dest => dest.Status, src => src.MapFrom(opts => RequestStatus.Pending.ToString()));

            CreateMap<PoRequest, PoRequestReadDto>()
                .ForMember(dest => dest.Id, src => src.MapFrom(opts => opts.Request.Id))
                .ForMember(dest => dest.CurrentStage, src => src.MapFrom(opts => opts.Request.CurrentStage))
                .ForMember(dest => dest.Status, src => src.MapFrom(opts => opts.Request.Status))
                .ForMember(dest => dest.Remarks, src => src.MapFrom(opts => opts.Request.Justification))
                .ForMember(dest => dest.CreatorId, src => src.MapFrom(opts => opts.Request.CreatorId))
                .ForMember(dest => dest.DefinedRequestId, src => src.MapFrom(opts => opts.Request.DefinedRequestId))
                .ForMember(dest => dest.InvoiceAttachment, src => src.MapFrom(opts => new AttachmentReadDto { FileName = Path.GetFileName(opts.InvoiceAttachmentPath) }))
                .ForMember(dest => dest.PoAttachment, src => src.MapFrom(opts => new AttachmentReadDto { FileName = Path.GetFileName(opts.PoAttachmentPath) }))
                .ForMember(dest => dest.Attachments, src => src.MapFrom(opts => opts.Request.Attachments));

            CreateMap<PoRequest, PoRequestReviewerReadDto>()
           .ForMember(dest => dest.Id, src => src.MapFrom(opts => opts.Request.Id))
           .ForMember(dest => dest.CurrentStage, src => src.MapFrom(opts => opts.Request.CurrentStage))
           .ForMember(dest => dest.Status, src => src.MapFrom(opts => opts.Request.Status))
           .ForMember(dest => dest.Remarks, src => src.MapFrom(opts => opts.Request.Justification))
           .ForMember(dest => dest.CreatorId, src => src.MapFrom(opts => opts.Request.CreatorId))
           .ForMember(dest => dest.DefinedRequestId, src => src.MapFrom(opts => opts.Request.DefinedRequestId))
           .ForMember(dest => dest.InvoiceAttachment, src => src.MapFrom(opts => new AttachmentReadDto { FileName = Path.GetFileName(opts.InvoiceAttachmentPath) }))
           .ForMember(dest => dest.PoAttachment, src => src.MapFrom(opts => new AttachmentReadDto { FileName = Path.GetFileName(opts.PoAttachmentPath) }))
           .ForMember(dest => dest.Attachments, src => src.MapFrom(opts => opts.Request.Attachments))
           .ForMember(dest => dest.RequestReviewers, src => src.MapFrom(opts => opts.Request.RequestReviewers));

            CreateMap<PoRequestCreateDto, PoRequest>();
            CreateMap<PoRequestUpdateDto, Request>()
                .ForMember(dest => dest.Attachments, src => src.Ignore())
                .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            CreateMap<PoRequestUpdateDto, PoRequest>()
                .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));




            CreateMap<VehicleRequest, VehicleRequestReadDto>()
                .ForMember(dest => dest.Id, src => src.MapFrom(opts => opts.Request.Id))
                .ForMember(dest => dest.CurrentStage, src => src.MapFrom(opts => opts.Request.CurrentStage))
                .ForMember(dest => dest.Status, src => src.MapFrom(opts => opts.Request.Status))
                .ForMember(dest => dest.Justification, src => src.MapFrom(opts => opts.Request.Justification))
                .ForMember(dest => dest.CreatorId, src => src.MapFrom(opts => opts.Request.CreatorId))
                .ForMember(dest => dest.DefinedRequestId, src => src.MapFrom(opts => opts.Request.DefinedRequestId))
                .ForMember(dest => dest.Attachments, src => src.MapFrom(opts => opts.Request.Attachments));

            CreateMap<VehicleRequest, VehicleRequestReviewerReadDto>()
                .ForMember(dest => dest.Id, src => src.MapFrom(opts => opts.Request.Id))
                .ForMember(dest => dest.CurrentStage, src => src.MapFrom(opts => opts.Request.CurrentStage))
                .ForMember(dest => dest.Status, src => src.MapFrom(opts => opts.Request.Status))
                .ForMember(dest => dest.Justification, src => src.MapFrom(opts => opts.Request.Justification))
                .ForMember(dest => dest.CreatorId, src => src.MapFrom(opts => opts.Request.CreatorId))
                .ForMember(dest => dest.DefinedRequestId, src => src.MapFrom(opts => opts.Request.DefinedRequestId))
                .ForMember(dest => dest.Attachments, src => src.MapFrom(opts => opts.Request.Attachments))
                .ForMember(dest => dest.RequestReviewers, src => src.MapFrom(opts => opts.Request.RequestReviewers));

            CreateMap<VehicleRequestCreateDto, VehicleRequest>();
            CreateMap<VehicleRequestUpdateDto, Request>()
                .ForMember(dest => dest.Attachments, src => src.Ignore())
                .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            CreateMap<VehicleRequestUpdateDto, VehicleRequest>()
                .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<User, VehicleRequest>()
                .ForMember(dest => dest.BeneficiaryId, src => src.MapFrom(opts => opts.Id))
                .ForMember(dest => dest.BeneficiaryName, src => src.MapFrom(opts => opts.FullName))
                .ForMember(dest => dest.BeneficiaryEmail, src => src.MapFrom(opts => opts.Email))
                .ForMember(dest => dest.BeneficiaryPosition, src => src.MapFrom(opts => opts.Position))
                .ForMember(dest => dest.BeneficiaryDepartment, src => src.MapFrom(opts => opts.Department.DepartmentName))
                .ForMember(dest => dest.BeneficiaryPhoneNumber, src => src.MapFrom(opts => opts.PhoneNumber));


            CreateMap<User, TravelDeskRequest>()
                .ForMember(dest => dest.BeneficiaryId, src => src.MapFrom(opts => opts.Id))
                .ForMember(dest => dest.BeneficiaryName, src => src.MapFrom(opts => opts.FullName))
                .ForMember(dest => dest.BeneficiaryEmail, src => src.MapFrom(opts => opts.Email))
                .ForMember(dest => dest.BeneficiaryPosition, src => src.MapFrom(opts => opts.Position))
                .ForMember(dest => dest.BeneficiaryDepartment, src => src.MapFrom(opts => opts.Department.DepartmentName))
                .ForMember(dest => dest.BeneficiaryPhoneNumber, src => src.MapFrom(opts => opts.PhoneNumber));



            CreateMap<List<TravelDeskRequisition>, string>()
                .ConvertUsing(src => string.Join(",", src.Select(item => item.ToString())));

            CreateMap<string, List<TravelDeskRequisition>>()
              .ConvertUsing<StringToTravelDeskRequisitionListConverter>();

            CreateMap<Currency, string>()
                .ConvertUsing(src => Enum.GetName(typeof(Currency), src));
            CreateMap<string, Currency>()
                .ConvertUsing(src => Enum.Parse<Currency>(src));


            CreateMap<PaymentMethod, string>()
                .ConvertUsing(src => Enum.GetName(typeof(PaymentMethod), src));
            CreateMap<string, PaymentMethod>()
                .ConvertUsing(src => Enum.Parse<PaymentMethod>(src));



            CreateMap<TravelDeskRequest, TravelDeskRequestReadDto>()
                .ForMember(dest => dest.Id, src => src.MapFrom(opts => opts.Request.Id))
                .ForMember(dest => dest.CurrentStage, src => src.MapFrom(opts => opts.Request.CurrentStage))
                .ForMember(dest => dest.Status, src => src.MapFrom(opts => opts.Request.Status))
                .ForMember(dest => dest.Justification, src => src.MapFrom(opts => opts.Request.Justification))
                .ForMember(dest => dest.CreatorId, src => src.MapFrom(opts => opts.Request.CreatorId))
                .ForMember(dest => dest.DefinedRequestId, src => src.MapFrom(opts => opts.Request.DefinedRequestId))
                .ForMember(dest => dest.Attachments, src => src.MapFrom(opts => opts.Request.Attachments));

            CreateMap<TravelDeskRequest, TravelDeskRequestReviewerReadDto>()
                .ForMember(dest => dest.Id, src => src.MapFrom(opts => opts.Request.Id))
                .ForMember(dest => dest.CurrentStage, src => src.MapFrom(opts => opts.Request.CurrentStage))
                .ForMember(dest => dest.Status, src => src.MapFrom(opts => opts.Request.Status))
                .ForMember(dest => dest.Justification, src => src.MapFrom(opts => opts.Request.Justification))
                .ForMember(dest => dest.CreatorId, src => src.MapFrom(opts => opts.Request.CreatorId))
                .ForMember(dest => dest.DefinedRequestId, src => src.MapFrom(opts => opts.Request.DefinedRequestId))
                .ForMember(dest => dest.Attachments, src => src.MapFrom(opts => opts.Request.Attachments))
                .ForMember(dest => dest.RequestReviewers, src => src.MapFrom(opts => opts.Request.RequestReviewers));

            CreateMap<TravelDeskRequestCreateDto, TravelDeskRequest>();
            CreateMap<TravelDeskRequestUpdateDto, Request>()
                .ForMember(dest => dest.Attachments, src => src.Ignore())
                .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            CreateMap<TravelDeskRequestUpdateDto, TravelDeskRequest>()
                .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
        }
    }
}