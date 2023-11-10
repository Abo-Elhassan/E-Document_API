using AutoMapper;
using EDocument_Data.Consts.Enums;
using EDocument_Data.DTOs.Attachments;
using EDocument_Data.DTOs.DefinedRequest;
using EDocument_Data.DTOs.DefinedRequestReviewer;
using EDocument_Data.DTOs.DefinedRequestRole;
using EDocument_Data.DTOs.Department;
using EDocument_Data.DTOs.Requests;
using EDocument_Data.DTOs.Requests.AccessControlRequest;
using EDocument_Data.DTOs.Requests.CCTVAccessRequest;
using EDocument_Data.DTOs.Requests.DiscountRequest;
using EDocument_Data.DTOs.Requests.FuelOilInvoiceRequest;
using EDocument_Data.DTOs.Requests.PoRequest;
using EDocument_Data.DTOs.Requests.RefundRequest;
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
                .ForMember(dest => dest.DepartmentName, src => src.MapFrom(opts => opts.Department.DepartmentName))
                .ForMember(dest => dest.SectionName, src => src.MapFrom(opts => opts.Section.SectionName))
                .ForMember(dest => dest.Roles, opt => opt.Ignore()).ReverseMap();


            CreateMap<Department, DepartmentReadDto>();

            CreateMap<Section, SectionReadDto>();

            CreateMap<RequestStatus, string>()
                .ConvertUsing(src => Enum.GetName(typeof(RequestStatus), src));
            CreateMap<string, RequestStatus>()
                .ConvertUsing(src => Enum.Parse<RequestStatus>(src));


            CreateMap<DefinedRequestCreateDto, DefinedRequest>();
            CreateMap<DefinedRequestUpdateDto, DefinedRequest>()
                .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            CreateMap<DefinedRequest, DefinedRequestReadDto>()
                 .ForMember(dest => dest.DepartmentName, src => src.MapFrom(opts => opts.Department.DepartmentName));

            CreateMap<DefinedRequestRoleCreateDto, DefinedRequestRole>();
            CreateMap<DefinedRequestRoleUpdateDto, DefinedRequestRole>()
                .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            CreateMap<DefinedRequestRole, DefinedRequestRoleReadDto>()
             .ForMember(dest => dest.RoleName, src => src.MapFrom(opts => opts.Role.Name));



            CreateMap<DefinedRequestReviewerCreateDto, DefinedRequestReviewer>();
            CreateMap<DefinedRequestReviewerUpdateDto, DefinedRequestReviewer>()
                .ForMember(dest => dest.Key, src => src.Ignore())
                .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            CreateMap<DefinedRequestReviewer, DefinedRequestReviewerReadDto>();


            CreateMap<DefinedRequestReviewer, RequestReviewer>()
                .ForMember(dest => dest.Key, src => src.Ignore())
                .ForMember(dest => dest.RequestId, src => src.Ignore())
                .ForMember(dest => dest.Status, src => src.MapFrom(opts => RequestStatus.None.ToString()))
                .ForMember(dest => dest.CreatedAt, src => src.Ignore())
                .ForMember(dest => dest.ModifiedAt, src => src.Ignore())
                .ForMember(dest => dest.CreatedBy, src => src.Ignore())
                .ForMember(dest => dest.ModifiedBy, src => src.Ignore());

            CreateMap<RequestReviewer, RequestReviewerReadDto>()
                .ForMember(dest => dest.AssignedReviewerFullName, src => src.MapFrom(opts => opts.Reviewer.FullName))
                .ForMember(dest => dest.AssignedReviewerId, src => src.MapFrom(opts => opts.AssignedReviewerId));


            CreateMap<Attachment, AttachmentReadDto>()
               .ForMember(dest => dest.FileName, src => src.MapFrom(opts => Path.GetFileName(opts.FilePath)))
               .ForMember(dest => dest.FileUrl, src => src.MapFrom<AttachmentUrlResolver>());
            CreateMap<string, AttachmentReadDto>()
                 .ForMember(dest => dest.FileName, src => src.MapFrom(opts => Path.GetFileName(opts)))
                .ForMember(dest => dest.FileUrl, src => src.MapFrom<PathToUrlResolver>());


            CreateMap<Request, RecentRequestReadDto>()
                .ForMember(dest => dest.RequestName, src => src.MapFrom(opts => opts.DefinedRequest.RequestName))
                .ForMember(dest => dest.NumberOfStages, src => src.MapFrom(opts => opts.DefinedRequest.ReviewersNumber));
            #region Po Reuqest
            CreateMap<PoRequest, PoRequestReadDto>()
             .ForMember(dest => dest.Id, src => src.MapFrom(opts => opts.Request.Id))
             .ForMember(dest => dest.CurrentStage, src => src.MapFrom(opts => opts.Request.CurrentStage))
             .ForMember(dest => dest.Status, src => src.MapFrom(opts => opts.Request.Status))
             .ForMember(dest => dest.Remarks, src => src.MapFrom(opts => opts.Request.Notes))
             .ForMember(dest => dest.CreatorId, src => src.MapFrom(opts => opts.Request.CreatorId))
             .ForMember(dest => dest.DefinedRequestId, src => src.MapFrom(opts => opts.Request.DefinedRequestId))
             .ForMember(dest => dest.InvoiceAttachment, src => src.MapFrom(opts => new AttachmentReadDto { FileName = Path.GetFileName(opts.InvoiceAttachmentPath) }))
             .ForMember(dest => dest.PoAttachment, src => src.MapFrom(opts => new AttachmentReadDto { FileName = Path.GetFileName(opts.PoAttachmentPath) }))
             .ForMember(dest => dest.Attachments, src => src.MapFrom(opts => opts.Request.Attachments));



            CreateMap<PoRequest, PoRequestReviewerReadDto>()
           .ForMember(dest => dest.Id, src => src.MapFrom(opts => opts.Request.Id))
           .ForMember(dest => dest.CurrentStage, src => src.MapFrom(opts => opts.Request.CurrentStage))
           .ForMember(dest => dest.Status, src => src.MapFrom(opts => opts.Request.Status))
           .ForMember(dest => dest.Remarks, src => src.MapFrom(opts => opts.Request.Notes))
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
            #endregion

            #region Vehicle Request
            CreateMap<VehicleRequest, VehicleRequestReadDto>()
            .ForMember(dest => dest.Id, src => src.MapFrom(opts => opts.Request.Id))
            .ForMember(dest => dest.CurrentStage, src => src.MapFrom(opts => opts.Request.CurrentStage))
            .ForMember(dest => dest.Status, src => src.MapFrom(opts => opts.Request.Status))
            .ForMember(dest => dest.Justification, src => src.MapFrom(opts => opts.Request.Notes))
            .ForMember(dest => dest.CreatorId, src => src.MapFrom(opts => opts.Request.CreatorId))
            .ForMember(dest => dest.DefinedRequestId, src => src.MapFrom(opts => opts.Request.DefinedRequestId))
            .ForMember(dest => dest.Attachments, src => src.MapFrom(opts => opts.Request.Attachments));



            CreateMap<VehicleRequest, VehicleRequestReviewerReadDto>()
                .ForMember(dest => dest.Id, src => src.MapFrom(opts => opts.Request.Id))
                .ForMember(dest => dest.CurrentStage, src => src.MapFrom(opts => opts.Request.CurrentStage))
                .ForMember(dest => dest.Status, src => src.MapFrom(opts => opts.Request.Status))
                .ForMember(dest => dest.Justification, src => src.MapFrom(opts => opts.Request.Notes))
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
                .ForMember(dest => dest.BeneficiaryPhoneNumber, src => src.MapFrom(opts => opts.PhoneNumber))
                .ForMember(dest => dest.BeneficiaryCompany, src => src.MapFrom(opts => opts.Company))
                .ForMember(dest => dest.CreatedAt, src => src.Ignore())
                .ForMember(dest => dest.ModifiedAt, src => src.Ignore())
                .ForMember(dest => dest.CreatedBy, src => src.Ignore())
                .ForMember(dest => dest.ModifiedBy, src => src.Ignore());
            #endregion

            #region Travel Desk Request
            CreateMap<User, TravelDeskRequest>()
            .ForMember(dest => dest.BeneficiaryId, src => src.MapFrom(opts => opts.Id))
            .ForMember(dest => dest.BeneficiaryName, src => src.MapFrom(opts => opts.FullName))
            .ForMember(dest => dest.BeneficiaryEmail, src => src.MapFrom(opts => opts.Email))
            .ForMember(dest => dest.BeneficiaryPosition, src => src.MapFrom(opts => opts.Position))
            .ForMember(dest => dest.BeneficiaryDepartment, src => src.MapFrom(opts => opts.Department.DepartmentName))
            .ForMember(dest => dest.BeneficiaryPhoneNumber, src => src.MapFrom(opts => opts.PhoneNumber))
            .ForMember(dest => dest.BeneficiaryCompany, src => src.MapFrom(opts => opts.Company))
            .ForMember(dest => dest.CreatedAt, src => src.Ignore())
            .ForMember(dest => dest.ModifiedAt, src => src.Ignore())
            .ForMember(dest => dest.CreatedBy, src => src.Ignore())
            .ForMember(dest => dest.ModifiedBy, src => src.Ignore());

            CreateMap<string, List<TravelDeskRequisition>>()
              .ConvertUsing<StringToTravelDeskRequisitionListConverter>();



            CreateMap<PaymentMethod, string>()
                .ConvertUsing(src => Enum.GetName(typeof(PaymentMethod), src));
            CreateMap<string, PaymentMethod>()
                .ConvertUsing(src => Enum.Parse<PaymentMethod>(src));





            CreateMap<TravelDeskRequest, TravelDeskRequestEditReadDto>()
                .ForMember(dest => dest.Id, src => src.MapFrom(opts => opts.Request.Id))
                .ForMember(dest => dest.CurrentStage, src => src.MapFrom(opts => opts.Request.CurrentStage))
                .ForMember(dest => dest.Status, src => src.MapFrom(opts => opts.Request.Status))
                .ForMember(dest => dest.Justification, src => src.MapFrom(opts => opts.Request.Notes))
                .ForMember(dest => dest.CreatorId, src => src.MapFrom(opts => opts.Request.CreatorId))
                .ForMember(dest => dest.DefinedRequestId, src => src.MapFrom(opts => opts.Request.DefinedRequestId))
                .ForMember(dest => dest.Attachments, src => src.MapFrom(opts => opts.Request.Attachments));



            CreateMap<TravelDeskRequest, TravelDeskRequestDetailsReadDto>()
                .ForMember(dest => dest.Id, src => src.MapFrom(opts => opts.Request.Id))
                .ForMember(dest => dest.CurrentStage, src => src.MapFrom(opts => opts.Request.CurrentStage))
                .ForMember(dest => dest.Status, src => src.MapFrom(opts => opts.Request.Status))
                .ForMember(dest => dest.Justification, src => src.MapFrom(opts => opts.Request.Notes))
                .ForMember(dest => dest.CreatorId, src => src.MapFrom(opts => opts.Request.CreatorId))
                .ForMember(dest => dest.DefinedRequestId, src => src.MapFrom(opts => opts.Request.DefinedRequestId))
                .ForMember(dest => dest.Attachments, src => src.MapFrom(opts => opts.Request.Attachments));



            CreateMap<TravelDeskRequest, TravelDeskRequestReviewerReadDto>()
                .ForMember(dest => dest.Id, src => src.MapFrom(opts => opts.Request.Id))
                .ForMember(dest => dest.CurrentStage, src => src.MapFrom(opts => opts.Request.CurrentStage))
                .ForMember(dest => dest.Status, src => src.MapFrom(opts => opts.Request.Status))
                .ForMember(dest => dest.Justification, src => src.MapFrom(opts => opts.Request.Notes))
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
            #endregion

            #region Refund Reuqest
            CreateMap<ApproveRefundRequestDto, ApproveRequestReviewerDto>();

            CreateMap<RefundRequest, RefundRequestReadDto>()
           .ForMember(dest => dest.Id, src => src.MapFrom(opts => opts.Request.Id))
           .ForMember(dest => dest.CurrentStage, src => src.MapFrom(opts => opts.Request.CurrentStage))
           .ForMember(dest => dest.Status, src => src.MapFrom(opts => opts.Request.Status))
           .ForMember(dest => dest.Notes, src => src.MapFrom(opts => opts.Request.Notes))
           .ForMember(dest => dest.CreatorId, src => src.MapFrom(opts => opts.Request.CreatorId))
           .ForMember(dest => dest.DefinedRequestId, src => src.MapFrom(opts => opts.Request.DefinedRequestId))
           .ForMember(dest => dest.Attachments, src => src.MapFrom(opts => opts.Request.Attachments));



            CreateMap<RefundRequest, RefundRequestReviewerReadDto>()
           .ForMember(dest => dest.Id, src => src.MapFrom(opts => opts.Request.Id))
           .ForMember(dest => dest.CurrentStage, src => src.MapFrom(opts => opts.Request.CurrentStage))
           .ForMember(dest => dest.Status, src => src.MapFrom(opts => opts.Request.Status))
           .ForMember(dest => dest.Notes, src => src.MapFrom(opts => opts.Request.Notes))
           .ForMember(dest => dest.CreatorId, src => src.MapFrom(opts => opts.Request.CreatorId))
           .ForMember(dest => dest.DefinedRequestId, src => src.MapFrom(opts => opts.Request.DefinedRequestId))
           .ForMember(dest => dest.Attachments, src => src.MapFrom(opts => opts.Request.Attachments))
           .ForMember(dest => dest.RequestReviewers, src => src.MapFrom(opts => opts.Request.RequestReviewers));

            CreateMap<RefundRequestCreateDto, RefundRequest>();

            CreateMap<RefundRequestUpdateDto, Request>()
                .ForMember(dest => dest.Attachments, src => src.Ignore())
                .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            CreateMap<RefundRequestUpdateDto, RefundRequest>()
                .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            #endregion

            #region Discount Request
            CreateMap<DiscountRequest, DiscountRequestReadDto>()
              .ForMember(dest => dest.Id, src => src.MapFrom(opts => opts.Request.Id))
              .ForMember(dest => dest.CurrentStage, src => src.MapFrom(opts => opts.Request.CurrentStage))
              .ForMember(dest => dest.Status, src => src.MapFrom(opts => opts.Request.Status))
              .ForMember(dest => dest.Notes, src => src.MapFrom(opts => opts.Request.Notes))
              .ForMember(dest => dest.CreatorId, src => src.MapFrom(opts => opts.Request.CreatorId))
              .ForMember(dest => dest.DefinedRequestId, src => src.MapFrom(opts => opts.Request.DefinedRequestId))
              .ForMember(dest => dest.Attachments, src => src.MapFrom(opts => opts.Request.Attachments));



            CreateMap<DiscountRequest, DiscountRequestReviewerReadDto>()
                .ForMember(dest => dest.Id, src => src.MapFrom(opts => opts.Request.Id))
                .ForMember(dest => dest.CurrentStage, src => src.MapFrom(opts => opts.Request.CurrentStage))
                .ForMember(dest => dest.Status, src => src.MapFrom(opts => opts.Request.Status))
                .ForMember(dest => dest.Notes, src => src.MapFrom(opts => opts.Request.Notes))
                .ForMember(dest => dest.CreatorId, src => src.MapFrom(opts => opts.Request.CreatorId))
                .ForMember(dest => dest.DefinedRequestId, src => src.MapFrom(opts => opts.Request.DefinedRequestId))
                .ForMember(dest => dest.Attachments, src => src.MapFrom(opts => opts.Request.Attachments))
                .ForMember(dest => dest.RequestReviewers, src => src.MapFrom(opts => opts.Request.RequestReviewers));



            CreateMap<DiscountRequestCreateDto, DiscountRequest>();


            CreateMap<DiscountRequestUpdateDto, Request>()
                .ForMember(dest => dest.Attachments, src => src.Ignore())
                .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            CreateMap<DiscountRequestUpdateDto, DiscountRequest>()
               .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            #endregion

            #region Access Control Request

            CreateMap<User, AccessControlRequest>()
            .ForMember(dest => dest.BeneficiaryId, src => src.MapFrom(opts => opts.Id))
            .ForMember(dest => dest.BeneficiaryName, src => src.MapFrom(opts => opts.FullName))
            .ForMember(dest => dest.BeneficiaryEmail, src => src.MapFrom(opts => opts.Email))
            .ForMember(dest => dest.BeneficiaryPosition, src => src.MapFrom(opts => opts.Position))
            .ForMember(dest => dest.BeneficiaryDepartment, src => src.MapFrom(opts => opts.Department.DepartmentName))
            .ForMember(dest => dest.BeneficiaryPhoneNumber, src => src.MapFrom(opts => opts.PhoneNumber))
            .ForMember(dest => dest.BeneficiaryCompany, src => src.MapFrom(opts => opts.Company))
            .ForMember(dest => dest.CreatedAt, src => src.Ignore())
            .ForMember(dest => dest.ModifiedAt, src => src.Ignore())
            .ForMember(dest => dest.CreatedBy, src => src.Ignore())
            .ForMember(dest => dest.ModifiedBy, src => src.Ignore());





            CreateMap<AccessControlRequest, AccessControlRequestEditReadDto>()
                .ForMember(dest => dest.Id, src => src.MapFrom(opts => opts.Request.Id))
                .ForMember(dest => dest.CurrentStage, src => src.MapFrom(opts => opts.Request.CurrentStage))
                .ForMember(dest => dest.Status, src => src.MapFrom(opts => opts.Request.Status))
                .ForMember(dest => dest.Notes, src => src.MapFrom(opts => opts.Request.Notes))
                .ForMember(dest => dest.CreatorId, src => src.MapFrom(opts => opts.Request.CreatorId))
                .ForMember(dest => dest.DefinedRequestId, src => src.MapFrom(opts => opts.Request.DefinedRequestId))
                .ForMember(dest => dest.AccessedBlocks, opt => opt.MapFrom(src => ConvertStringToList(src.AccessedBlocks)))
                .ForMember(dest => dest.AccessMethods, opt => opt.MapFrom(src => ConvertStringToList(src.AccessMethods)));



            CreateMap<AccessControlRequest, AccessControlRequestDetailsReadDto>()
                .ForMember(dest => dest.Id, src => src.MapFrom(opts => opts.Request.Id))
                .ForMember(dest => dest.CurrentStage, src => src.MapFrom(opts => opts.Request.CurrentStage))
                .ForMember(dest => dest.Status, src => src.MapFrom(opts => opts.Request.Status))
                .ForMember(dest => dest.Notes, src => src.MapFrom(opts => opts.Request.Notes))
                .ForMember(dest => dest.CreatorId, src => src.MapFrom(opts => opts.Request.CreatorId))
                .ForMember(dest => dest.DefinedRequestId, src => src.MapFrom(opts => opts.Request.DefinedRequestId));



            CreateMap<AccessControlRequest, AccessControlRequestReviewerReadDto>()
                .ForMember(dest => dest.Id, src => src.MapFrom(opts => opts.Request.Id))
                .ForMember(dest => dest.CurrentStage, src => src.MapFrom(opts => opts.Request.CurrentStage))
                .ForMember(dest => dest.Status, src => src.MapFrom(opts => opts.Request.Status))
                .ForMember(dest => dest.Notes, src => src.MapFrom(opts => opts.Request.Notes))
                .ForMember(dest => dest.CreatorId, src => src.MapFrom(opts => opts.Request.CreatorId))
                .ForMember(dest => dest.DefinedRequestId, src => src.MapFrom(opts => opts.Request.DefinedRequestId))
                .ForMember(dest => dest.RequestReviewers, src => src.MapFrom(opts => opts.Request.RequestReviewers));

            CreateMap<AccessControlRequestCreateDto, AccessControlRequest>()
               .ForMember(dest => dest.AccessedBlocks, opt => opt.MapFrom(src => ConvertListToString(src.AccessedBlocks)))
               .ForMember(dest => dest.AccessMethods, opt => opt.MapFrom(src => ConvertListToString(src.AccessMethods)));
          

            CreateMap<AccessControlRequestUpdateDto, Request>()
                .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            CreateMap<AccessControlRequestUpdateDto, AccessControlRequest>()
                .ForMember(dest => dest.AccessedBlocks, opt => opt.MapFrom(src => ConvertListToString(src.AccessedBlocks)))
                .ForMember(dest => dest.AccessMethods, opt => opt.MapFrom(src => ConvertListToString(src.AccessMethods)))
                .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            #endregion

            #region CCTV Access Request

            CreateMap<User, CCTVAccessRequest>()
            .ForMember(dest => dest.BeneficiaryId, src => src.MapFrom(opts => opts.Id))
            .ForMember(dest => dest.BeneficiaryName, src => src.MapFrom(opts => opts.FullName))
            .ForMember(dest => dest.BeneficiaryEmail, src => src.MapFrom(opts => opts.Email))
            .ForMember(dest => dest.BeneficiaryPosition, src => src.MapFrom(opts => opts.Position))
            .ForMember(dest => dest.BeneficiaryDepartment, src => src.MapFrom(opts => opts.Department.DepartmentName))
            .ForMember(dest => dest.BeneficiaryPhoneNumber, src => src.MapFrom(opts => opts.PhoneNumber))
            .ForMember(dest => dest.BeneficiaryCompany, src => src.MapFrom(opts => opts.Company))
            .ForMember(dest => dest.CreatedAt, src => src.Ignore())
            .ForMember(dest => dest.ModifiedAt, src => src.Ignore())
            .ForMember(dest => dest.CreatedBy, src => src.Ignore())
            .ForMember(dest => dest.ModifiedBy, src => src.Ignore());





            CreateMap<CCTVAccessRequest, CCTVAccessRequestEditReadDto>()
                .ForMember(dest => dest.Id, src => src.MapFrom(opts => opts.Request.Id))
                .ForMember(dest => dest.CurrentStage, src => src.MapFrom(opts => opts.Request.CurrentStage))
                .ForMember(dest => dest.Status, src => src.MapFrom(opts => opts.Request.Status))
                .ForMember(dest => dest.Notes, src => src.MapFrom(opts => opts.Request.Notes))
                .ForMember(dest => dest.CreatorId, src => src.MapFrom(opts => opts.Request.CreatorId))
                .ForMember(dest => dest.DefinedRequestId, src => src.MapFrom(opts => opts.Request.DefinedRequestId))
                .ForMember(dest => dest.RequestedRoles, opt => opt.MapFrom(src => ConvertStringToList(src.RequestedRoles)));



            CreateMap<CCTVAccessRequest, CCTVAccessRequestDetailsReadDto>()
                .ForMember(dest => dest.Id, src => src.MapFrom(opts => opts.Request.Id))
                .ForMember(dest => dest.CurrentStage, src => src.MapFrom(opts => opts.Request.CurrentStage))
                .ForMember(dest => dest.Status, src => src.MapFrom(opts => opts.Request.Status))
                .ForMember(dest => dest.Notes, src => src.MapFrom(opts => opts.Request.Notes))
                .ForMember(dest => dest.CreatorId, src => src.MapFrom(opts => opts.Request.CreatorId))
                .ForMember(dest => dest.DefinedRequestId, src => src.MapFrom(opts => opts.Request.DefinedRequestId));



            CreateMap<CCTVAccessRequest, CCTVAccessRequestReviewerReadDto>()
                .ForMember(dest => dest.Id, src => src.MapFrom(opts => opts.Request.Id))
                .ForMember(dest => dest.CurrentStage, src => src.MapFrom(opts => opts.Request.CurrentStage))
                .ForMember(dest => dest.Status, src => src.MapFrom(opts => opts.Request.Status))
                .ForMember(dest => dest.Notes, src => src.MapFrom(opts => opts.Request.Notes))
                .ForMember(dest => dest.CreatorId, src => src.MapFrom(opts => opts.Request.CreatorId))
                .ForMember(dest => dest.DefinedRequestId, src => src.MapFrom(opts => opts.Request.DefinedRequestId))
                .ForMember(dest => dest.RequestReviewers, src => src.MapFrom(opts => opts.Request.RequestReviewers));

            CreateMap<CCTVAccessRequestCreateDto, CCTVAccessRequest>()
                .ForMember(dest => dest.RequestedRoles, opt => opt.MapFrom(src => ConvertListToString(src.RequestedRoles)));

            CreateMap<CCTVAccessRequestUpdateDto, Request>()
                .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            CreateMap<CCTVAccessRequestUpdateDto, CCTVAccessRequest>()
                .ForMember(dest => dest.RequestedRoles, src => src.MapFrom(src => ConvertListToString(src.RequestedRoles)))
                .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            #endregion

            #region Fuel Oil Invoice Request

            CreateMap<User, FuelOilInvoiceRequest>()
                .ForMember(dest => dest.BeneficiaryId, src => src.MapFrom(opts => opts.Id))
                .ForMember(dest => dest.BeneficiaryName, src => src.MapFrom(opts => opts.FullName))
                .ForMember(dest => dest.BeneficiaryEmail, src => src.MapFrom(opts => opts.Email))
                .ForMember(dest => dest.BeneficiaryPosition, src => src.MapFrom(opts => opts.Position))
                .ForMember(dest => dest.BeneficiaryDepartment, src => src.MapFrom(opts => opts.Department.DepartmentName))
                .ForMember(dest => dest.BeneficiaryPhoneNumber, src => src.MapFrom(opts => opts.PhoneNumber))
                .ForMember(dest => dest.BeneficiaryCompany, src => src.MapFrom(opts => opts.Company))
                .ForMember(dest => dest.CreatedAt, src => src.Ignore())
                .ForMember(dest => dest.ModifiedAt, src => src.Ignore())
                .ForMember(dest => dest.CreatedBy, src => src.Ignore())
                .ForMember(dest => dest.ModifiedBy, src => src.Ignore());






            CreateMap<FuelOilInvoiceRequest, FuelOilInvoiceRequestReadDto>()
                .ForMember(dest => dest.Id, src => src.MapFrom(opts => opts.Request.Id))
                .ForMember(dest => dest.CurrentStage, src => src.MapFrom(opts => opts.Request.CurrentStage))
                .ForMember(dest => dest.Status, src => src.MapFrom(opts => opts.Request.Status))
                .ForMember(dest => dest.Notes, src => src.MapFrom(opts => opts.Request.Notes))
                .ForMember(dest => dest.CreatorId, src => src.MapFrom(opts => opts.Request.CreatorId))
                .ForMember(dest => dest.DefinedRequestId, src => src.MapFrom(opts => opts.Request.DefinedRequestId))
                .ForMember(dest => dest.Attachments, src => src.MapFrom(opts => opts.Request.Attachments));




            CreateMap<FuelOilInvoiceRequest, FuelOilInvoiceRequestReviewerReadDto>()
                .ForMember(dest => dest.Id, src => src.MapFrom(opts => opts.Request.Id))
                .ForMember(dest => dest.CurrentStage, src => src.MapFrom(opts => opts.Request.CurrentStage))
                .ForMember(dest => dest.Status, src => src.MapFrom(opts => opts.Request.Status))
                .ForMember(dest => dest.Notes, src => src.MapFrom(opts => opts.Request.Notes))
                .ForMember(dest => dest.CreatorId, src => src.MapFrom(opts => opts.Request.CreatorId))
                .ForMember(dest => dest.DefinedRequestId, src => src.MapFrom(opts => opts.Request.DefinedRequestId))
                .ForMember(dest => dest.RequestReviewers, src => src.MapFrom(opts => opts.Request.RequestReviewers));

            CreateMap<FuelOilInvoiceRequestCreateDto, FuelOilInvoiceRequest>();

            CreateMap<FuelOilInvoiceRequestUpdateDto, FuelOilInvoiceRequest>()
                .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            #endregion


        }

        private string ConvertListToString(List<string> list)
        {
            return string.Join(",", list);
        }

        private List<string> ConvertStringToList(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return new List<string>();
            }

            return str.Split(',').ToList();
        }
    }
}