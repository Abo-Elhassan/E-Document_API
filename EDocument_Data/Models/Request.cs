﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable

using System;
using System.Collections.Generic;
using EDocument_Data.Consts.Enums;
using EDocument_Data.Models.Shared;

namespace EDocument_Data.Models;

public partial class Request : BaseEntity
{
    public long Id { get; set; }

    public int CurrentStage { get; set; }

    public string Status { get; set; }

    public string Notes { get; set; }

    public string CreatorId { get; set; }

    public long DefinedRequestId { get; set; }

    public virtual ICollection<Attachment> Attachments { get; set; } = new HashSet<Attachment>();
    
    public virtual User Creator { get; set; }

    public virtual DefinedRequest DefinedRequest { get; set; }

    public virtual ICollection<RequestApplicationRole> RequestApplicationRoles { get; set; } = new HashSet<RequestApplicationRole>();
    public virtual ICollection<RequestReviewer> RequestReviewers { get; set; } = new HashSet<RequestReviewer>();
    public virtual VehicleRequest VehicleRequest { get; set; } 
    public virtual TravelDeskRequest TravelDeskRequest { get; set; } 
    public virtual ApplicationUserRequest ApplicationUserRequest { get; set; } 
    public virtual DomainAccountRequest DomainAccountRequest { get; set; }
    public virtual VoucherRequest VoucherRequest { get; set; } 
    public virtual PoRequest PoRequest { get; set; }
    public virtual RefundRequest RefundRequest { get; set; }
    public virtual DiscountRequest DiscountRequest { get; set; }
    public virtual CCTVAccessRequest CCTVAccessRequest { get; set; }
    public virtual AccessControlRequest AccessControlRequest { get; set; }
    public virtual FuelOilInvoiceRequest FuelOilInvoiceRequest { get; set; }
    public virtual NewItemRequest NewItemRequest { get; set; }
    public virtual PRRequest PRRequest { get; set; }
    public virtual ManliftReservationRequest ManliftReservationRequest { get; set; }
    public virtual EquipmentRequestIn EquipmentRequestIn { get; set; }
    public virtual EquipmentRequestOut EquipmentRequestOut { get; set; }


}