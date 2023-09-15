using EDocument_Data.Models;
using EDocument_Data.Models.Shared;
using EDocument_EF.Configurations;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Threading;

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
        public virtual DbSet<CarRequest> CarRequests => Set<CarRequest>();
        public virtual DbSet<TravelDeskRequest> TravelDeskRequests => Set<TravelDeskRequest>();

        //public virtual DbSet<JobPlanRequest> JobPlanRequests => Set<JobPlanRequest>();
        public virtual DbSet<VoucherRequest> VoucherRequests => Set<VoucherRequest>();

        public virtual DbSet<PoRequest> PoRequests => Set<PoRequest>();

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
            builder.ApplyConfiguration(new CarRequestConfiguration());
            builder.ApplyConfiguration(new TravelDeskRequestConfiguration());
            //builder.ApplyConfiguration(new JobPlanRequestConfiguration());
            builder.ApplyConfiguration(new PoRequestConfiguration());
            builder.ApplyConfiguration(new VoucherRequestConfiguration());
        }

        public override int SaveChanges()
        {
            foreach (var item in ChangeTracker.Entries<BaseEntity>().AsEnumerable())
            {
                switch (item.State)
                {
                    case EntityState.Added:
                        item.Entity.CreatedAt = DateTime.Now;
                        item.Entity.ModifiedAt = DateTime.Now;
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
                        item.Entity.ModifiedAt = DateTime.Now;
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
            builder.Entity<User>().ToTable("User", "security");
            builder.Entity<Role>().ToTable("Role", "security");
            builder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaims", "security");
            builder.Entity<IdentityUserRole<string>>().ToTable("UserRoles", "security");
            builder.Entity<IdentityUserClaim<string>>().ToTable("UserClaims", "security");
            builder.Entity<IdentityUserLogin<string>>().ToTable("UserLogin", "security");
            builder.Entity<IdentityUserToken<string>>().ToTable("UserToken", "security");
        }
    }
}