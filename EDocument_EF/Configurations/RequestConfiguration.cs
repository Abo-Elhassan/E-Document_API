﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using EDocument_Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace EDocument_EF.Configurations
{
    public partial class RequestConfiguration : IEntityTypeConfiguration<Request>
    {
        public void Configure(EntityTypeBuilder<Request> entity)
        {
            entity.ToTable(nameof(Request));

            entity.Property(e => e.Id)
            .UseIdentityColumn();

            entity.Property(e => e.CreatorId)
            .IsRequired()
            .HasMaxLength(50);


            entity.Property(e => e.DeclinedBy)
            .HasMaxLength(200);

            entity.Property(e => e.Status).HasConversion<string>()
            .HasMaxLength(50);

            entity.Property(e => e.CreatedAt)
            .HasColumnType("smalldatetime");

            entity.Property(e => e.ModifiedAt)
            .HasColumnType("smalldatetime");

            entity.Property(e => e.CreatedBy)
            .HasMaxLength(50);

            entity.Property(e => e.ModifiedBy)
            .HasMaxLength(50);

            entity.HasOne(d => d.Creator).WithMany(p => p.CreatedRequests)
            .HasForeignKey(d => d.CreatorId)
            .HasConstraintName("FK_Request_User");

            entity.HasOne(d => d.DefinedRequest).WithMany(p => p.Requests)
            .HasForeignKey(d => d.DefinedRequestId)
            .HasConstraintName("FK_Request_DefinedRequest");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Request> entity);
    }
}
