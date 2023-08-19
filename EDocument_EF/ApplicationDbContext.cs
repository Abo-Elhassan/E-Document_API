
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDocument_Data.Models;
using EDocument_EF.Configurations;

namespace EDocument_EF
{

    public partial class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DefinedRequest> DefinedRequests => Set<DefinedRequest>();
        public virtual DbSet<DefinedRequestReviewer> DefinedRequestReviewers => Set<DefinedRequestReviewer>();
        public virtual DbSet<DefinedRequestRole> DefinedRequestRoles => Set<DefinedRequestRole>();
        public virtual DbSet<Department> Departments => Set<Department>();
        public virtual DbSet<ApplicationUser> Employees => Set<ApplicationUser>();
        public virtual DbSet<Request> Requests => Set<Request>();
        public virtual DbSet<OracleFusionAccessRequest> OracleAccessRequests => Set<OracleFusionAccessRequest>();
        public virtual DbSet<MenaPayAccessRequest> MenaPayAccessRequests => Set<MenaPayAccessRequest>();
        public virtual DbSet<TosAccessRequest> TosAccessRequests => Set<TosAccessRequest>();
        public virtual DbSet<BiAccessRequest> BiAccessRequests => Set<BiAccessRequest>();
        public virtual DbSet<DomainAccountRequest> DomainAccountRequests => Set<DomainAccountRequest>();
        //public virtual DbSet<JobPlanRequest> JobPlanRequests => Set<JobPlanRequest>();
        public virtual DbSet<CarRequest> CarRequests => Set<CarRequest>();
        public virtual DbSet<TravelDeskRequest> TravelDeskRequests => Set<TravelDeskRequest>();
       // public virtual DbSet<VoucherRequest> VoucherRequests => Set<VoucherRequest>();
       // public virtual DbSet<PoRequest> PoRequests => Set<PoRequest>();

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            OnModelCreatingPartial(builder);

            builder.ApplyConfiguration(new DefinedRequestConfiguration());
            builder.ApplyConfiguration(new DefinedRequestReviewerConfiguration());
            builder.ApplyConfiguration(new DefinedRequestRoleConfiguration());
            builder.ApplyConfiguration(new DepartmentConfiguration());
            builder.ApplyConfiguration(new ApplicationUserConfiguration());
            builder.ApplyConfiguration(new RequestConfiguration());
            builder.ApplyConfiguration(new OracleFusionAccessRequestConfiguration());
            builder.ApplyConfiguration(new MenaPayAccessRequestConfiguration());
            builder.ApplyConfiguration(new TosAccessRequestConfiguration());
            builder.ApplyConfiguration(new BiAccessRequestConfiguration());
            builder.ApplyConfiguration(new DomainAccountRequestConfiguration());
           // builder.ApplyConfiguration(new JobPlanRequestConfiguration());
            builder.ApplyConfiguration(new CarRequestConfiguration());
            builder.ApplyConfiguration(new TravelDeskRequestConfiguration());
            //builder.ApplyConfiguration(new PoRequestConfiguration());
            //builder.ApplyConfiguration(new VoucherRequestConfiguration());

        }

        partial void OnModelCreatingPartial(ModelBuilder builder);
    }



    public partial class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        partial void OnModelCreatingPartial(ModelBuilder builder)
        {
            builder.Entity<IdentityUserClaim<string>>(entity =>
            {
                entity.ToTable("UserClaim");
            });
        }
    }
}
