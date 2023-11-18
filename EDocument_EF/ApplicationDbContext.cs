using EDocument_Data.Consts.Enums;
using EDocument_Data.Models;
using EDocument_Data.Models.Audit;
using EDocument_Data.Models.Shared;
using EDocument_EF.Configurations;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EDocument_EF
{
    public partial class ApplicationDbContext : IdentityDbContext<User, Role, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DefinedRequest> DefinedRequests => Set<DefinedRequest>();
        public virtual DbSet<DefinedRequestReviewer> DefinedRequestReviewers => Set<DefinedRequestReviewer>();
        public virtual DbSet<DefinedApplicationRole> DefinedApplicationRoles => Set<DefinedApplicationRole>();
        public virtual DbSet<DefinedRequestRole> DefinedRequestRoles => Set<DefinedRequestRole>();
        public virtual DbSet<Department> Departments => Set<Department>();
        public virtual DbSet<Section> Sections => Set<Section>();
        public virtual DbSet<User> ApplicationUsers => Set<User>();
        public virtual DbSet<Request> Requests => Set<Request>();
        public virtual DbSet<Attachment> Attachments => Set<Attachment>();
        public virtual DbSet<RequestReviewer> RequestReviewers => Set<RequestReviewer>();
        public virtual DbSet<DefinedApplication> DefinedApplications => Set<DefinedApplication>();
        public virtual DbSet<RequestApplicationRole> RequestApplicationRoles => Set<RequestApplicationRole>();
        public virtual DbSet<ApplicationUserRequest> ApplicationUserRequests => Set<ApplicationUserRequest>();
        public virtual DbSet<DomainAccountRequest> DomainAccountRequests => Set<DomainAccountRequest>();
        public virtual DbSet<VehicleRequest> VehicleRequests => Set<VehicleRequest>();
        public virtual DbSet<TravelDeskRequest> TravelDeskRequests => Set<TravelDeskRequest>();
        public virtual DbSet<VoucherRequest> VoucherRequests => Set<VoucherRequest>();

        public virtual DbSet<PoRequest> PoRequests => Set<PoRequest>();

        public virtual DbSet<RefundRequest> RefundRequests => Set<RefundRequest>();

        public virtual DbSet<DiscountRequest> DiscountRequests => Set<DiscountRequest>();

        public virtual DbSet<AccessControlRequest> AccessControlRequests => Set<AccessControlRequest>();
        public virtual DbSet<CCTVAccessRequest> CCTVAccessRequests => Set<CCTVAccessRequest>();

        public virtual DbSet<FuelOilInvoiceRequest> FuelOilInvoiceRequests => Set<FuelOilInvoiceRequest>();
        public virtual DbSet<NewItemRequest> NewItemRequests => Set<NewItemRequest>();
        public virtual DbSet<RequestedItem> RequestedItems => Set<RequestedItem>();
        public virtual DbSet<PrRequest> PRRequests => Set<PrRequest>();
        public virtual DbSet<ManliftReservationRequest> ManliftReservationRequests => Set<ManliftReservationRequest>(); 
        public virtual DbSet<RequestedPr> RequestedPRs => Set<RequestedPr>();
        public virtual DbSet<EquipmentRequestIn> EquipmentRequestIns => Set<EquipmentRequestIn>();
        public virtual DbSet<EquipmentRequestOut> EquipmentRequestOuts => Set<EquipmentRequestOut>();
        

        #region Audit Tables
        public virtual DbSet<AuditDefinedRequest> AuditDefinedRequests => Set<AuditDefinedRequest>();

        public virtual DbSet<AuditDefinedRequestReviewer> AuditDefinedRequestReviewers => Set<AuditDefinedRequestReviewer>();
        public virtual DbSet<AuditDefinedApplicationRole> AuditDefinedApplicationRoles => Set<AuditDefinedApplicationRole>();
        public virtual DbSet<AuditDefinedRequestRole> AuditDefinedRequestRoles => Set<AuditDefinedRequestRole>();
        public virtual DbSet<AuditDepartment> AuditDepartments => Set<AuditDepartment>();
        public virtual DbSet<AuditSection> AuditSections => Set<AuditSection>();
        public virtual DbSet<AuditUser> AuditUsers => Set<AuditUser>();
        public virtual DbSet<AuditRole> AuditRoles => Set<AuditRole>();
        public virtual DbSet<AuditRequest> AuditRequests => Set<AuditRequest>();
        public virtual DbSet<AuditAttachment> AuditAttachments => Set<AuditAttachment>();
        public virtual DbSet<AuditRequestReviewer> AuditRequestReviewers => Set<AuditRequestReviewer>();
        public virtual DbSet<AuditDefinedApplication> AuditDefinedApplications => Set<AuditDefinedApplication>();
        public virtual DbSet<AuditRequestApplicationRole> AuditRequestApplicationRoles => Set<AuditRequestApplicationRole>();
        public virtual DbSet<AuditApplicationUserRequest> AuditApplicationUserRequests => Set<AuditApplicationUserRequest>();
        public virtual DbSet<AuditDomainAccountRequest> AuditDomainAccountRequests => Set<AuditDomainAccountRequest>();
        public virtual DbSet<AuditVehicleRequest> AuditVehicleRequests => Set<AuditVehicleRequest>();
        public virtual DbSet<AuditTravelDeskRequest> AuditTravelDeskRequests => Set<AuditTravelDeskRequest>();   
        public virtual DbSet<AuditVoucherRequest> AuditVoucherRequests => Set<AuditVoucherRequest>();
        public virtual DbSet<AuditPoRequest> AuditPoRequests => Set<AuditPoRequest>();

        public virtual DbSet<AuditRefundRequest> AuditRefundRequests => Set<AuditRefundRequest>();

        public virtual DbSet<AuditDiscountRequest> AuditDiscountRequests => Set<AuditDiscountRequest>();
        public virtual DbSet<AuditAccessControlRequest> AuditAccessControlRequests => Set<AuditAccessControlRequest>();
        public virtual DbSet<AuditCCTVAccessRequest> AuditCCTVAccessRequests => Set<AuditCCTVAccessRequest>();
        public virtual DbSet<AuditFuelOilInvoiceRequest> AuditFuelOilInvoiceRequests => Set<AuditFuelOilInvoiceRequest>();
        public virtual DbSet<AuditEquipmentRequestIn> AuditEquipmentRequestIns => Set<AuditEquipmentRequestIn>();
        public virtual DbSet<AuditEquipmentRequestOut> AuditEquipmentRequestOuts => Set<AuditEquipmentRequestOut>();
        public virtual DbSet<AuditNewItemRequest> AuditNewItemRequests => Set<AuditNewItemRequest>();
        public virtual DbSet<AuditRequestedItem> AuditRequestedItems => Set<AuditRequestedItem>();
        public virtual DbSet<AuditPrRequest> AuditPRRequests => Set<AuditPrRequest>();
        public virtual DbSet<AuditRequestedPr> AuditRequestedPRs => Set<AuditRequestedPr>();
        public virtual DbSet<AuditManliftReservationRequest> AuditManliftReservationRequests => Set<AuditManliftReservationRequest>();

        #endregion

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            OnModelCreatingPartial(builder);

            builder.ApplyConfiguration(new DefinedRequestConfiguration());
            builder.ApplyConfiguration(new DefinedRequestReviewerConfiguration());
            builder.ApplyConfiguration(new DefinedApplicationRoleConfiguration());
            builder.ApplyConfiguration(new DefinedRequestRoleConfiguration());
            builder.ApplyConfiguration(new DepartmentConfiguration());
            builder.ApplyConfiguration(new SectionConfiguration());
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new RequestConfiguration());
            builder.ApplyConfiguration(new RequestApplicationRoleConfiguration());
            builder.ApplyConfiguration(new AttachmentConfiguration());
            builder.ApplyConfiguration(new RequestReviewerConfiguration());
            builder.ApplyConfiguration(new DefinedApplicationConfiguration());
            builder.ApplyConfiguration(new ApplicationUserRequestConfiguration());
            builder.ApplyConfiguration(new DomainAccountRequestConfiguration());
            builder.ApplyConfiguration(new VehicleRequestConfiguration());
            builder.ApplyConfiguration(new TravelDeskRequestConfiguration());
            builder.ApplyConfiguration(new PoRequestConfiguration());
            builder.ApplyConfiguration(new VoucherRequestConfiguration());
            builder.ApplyConfiguration(new RefundRequestConfiguration());
            builder.ApplyConfiguration(new DiscountRequestConfiguration());
            builder.ApplyConfiguration(new AccessControlRequestConfiguration());
            builder.ApplyConfiguration(new CCTVAccessRequestConfiguration());
            builder.ApplyConfiguration(new FuelOilInvoiceRequestConfiguration());
            builder.ApplyConfiguration(new NewItemRequestConfiguration());
            builder.ApplyConfiguration(new RequestedItemConfiguration());
            builder.ApplyConfiguration(new PrRequestConfiguration());
            builder.ApplyConfiguration(new RequestedPrConfiguration());
            builder.ApplyConfiguration(new ManliftReservationRequestConfiguration());
            builder.ApplyConfiguration(new EquipmentRequestInConfiguration());
            builder.ApplyConfiguration(new EquipmentRequestOutConfiguration());
        }

        public override int SaveChanges()
        {
            foreach (var item in ChangeTracker.Entries<BaseEntity>().AsEnumerable())
            {
                switch (item.State)
                {
                    case EntityState.Added:
                        item.Entity.CreatedAt = DateTime.Now;
                        break;

                    case EntityState.Modified:
                    case EntityState.Deleted:
                        item.Entity.ModifiedAt = DateTime.Now;
                        break;
                }
            }

            foreach (var item in ChangeTracker.Entries<User>().AsEnumerable())
            {
                switch (item.State)
                {
                    case EntityState.Added:
                        item.Entity.CreatedAt = DateTime.Now;
                        break;

                    case EntityState.Modified:
                    case EntityState.Deleted:
                        item.Entity.ModifiedAt = DateTime.Now;
                        break;
                }
            }

            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var item in ChangeTracker.Entries<BaseEntity>().AsEnumerable())
            {
                switch (item.State)
                {
                    case EntityState.Added:
                        item.Entity.CreatedAt = DateTime.Now;
                        break;

                    case EntityState.Modified:
                    case EntityState.Deleted:
                        item.Entity.ModifiedAt = DateTime.Now;
                        break;
                }
            }

            foreach (var item in ChangeTracker.Entries<User>().AsEnumerable())
            {
                switch (item.State)
                {
                    case EntityState.Added:
                        item.Entity.CreatedAt = DateTime.Now;
                        break;

                    case EntityState.Modified:
                    case EntityState.Deleted:
                        item.Entity.ModifiedAt = DateTime.Now;
                        break;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }

        private partial void OnModelCreatingPartial(ModelBuilder builder);
    }

    public partial class ApplicationDbContext : IdentityDbContext<User, Role, string>
    {
        private partial void OnModelCreatingPartial(ModelBuilder builder)
        {
            
            builder.Entity<User>().ToTable(nameof(User), "security", tb => tb.HasTrigger($"TR_{nameof(AuditUser)}"));
            builder.Entity<Role>().ToTable(nameof(Role), "security", tb => tb.HasTrigger($"TR_{nameof(AuditRole)}"));
            builder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaims", "security");
            builder.Entity<IdentityUserRole<string>>().ToTable("UserRoles", "security");
            builder.Entity<IdentityUserClaim<string>>().ToTable("UserClaims", "security");
            builder.Entity<IdentityUserLogin<string>>().ToTable("UserLogin", "security");
            builder.Entity<IdentityUserToken<string>>().ToTable("UserToken", "security");

            #region Audit
            builder.Entity<AuditDefinedRequest>().ToTable(nameof(AuditDefinedRequest), "audit");
            builder.Entity<AuditDefinedRequestReviewer>().ToTable(nameof(AuditDefinedRequestReviewer), "audit");
            builder.Entity<AuditDefinedApplicationRole>().ToTable(nameof(AuditDefinedApplicationRole), "audit");
            builder.Entity<AuditDefinedRequestRole>().ToTable(nameof(AuditDefinedRequestRole), "audit");
            builder.Entity<AuditDepartment>().ToTable(nameof(AuditDepartment), "audit");
            builder.Entity<AuditSection>().ToTable(nameof(AuditSection), "audit");
            builder.Entity<AuditUser>().ToTable(nameof(AuditUser), "audit");
            builder.Entity<AuditRole>().ToTable(nameof(AuditRole), "audit");
            builder.Entity<AuditRequest>().ToTable(nameof(AuditRequest), "audit");
            builder.Entity<AuditAttachment>().ToTable(nameof(AuditAttachment), "audit");
            builder.Entity<AuditRequestReviewer>().ToTable(nameof(AuditRequestReviewer), "audit");
            builder.Entity<AuditDefinedApplication>().ToTable(nameof(AuditDefinedApplication), "audit");
            builder.Entity<AuditRequestApplicationRole>().ToTable(nameof(AuditRequestApplicationRole), "audit");
            builder.Entity<AuditApplicationUserRequest>().ToTable(nameof(AuditApplicationUserRequest), "audit");
            builder.Entity<AuditDomainAccountRequest>().ToTable(nameof(AuditDomainAccountRequest), "audit");
            builder.Entity<AuditVehicleRequest>().ToTable(nameof(AuditVehicleRequest), "audit");
            builder.Entity<AuditTravelDeskRequest>().ToTable(nameof(AuditTravelDeskRequest), "audit");
            builder.Entity<AuditVoucherRequest>().ToTable(nameof(AuditVoucherRequest), "audit");
            builder.Entity<AuditPoRequest>().ToTable(nameof(AuditPoRequest), "audit");
            builder.Entity<AuditRefundRequest>().ToTable(nameof(AuditRefundRequest), "audit");
            builder.Entity<AuditDiscountRequest>().ToTable(nameof(AuditDiscountRequest), "audit");
            builder.Entity<AuditCCTVAccessRequest>().ToTable(nameof(AuditCCTVAccessRequest), "audit");
            builder.Entity<AuditAccessControlRequest>().ToTable(nameof(AuditAccessControlRequest), "audit");
            builder.Entity<AuditFuelOilInvoiceRequest>().ToTable(nameof(AuditFuelOilInvoiceRequest), "audit");
            builder.Entity<AuditNewItemRequest>().ToTable(nameof(AuditNewItemRequest), "audit");
            builder.Entity<AuditRequestedItem>().ToTable(nameof(AuditRequestedItem), "audit");
            builder.Entity<AuditPrRequest>().ToTable(nameof(AuditPrRequest), "audit");
            builder.Entity<AuditRequestedPr>().ToTable(nameof(AuditRequestedPr), "audit");
            builder.Entity<AuditManliftReservationRequest>().ToTable(nameof(AuditManliftReservationRequest), "audit");
            builder.Entity<AuditEquipmentRequestIn>().ToTable(nameof(AuditEquipmentRequestIn), "audit");
            builder.Entity<AuditEquipmentRequestOut>().ToTable(nameof(AuditEquipmentRequestOut), "audit");
            #endregion

        }
    }
}