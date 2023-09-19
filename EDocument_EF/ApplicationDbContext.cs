using EDocument_Data.Consts.Enums;
using EDocument_Data.Models;
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
            builder.Entity<User>().ToTable("User", "security");
            builder.Entity<Role>().ToTable("Role", "security");
            builder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaims", "security");
            builder.Entity<IdentityUserRole<string>>().ToTable("UserRoles", "security");
            builder.Entity<IdentityUserClaim<string>>().ToTable("UserClaims", "security");
            builder.Entity<IdentityUserLogin<string>>().ToTable("UserLogin", "security");
            builder.Entity<IdentityUserToken<string>>().ToTable("UserToken", "security");

            #region Seeding
            var SuperAdminId = Guid.NewGuid().ToString();
            var HRId = Guid.NewGuid().ToString();
            var FinanceId = Guid.NewGuid().ToString();
            var ProcurementId = Guid.NewGuid().ToString(); 
            var ITId = Guid.NewGuid().ToString();
            var SecurityId = Guid.NewGuid().ToString();
            var AdminstrationId = Guid.NewGuid().ToString();
            var StoreId = Guid.NewGuid().ToString();
            var CustomerServiceId = Guid.NewGuid().ToString();
            var OperationBGCId = Guid.NewGuid().ToString();
            var OperationCTId = Guid.NewGuid().ToString();
            var EngineeringId = Guid.NewGuid().ToString();
            var CommercialId = Guid.NewGuid().ToString();
            var CommunicationsId = Guid.NewGuid().ToString();
            var InfoFortId = Guid.NewGuid().ToString();
            #region Roles

            builder.Entity<Role>().HasData(
             new Role { Id = SuperAdminId, Name = ApplicationRole.SuperAdmin.ToString(), NormalizedName = ApplicationRole.SuperAdmin.ToString().ToUpper(), ConcurrencyStamp = Guid.NewGuid().ToString() },
          new Role { Id = HRId, Name = ApplicationRole.HR.ToString(), NormalizedName = ApplicationRole.HR.ToString().ToUpper(), ConcurrencyStamp = Guid.NewGuid().ToString() },
          new Role { Id = FinanceId, Name = ApplicationRole.Finance.ToString(), NormalizedName = ApplicationRole.Finance.ToString().ToUpper(), ConcurrencyStamp = Guid.NewGuid().ToString() },
          new Role { Id = ProcurementId, Name = ApplicationRole.Procurement.ToString(), NormalizedName = ApplicationRole.Procurement.ToString().ToUpper(), ConcurrencyStamp = Guid.NewGuid().ToString() },
          new Role { Id = ITId, Name = ApplicationRole.IT.ToString(), NormalizedName = ApplicationRole.IT.ToString().ToUpper(), ConcurrencyStamp = Guid.NewGuid().ToString() },
          new Role { Id = SecurityId, Name = ApplicationRole.Security.ToString(), NormalizedName = ApplicationRole.Security.ToString().ToUpper(), ConcurrencyStamp = Guid.NewGuid().ToString() },
          new Role { Id = AdminstrationId, Name = ApplicationRole.Adminstration.ToString(), NormalizedName = ApplicationRole.Adminstration.ToString().ToUpper(), ConcurrencyStamp = Guid.NewGuid().ToString() },
          new Role { Id = StoreId, Name = ApplicationRole.Store.ToString(), NormalizedName = ApplicationRole.Store.ToString().ToUpper(), ConcurrencyStamp = Guid.NewGuid().ToString() },
          new Role { Id = CustomerServiceId, Name = ApplicationRole.CustomerService.ToString(), NormalizedName = ApplicationRole.CustomerService.ToString().ToUpper(), ConcurrencyStamp = Guid.NewGuid().ToString() },
          new Role { Id = OperationBGCId, Name = ApplicationRole.OperationBGC.ToString(), NormalizedName = ApplicationRole.OperationBGC.ToString().ToUpper(), ConcurrencyStamp = Guid.NewGuid().ToString() },
          new Role { Id = OperationCTId, Name = ApplicationRole.OperationCT.ToString(), NormalizedName = ApplicationRole.OperationCT.ToString().ToUpper(), ConcurrencyStamp = Guid.NewGuid().ToString() },
          new Role { Id = EngineeringId, Name = ApplicationRole.Engineering.ToString(), NormalizedName = ApplicationRole.Engineering.ToString().ToUpper(), ConcurrencyStamp = Guid.NewGuid().ToString() },
          new Role { Id = CommercialId, Name = ApplicationRole.Commercial.ToString(), NormalizedName = ApplicationRole.Commercial.ToString().ToUpper(), ConcurrencyStamp = Guid.NewGuid().ToString() },
          new Role { Id = CommunicationsId, Name = ApplicationRole.Communications.ToString(), NormalizedName = ApplicationRole.Communications.ToString().ToUpper(), ConcurrencyStamp = Guid.NewGuid().ToString() },
          new Role { Id = InfoFortId, Name = ApplicationRole.InfoFort.ToString(), NormalizedName = ApplicationRole.InfoFort.ToString().ToUpper(), ConcurrencyStamp = Guid.NewGuid().ToString() }
             );

            #endregion Roles

            #region User

            builder.Entity<User>().HasData(
               new User
               {
                   Id = "50269",
                   UserName = "admin_manager",
                   NormalizedUserName = "ADMIN_MANAGER",
                   FullName = "Ahmed Zaki",
                   PhoneNumber = "01002234498",
                   Email = "admin_manager@dpworld.com",
                   NormalizedEmail = "ADMIN_MANGER@DPWORLD.COM",
                   IsActive = true,
                   IsEmployee = true,
                   Position = "Head of Administration",
                   Company = "DP World",
                   DepartmentId = 1,
                   SecurityStamp = Guid.NewGuid().ToString(),
                   ManagerId = null, // Set ManagerId to null for the head of the department
                   EmailConfirmed = false,
                   PhoneNumberConfirmed = false,
                   LockoutEnabled = false,
                   TwoFactorEnabled = false,
                   AccessFailedCount = 0,
               },

    new User
    {
        Id = "90010",
        UserName = "ff_manager", // Replace "admin" with "freightforwarding"
        NormalizedUserName = "FF_MANAGER", // Replace "admin" with "freightforwarding"
        FullName = "Hanaa Mohamed",
        PhoneNumber = "01002234498",
        Email = "freightforwarding_manager@dpworld.com", // Replace "admin" with "freightforwarding"
        NormalizedEmail = "FREIGHTFORWARDING_MANAGER@DPWORLD.COM", // Replace "admin" with "freightforwarding"
        IsActive = true,
        IsEmployee = true,
        Position = "Head of Freight Forwarding", // Department name remains the same
        Company = "DP World",
        DepartmentId = 2,
        SecurityStamp = Guid.NewGuid().ToString(),
        ManagerId = null,
        EmailConfirmed = false,
        PhoneNumberConfirmed = false,
        LockoutEnabled = false,
        TwoFactorEnabled = false,
        AccessFailedCount = 0,
    }, new User
    {
        Id = "51330",
        UserName = "bt_manager", // Replace "admin" with "businesstransformation"
        NormalizedUserName = "BT_MANAGER", // Replace "admin" with "businesstransformation"
        FullName = "Alaa Nasr",
        PhoneNumber = "01002234498",
        Email = "businesstransformation_manager@dpworld.com", // Replace "admin" with "businesstransformation"
        NormalizedEmail = "BUSINESSTRANSFORMATION_MANAGER@DPWORLD.COM", // Replace "admin" with "businesstransformation"
        IsActive = true,
        IsEmployee = true,
        Position = "Head of Business Transformation",
        Company = "DP World",
        DepartmentId = 3,
        SecurityStamp = Guid.NewGuid().ToString(),
        ManagerId = null,
        EmailConfirmed = false,
        PhoneNumberConfirmed = false,
        LockoutEnabled = false,
        TwoFactorEnabled = false,
        AccessFailedCount = 0,
    },
    new User
    {
        Id = "51573",
        UserName = "commercial_manager", // Replace "admin" with "commercial"
        NormalizedUserName = "COMMERCIAL_MANAGER", // Replace "admin" with "commercial"
        FullName = "Aliaa Elgammal",
        PhoneNumber = "01002234498",
        Email = "commercial_manager@dpworld.com", // Replace "admin" with "commercial"
        NormalizedEmail = "COMMERCIAL_MANAGER@DPWORLD.COM", // Replace "admin" with "commercial"
        IsActive = true,
        IsEmployee = true,
        Position = "Head of Commercial",
        Company = "DP World",
        DepartmentId = 4,
        SecurityStamp = Guid.NewGuid().ToString(),
        ManagerId = null,
        EmailConfirmed = false,
        PhoneNumberConfirmed = false,
        LockoutEnabled = false,
        TwoFactorEnabled = false,
        AccessFailedCount = 0,
    }, new User
    {
        Id = "51668",
        UserName = "communications_manager", // Replace "admin" with "communications"
        NormalizedUserName = "COMMUNICATIONS_MANAGER", // Replace "admin" with "communications"
        FullName = "Amina Hatem",
        PhoneNumber = "01002234498",
        Email = "communications_manager@dpworld.com", // Replace "admin" with "communications"
        NormalizedEmail = "COMMUNICATIONS_MANAGER@DPWORLD.COM", // Replace "admin" with "communications"
        IsActive = true,
        IsEmployee = true,
        Position = "Head of Communications",
        Company = "DP World",
        DepartmentId = 5,
        SecurityStamp = Guid.NewGuid().ToString(),
        ManagerId = null,
        EmailConfirmed = false,
        PhoneNumberConfirmed = false,
        LockoutEnabled = false,
        TwoFactorEnabled = false,
        AccessFailedCount = 0,
    },
    new User
    {
        Id = "51229",
        UserName = "cs_manager", // Replace "admin" with "customerservice"
        NormalizedUserName = "CS_MANAGER", // Replace "admin" with "customerservice"
        FullName = "Hassan Nagah",
        PhoneNumber = "01002234498",
        Email = "customerservice_manager@dpworld.com", // Replace "admin" with "customerservice"
        NormalizedEmail = "CUSTOMERSERVICE_MANAGER@DPWORLD.COM", // Replace "admin" with "customerservice"
        IsActive = true,
        IsEmployee = true,
        Position = "Head of Customer Service",
        Company = "DP World",
        DepartmentId = 6,
        SecurityStamp = Guid.NewGuid().ToString(),
        ManagerId = null,
        EmailConfirmed = false,
        PhoneNumberConfirmed = false,
        LockoutEnabled = false,
        TwoFactorEnabled = false,
        AccessFailedCount = 0,
    }, new User
    {
        Id = "Exp-16",
        UserName = "em_manager", // Replace "admin" with "executivemanagement"
        NormalizedUserName = "EM_MANAGER", // Replace "admin" with "executivemanagement"
        FullName = "Urs Moll",
        PhoneNumber = "01002234498",
        Email = "executivemanagement_manager@dpworld.com", // Replace "admin" with "executivemanagement"
        NormalizedEmail = "EXECUTIVEMANAGEMENT_MANAGER@DPWORLD.COM", // Replace "admin" with "executivemanagement"
        IsActive = true,
        IsEmployee = true,
        Position = "Head of Executive Management",
        Company = "DP World",
        DepartmentId = 7,
        SecurityStamp = Guid.NewGuid().ToString(),
        ManagerId = null,
        EmailConfirmed = false,
        PhoneNumberConfirmed = false,
        LockoutEnabled = false,
        TwoFactorEnabled = false,
        AccessFailedCount = 0,
    },
    new User
    {
        Id = "51124",
        UserName = "finance_manager", // Replace "admin" with "finance"
        NormalizedUserName = "FINANCE_MANAGER", // Replace "admin" with "finance"
        FullName = "Mustafa Sultan",
        PhoneNumber = "01002234498",
        Email = "finance_manager@dpworld.com", // Replace "admin" with "finance"
        NormalizedEmail = "FINANCE_MANAGER@DPWORLD.COM", // Replace "admin" with "finance"
        IsActive = true,
        IsEmployee = true,
        Position = "Head of Finance",
        Company = "DP World",
        DepartmentId = 8,
        SecurityStamp = Guid.NewGuid().ToString(),
        ManagerId = null,
        EmailConfirmed = false,
        PhoneNumberConfirmed = false,
        LockoutEnabled = false,
        TwoFactorEnabled = false,
        AccessFailedCount = 0,
    },
    new User
    {
        Id = "50962",
        UserName = "gr_manager", // Replace "admin" with "governmentalrelation"
        NormalizedUserName = "GR_MANAGER", // Replace "admin" with "governmentalrelation"
        FullName = "Mohamed Tarek",
        PhoneNumber = "01002234498",
        Email = "governmentalrelation_manager@dpworld.com", // Replace "admin" with "governmentalrelation"
        NormalizedEmail = "GOVERNMENTALRELATION_MANAGER@DPWORLD.COM", // Replace "admin" with "governmentalrelation"
        IsActive = true,
        IsEmployee = true,
        Position = "Head of Governmental Relation",
        Company = "DP World",
        DepartmentId = 9,
        SecurityStamp = Guid.NewGuid().ToString(),
        ManagerId = null,
        EmailConfirmed = false,
        PhoneNumberConfirmed = false,
        LockoutEnabled = false,
        TwoFactorEnabled = false,
        AccessFailedCount = 0,
    },
    new User
    {
        Id = "51572",
        UserName = "hc-ds_manager", // Replace "admin" with "hc"
        NormalizedUserName = "HC-DS_MANAGER", // Replace "admin" with "hc"
        FullName = "Aliaa Elgammal",
        PhoneNumber = "01002234498",
        Email = "hc-ds_manager@dpworld.com", // Replace "admin" with "hc"
        NormalizedEmail = "HC-DS_MANAGER@DPWORLD.COM", // Replace "admin" with "hc"
        IsActive = true,
        IsEmployee = true,
        Position = "Head of HC - DUBUY Sales",
        Company = "DP World",
        DepartmentId = 10,
        SecurityStamp = Guid.NewGuid().ToString(),
        ManagerId = null,
        EmailConfirmed = false,
        PhoneNumberConfirmed = false,
        LockoutEnabled = false,
        TwoFactorEnabled = false,
        AccessFailedCount = 0,
    },
        new User
        {
            Id = "50140",
            UserName = "hc-ssp_manager", // Replace "admin" with "hc"
            NormalizedUserName = "HC-SSP_MANAGER", // Replace "admin" with "hc"
            FullName = "Maged Mohsen",
            PhoneNumber = "01002234498",
            Email = "hc-ssp_manager@dpworld.com", // Replace "admin" with "hc"
            NormalizedEmail = "HC-SSP_MANAGER@DPWORLD.COM", // Replace "admin" with "hc"
            IsActive = true,
            IsEmployee = true,
            Position = "Head of HC - Samsung SDS project",
            Company = "DP World",
            DepartmentId = 11,
            SecurityStamp = Guid.NewGuid().ToString(),
            ManagerId = null,
            EmailConfirmed = false,
            PhoneNumberConfirmed = false,
            LockoutEnabled = false,
            TwoFactorEnabled = false,
            AccessFailedCount = 0,
        },
    new User
    {
        Id = "51331",
        UserName = "it_manager", // Replace "admin" with "it"
        NormalizedUserName = "IT_MANAGER", // Replace "admin" with "it"
        FullName = "Alaa Nasr",
        PhoneNumber = "01002234498",
        Email = "it_manager@dpworld.com", // Replace "admin" with "it"
        NormalizedEmail = "IT_MANAGER@DPWORLD.COM", // Replace "admin" with "it"
        IsActive = true,
        IsEmployee = true,
        Position = "Head of IT",
        Company = "DP World",
        DepartmentId = 12,
        SecurityStamp = Guid.NewGuid().ToString(),
        ManagerId = null,
        EmailConfirmed = false,
        PhoneNumberConfirmed = false,
        LockoutEnabled = false,
        TwoFactorEnabled = false,
        AccessFailedCount = 0,
    },
    new User
    {
        Id = "50354",
        UserName = "ops-bgc_manager", // Replace "admin" with "opscargobulk"
        NormalizedUserName = "OPS-BGC_MANAGER", // Replace "admin" with "opscargobulk"
        FullName = "Mohamed Radwan",
        PhoneNumber = "01002234498",
        Email = "ops-bgc_manager@dpworld.com", // Replace "admin" with "opscargobulk"
        NormalizedEmail = "OPS-BGC_MANAGER@DPWORLD.COM", // Replace "admin" with "opscargobulk"
        IsActive = true,
        IsEmployee = true,
        Position = "Head of OPS-Cargo & Bulk",
        Company = "DP World",
        DepartmentId = 13,
        SecurityStamp = Guid.NewGuid().ToString(),
        ManagerId = null,
        EmailConfirmed = false,
        PhoneNumberConfirmed = false,
        LockoutEnabled = false,
        TwoFactorEnabled = false,
        AccessFailedCount = 0,
    },
    new User
    {
        Id = "50141",
        UserName = "ops-ct_manager", // Replace "admin" with "opscontainers"
        NormalizedUserName = "OPS-CT_MANAGER", // Replace "admin" with "opscontainers"
        FullName = "Maged Mohsen",
        PhoneNumber = "01002234498",
        Email = "ops-ct_manager@dpworld.com", // Replace "admin" with "opscontainers"
        NormalizedEmail = "OPS-CT_MANAGER@DPWORLD.COM", // Replace "admin" with "opscontainers"
        IsActive = true,
        IsEmployee = true,
        Position = "Head of OPS-Containers",
        Company = "DP World",
        DepartmentId = 14,
        SecurityStamp = Guid.NewGuid().ToString(),
        ManagerId = null,
        EmailConfirmed = false,
        PhoneNumberConfirmed = false,
        LockoutEnabled = false,
        TwoFactorEnabled = false,
        AccessFailedCount = 0,
    },
    new User
    {
        Id = "50279",
        UserName = "people_manager", // Replace "admin" with "people"
        NormalizedUserName = "PEOPLE_MANAGER", // Replace "admin" with "people"
        FullName = "Waleed Aboelgadayl",
        PhoneNumber = "01002234498",
        Email = "people_manager@dpworld.com", // Replace "admin" with "people"
        NormalizedEmail = "PEOPLE_MANAGER@DPWORLD.COM", // Replace "admin" with "people"
        IsActive = true,
        IsEmployee = true,
        Position = "Head of People",
        Company = "DP World",
        DepartmentId = 15,
        SecurityStamp = Guid.NewGuid().ToString(),
        ManagerId = null,
        EmailConfirmed = false,
        PhoneNumberConfirmed = false,
        LockoutEnabled = false,
        TwoFactorEnabled = false,
        AccessFailedCount = 0,
    },
        new User
        {
            Id = "51188",
            UserName = "procurment_manager", // Replace "admin" with "people"
            NormalizedUserName = "PROCURMENT_MANAGER", // Replace "admin" with "people"
            FullName = "Tamer Elsayed",
            PhoneNumber = "01002234498",
            Email = "procurement_manager@dpworld.com", // Replace "admin" with "people"
            NormalizedEmail = "PROCUREMENT_MANAGER@DPWORLD.COM", // Replace "admin" with "people"
            IsActive = true,
            IsEmployee = true,
            Position = "Head of Procurment",
            Company = "DP World",
            DepartmentId = 16,
            SecurityStamp = Guid.NewGuid().ToString(),
            ManagerId = null,
            EmailConfirmed = false,
            PhoneNumberConfirmed = false,
            LockoutEnabled = false,
            TwoFactorEnabled = false,
            AccessFailedCount = 0,
        },
            new User
            {
                Id = "51659",
                UserName = "projects_manager", // Replace "admin" with "projectsfacilitymanager"
                NormalizedUserName = "PROJECTS_MANAGER", // Replace "admin" with "projectsfacilitymanager"
                FullName = "Mohamed Mandour",
                PhoneNumber = "01002234498",
                Email = "projectsfacilitymanager_manager@dpworld.com", // Replace "admin" with "projectsfacilitymanager"
                NormalizedEmail = "PROJECTSFACILITYMANAGER_MANAGER@DPWORLD.COM", // Replace "admin" with "projectsfacilitymanager"
                IsActive = true,
                IsEmployee = true,
                Position = "Head of Projects & Facility Management",
                Company = "DP World",
                DepartmentId = 17,
                SecurityStamp = Guid.NewGuid().ToString(),
                ManagerId = null,
                EmailConfirmed = false,
                PhoneNumberConfirmed = false,
                LockoutEnabled = false,
                TwoFactorEnabled = false,
                AccessFailedCount = 0,
            },
    new User
    {
        Id = "50882",
        UserName = "qhse_manager", // Replace "admin" with "qhse"
        NormalizedUserName = "QHSE_MANAGER", // Replace "admin" with "qhse"
        FullName = "Hassan Abdelghany",
        PhoneNumber = "01002234498",
        Email = "qhse_manager@dpworld.com", // Replace "admin" with "qhse"
        NormalizedEmail = "QHSE_MANAGER@DPWORLD.COM", // Replace "admin" with "qhse"
        IsActive = true,
        IsEmployee = true,
        Position = "Head of QHSE",
        Company = "DP World",
        DepartmentId = 18,
        SecurityStamp = Guid.NewGuid().ToString(),
        ManagerId = null,
        EmailConfirmed = false,
        PhoneNumberConfirmed = false,
        LockoutEnabled = false,
        TwoFactorEnabled = false,
        AccessFailedCount = 0,
    },
    new User
    {
        Id = "50263",
        UserName = "security_manager", // Replace "admin" with "security"
        NormalizedUserName = "SECURITY_MANAGER", // Replace "admin" with "security"
        FullName = "Ahmed Zaki",
        PhoneNumber = "01002234498",
        Email = "security_manager@dpworld.com", // Replace "admin" with "security"
        NormalizedEmail = "SECURITY_MANAGER@DPWORLD.COM", // Replace "admin" with "security"
        IsActive = true,
        IsEmployee = true,
        Position = "Head of Security",
        Company = "DP World",
        DepartmentId = 19,
        SecurityStamp = Guid.NewGuid().ToString(),
        ManagerId = null,
        EmailConfirmed = false,
        PhoneNumberConfirmed = false,
        LockoutEnabled = false,
        TwoFactorEnabled = false,
        AccessFailedCount = 0,
    },
    new User
    {
        Id = "50000",
        UserName = "stores_manager", // Replace "admin" with "stores"
        NormalizedUserName = "STORES_MANAGER", // Replace "admin" with "stores"
        FullName = "Ahmed Zaki",
        PhoneNumber = "01002234498",
        Email = "stores_manager@dpworld.com", // Replace "admin" with "stores"
        NormalizedEmail = "STORES_MANAGER@DPWORLD.COM", // Replace "admin" with "stores"
        IsActive = true,
        IsEmployee = true,
        Position = "Head of Stores",
        Company = "DP World",
        DepartmentId = 20,
        SecurityStamp = Guid.NewGuid().ToString(),
        ManagerId = null,
        EmailConfirmed = false,
        PhoneNumberConfirmed = false,
        LockoutEnabled = false,
        TwoFactorEnabled = false,
        AccessFailedCount = 0,
    },
    new User
    {
        Id = "50136",
        UserName = "engineering_manager", // Replace "admin" with "engineering"
        NormalizedUserName = "ENGINEERING_MANAGER", // Replace "admin" with "engineering"
        FullName = "Ahmed Zaki",
        PhoneNumber = "01002234498",
        Email = "engineering_manager@dpworld.com", // Replace "admin" with "engineering"
        NormalizedEmail = "ENGINEERING_MANAGER@DPWORLD.COM", // Replace "admin" with "engineering"
        IsActive = true,
        IsEmployee = true,
        Position = "Head of Engineering",
        Company = "DP World",
        DepartmentId = 21,
        SecurityStamp = Guid.NewGuid().ToString(),
        ManagerId = null,
        EmailConfirmed = false,
        PhoneNumberConfirmed = false,
        LockoutEnabled = false,
        TwoFactorEnabled = false,
        AccessFailedCount = 0,
    },

        new User
        {
            Id = "51509",
            UserName = "commercial-ct_sec_head", // Replace "admin" with "engineering"
            NormalizedUserName = "COMMERCIAL-CT_SEC_HEAD", // Replace "admin" with "engineering"
            FullName = "Ahmed Zaki",
            PhoneNumber = "01002234498",
            Email = "commercial-ct_sec_head@dpworld.com", // Replace "admin" with "engineering"
            NormalizedEmail = "ECOMMERCIAL-CT_SEC_HEAD@DPWORLD.COM", // Replace "admin" with "engineering"
            IsActive = true,
            IsEmployee = true,
            Position = "Commercial / Containers Section Head",
            Company = "DP World",
            DepartmentId = 4,
            SecurityStamp = Guid.NewGuid().ToString(),
            ManagerId = null,
            EmailConfirmed = false,
            PhoneNumberConfirmed = false,
            LockoutEnabled = false,
            TwoFactorEnabled = false,
            AccessFailedCount = 0,
        },

            new User
            {
                Id = "51583",
                UserName = "commercial-bgc_sec_head", // Replace "admin" with "engineering"
                NormalizedUserName = "COMMERCIAL-BGC_SEC_HEAD", // Replace "admin" with "engineering"
                FullName = "Ahmed Zaki",
                PhoneNumber = "01002234498",
                Email = "commercial-bgc_sec_head@dpworld.com", // Replace "admin" with "engineering"
                NormalizedEmail = "ECOMMERCIAL-BGC_SEC_HEAD@DPWORLD.COM", // Replace "admin" with "engineering"
                IsActive = true,
                IsEmployee = true,
                Position = "CommercialBulk / GC Section Head",
                Company = "DP World",
                DepartmentId = 4,
                SecurityStamp = Guid.NewGuid().ToString(),
                ManagerId = null,
                EmailConfirmed = false,
                PhoneNumberConfirmed = false,
                LockoutEnabled = false,
                TwoFactorEnabled = false,
                AccessFailedCount = 0,
            },

                new User
                {
                    Id = "90015",
                    UserName = "hc-ssp_sec_head", // Replace "admin" with "engineering"
                    NormalizedUserName = "HC-SSP_SEC_HEAD", // Replace "admin" with "engineering"
                    FullName = "Ahmed Zaki",
                    PhoneNumber = "01002234498",
                    Email = "hc-ssp_sec_head@dpworld.com", // Replace "admin" with "engineering"
                    NormalizedEmail = "HC-SSP_SEC_HEAD@DPWORLD.COM", // Replace "admin" with "engineering"
                    IsActive = true,
                    IsEmployee = true,
                    Position = "HC - Samsung SDS project  Section Head",
                    Company = "DP World",
                    DepartmentId = 10,
                    SecurityStamp = Guid.NewGuid().ToString(),
                    ManagerId = null,
                    EmailConfirmed = false,
                    PhoneNumberConfirmed = false,
                    LockoutEnabled = false,
                    TwoFactorEnabled = false,
                    AccessFailedCount = 0,
                },

                    new User
                    {
                        Id = "90008",
                        UserName = "hc-ds_sec_head", // Replace "admin" with "engineering"
                        NormalizedUserName = "HC-DS_SEC_HEAD", // Replace "admin" with "engineering"
                        FullName = "Ahmed Zaki",
                        PhoneNumber = "01002234498",
                        Email = "hc-ds_sec_head@dpworld.com", // Replace "admin" with "engineering"
                        NormalizedEmail = "HC-DS_SEC_HEAD@DPWORLD.COM", // Replace "admin" with "engineering"
                        IsActive = true,
                        IsEmployee = true,
                        Position = "HC - DUBUY Sales Section Head",
                        Company = "DP World",
                        DepartmentId = 11,
                        SecurityStamp = Guid.NewGuid().ToString(),
                        ManagerId = null,
                        EmailConfirmed = false,
                        PhoneNumberConfirmed = false,
                        LockoutEnabled = false,
                        TwoFactorEnabled = false,
                        AccessFailedCount = 0,
                    },

                        new User
                        {
                            Id = "51520",
                            UserName = "qhse_sec_head", // Replace "admin" with "engineering"
                            NormalizedUserName = "QHSE_SEC_HEAD", // Replace "admin" with "engineering"
                            FullName = "Ahmed Zaki",
                            PhoneNumber = "01002234498",
                            Email = "qhse_sec_head@dpworld.com", // Replace "admin" with "engineering"
                            NormalizedEmail = "QHSE_SEC_HEAD@DPWORLD.COM", // Replace "admin" with "engineering"
                            IsActive = true,
                            IsEmployee = true,
                            Position = "QHSE Section HEad",
                            Company = "DP World",
                            DepartmentId = 18,
                            SecurityStamp = Guid.NewGuid().ToString(),
                            ManagerId = null,
                            EmailConfirmed = false,
                            PhoneNumberConfirmed = false,
                            LockoutEnabled = false,
                            TwoFactorEnabled = false,
                            AccessFailedCount = 0,
                        },

                            new User
                            {
                                Id = "51449",
                                UserName = "ops-cg_sec_head", // Replace "admin" with "engineering"
                                NormalizedUserName = "OPS-CG_SEC_HEAD", // Replace "admin" with "engineering"
                                FullName = "Ahmed Zaki",
                                PhoneNumber = "01002234498",
                                Email = "ops-cg_sec_head@dpworld.com", // Replace "admin" with "engineering"
                                NormalizedEmail = "OPS-CG_SEC_HEAD@DPWORLD.COM", // Replace "admin" with "engineering"
                                IsActive = true,
                                IsEmployee = true,
                                Position = "OPS-Cargo & Bulk Section Head",
                                Company = "DP World",
                                DepartmentId = 13,
                                SecurityStamp = Guid.NewGuid().ToString(),
                                ManagerId = null,
                                EmailConfirmed = false,
                                PhoneNumberConfirmed = false,
                                LockoutEnabled = false,
                                TwoFactorEnabled = false,
                                AccessFailedCount = 0,
                            },

                            new User
                            {
                                Id = "50844",
                                UserName = "ops-dri_sec_head", // Replace "admin" with "engineering"
                                NormalizedUserName = "OPS-DRI_SEC_HEAD", // Replace "admin" with "engineering"
                                FullName = "Ahmed Zaki",
                                PhoneNumber = "01002234498",
                                Email = "ops-dri_sec_head@dpworld.com", // Replace "admin" with "engineering"
                                NormalizedEmail = "OPS-DRI_SEC_HEAD@DPWORLD.COM", // Replace "admin" with "engineering"
                                IsActive = true,
                                IsEmployee = true,
                                Position = "OPS-DRI Section Head",
                                Company = "DP World",
                                DepartmentId = 13,
                                SecurityStamp = Guid.NewGuid().ToString(),
                                ManagerId = null,
                                EmailConfirmed = false,
                                PhoneNumberConfirmed = false,
                                LockoutEnabled = false,
                                TwoFactorEnabled = false,
                                AccessFailedCount = 0,
                            },

                            new User
                            {
                                Id = "50670",
                                UserName = "ops-ct_sec_head", // Replace "admin" with "engineering"
                                NormalizedUserName = "OPS-CT_SEC_HEAD", // Replace "admin" with "engineering"
                                FullName = "Ahmed Zaki",
                                PhoneNumber = "01002234498",
                                Email = "ops-ct_sec_head@dpworld.com", // Replace "admin" with "engineering"
                                NormalizedEmail = "OPS-DRI_SEC_HEAD@DPWORLD.COM", // Replace "admin" with "engineering"
                                IsActive = true,
                                IsEmployee = true,
                                Position = "OPS-Containers Section Head",
                                Company = "DP World",
                                DepartmentId = 14,
                                SecurityStamp = Guid.NewGuid().ToString(),
                                ManagerId = null,
                                EmailConfirmed = false,
                                PhoneNumberConfirmed = false,
                                LockoutEnabled = false,
                                TwoFactorEnabled = false,
                                AccessFailedCount = 0,
                            },

                            new User
                            {
                                Id = "50128",
                                UserName = "ops-cfs_sec_head", // Replace "admin" with "engineering"
                                NormalizedUserName = "OPS-CFS_SEC_HEAD", // Replace "admin" with "engineering"
                                FullName = "Ahmed Zaki",
                                PhoneNumber = "01002234498",
                                Email = "ops-cfs_sec_head@dpworld.com", // Replace "admin" with "engineering"
                                NormalizedEmail = "OPS-CFS_SEC_HEAD@DPWORLD.COM", // Replace "admin" with "engineering"
                                IsActive = true,
                                IsEmployee = true,
                                Position = "OPS-CFS Section Head",
                                Company = "DP World",
                                DepartmentId = 14,
                                SecurityStamp = Guid.NewGuid().ToString(),
                                ManagerId = null,
                                EmailConfirmed = false,
                                PhoneNumberConfirmed = false,
                                LockoutEnabled = false,
                                TwoFactorEnabled = false,
                                AccessFailedCount = 0,
                            },

                                            new User
                                            {
                                                Id = "51126",
                                                UserName = "tec-workshop_sec_head", // Replace "admin" with "engineering"
                                                NormalizedUserName = "TEC-WORKSHOP_SEC_HEAD", // Replace "admin" with "engineering"
                                                FullName = "Ahmed Zaki",
                                                PhoneNumber = "01002234498",
                                                Email = "tec-workshop_sec_head@dpworld.com", // Replace "admin" with "engineering"
                                                NormalizedEmail = "TEC-WORKSHOP_SEC_HEAD@DPWORLD.COM", // Replace "admin" with "engineering"
                                                IsActive = true,
                                                IsEmployee = true,
                                                Position = "TEC-Workshop Section Head",
                                                Company = "DP World",
                                                DepartmentId = 21,
                                                SecurityStamp = Guid.NewGuid().ToString(),
                                                ManagerId = null,
                                                EmailConfirmed = false,
                                                PhoneNumberConfirmed = false,
                                                LockoutEnabled = false,
                                                TwoFactorEnabled = false,
                                                AccessFailedCount = 0,
                                            },
                                               new User
                                               {
                                                   Id = "51090",
                                                   UserName = "tec-crane_sec_head", // Replace "admin" with "engineering"
                                                   NormalizedUserName = "TEC-CRANE_SEC_HEAD", // Replace "admin" with "engineering"
                                                   FullName = "Ahmed Zaki",
                                                   PhoneNumber = "01002234498",
                                                   Email = "tec-crane_sec_head@dpworld.com", // Replace "admin" with "engineering"
                                                   NormalizedEmail = "TEC-CRANE_SEC_HEAD@DPWORLD.COM", // Replace "admin" with "engineering"
                                                   IsActive = true,
                                                   IsEmployee = true,
                                                   Position = "TEC-Crane Section Head",
                                                   Company = "DP World",
                                                   DepartmentId = 21,
                                                   SecurityStamp = Guid.NewGuid().ToString(),
                                                   ManagerId = null,
                                                   EmailConfirmed = false,
                                                   PhoneNumberConfirmed = false,
                                                   LockoutEnabled = false,
                                                   TwoFactorEnabled = false,
                                                   AccessFailedCount = 0,
                                               },
                                                  new User
                                                  {
                                                      Id = "50562",
                                                      UserName = "tec-planning_sec_head", // Replace "admin" with "engineering"
                                                      NormalizedUserName = "TEC-PLANNING_SEC_HEAD", // Replace "admin" with "engineering"
                                                      FullName = "Ahmed Zaki",
                                                      PhoneNumber = "01002234498",
                                                      Email = "tec-planning_sec_head@dpworld.com", // Replace "admin" with "engineering"
                                                      NormalizedEmail = "TEC-PLANNING_SEC_HEAD@DPWORLD.COM", // Replace "admin" with "engineering"
                                                      IsActive = true,
                                                      IsEmployee = true,
                                                      Position = "TEC-Planning Section Head",
                                                      Company = "DP World",
                                                      DepartmentId = 21,
                                                      SecurityStamp = Guid.NewGuid().ToString(),
                                                      ManagerId = null,
                                                      EmailConfirmed = false,
                                                      PhoneNumberConfirmed = false,
                                                      LockoutEnabled = false,
                                                      TwoFactorEnabled = false,
                                                      AccessFailedCount = 0,
                                                  },
                                                     new User
                                                     {
                                                         Id = "51529",
                                                         UserName = "projects_sec_head", // Replace "admin" with "engineering"
                                                         NormalizedUserName = "PROJECTS_SEC_HEAD", // Replace "admin" with "engineering"
                                                         FullName = "Ahmed Zaki",
                                                         PhoneNumber = "01002234498",
                                                         Email = "projects_sec_head@dpworld.com", // Replace "admin" with "engineering"
                                                         NormalizedEmail = "PROJECTS_SEC_HEAD@DPWORLD.COM", // Replace "admin" with "engineering"
                                                         IsActive = true,
                                                         IsEmployee = true,
                                                         Position = "Projects Section Head",
                                                         Company = "DP World",
                                                         DepartmentId = 21,
                                                         SecurityStamp = Guid.NewGuid().ToString(),
                                                         ManagerId = null,
                                                         EmailConfirmed = false,
                                                         PhoneNumberConfirmed = false,
                                                         LockoutEnabled = false,
                                                         TwoFactorEnabled = false,
                                                         AccessFailedCount = 0,
                                                     }
    );

            #endregion User

            #region Department

            builder.Entity<Department>().HasData(
               new Department { Id = 1, DepartmentName = "Administration", DepartmentIcon = "Administration.svg", ManagerId = "50269" },
          new Department { Id = 2, DepartmentName = "Freight Forwarding", ManagerId = "90010" },
          new Department { Id = 3, DepartmentName = "Business Transformation", ManagerId = "51331" },
          new Department { Id = 4, DepartmentName = "Commercial", DepartmentIcon = "Commercial.svg", ManagerId = "51573" },
          new Department { Id = 5, DepartmentName = "Communications", DepartmentIcon = "Communications.svg", ManagerId = "51668" },
          new Department { Id = 6, DepartmentName = "Customer Service", DepartmentIcon = "Customer Service.svg", ManagerId = "51229" },
          new Department { Id = 7, DepartmentName = "Executive Management", ManagerId = "Exp-16" },
          new Department { Id = 8, DepartmentName = "Finance", ManagerId = "51124" },
          new Department { Id = 9, DepartmentName = "Governmental Relation", ManagerId = "50962" },
          new Department { Id = 10, DepartmentName = "HC - DUBUY Sales", ManagerId = "51573" },
          new Department { Id = 11, DepartmentName = "HC - Samsung SDS project", ManagerId = "50140" },
          new Department { Id = 12, DepartmentName = "IT", DepartmentIcon = "IT.svg", ManagerId = "51331" },
          new Department { Id = 13, DepartmentName = "OPS-Cargo & Bulk", DepartmentIcon = "OPS-BGC.svg", ManagerId = "50354" },
          new Department { Id = 14, DepartmentName = "OPS-Containers", ManagerId = "50141" },
          new Department { Id = 15, DepartmentName = "People", DepartmentIcon = "People .svg", ManagerId = "50279" },
          new Department { Id = 16, DepartmentName = "Procurement", DepartmentIcon = "Procurement.svg", ManagerId = "51188" },
          new Department { Id = 17, DepartmentName = "Projects & Facility Management", ManagerId = "51659" },
          new Department { Id = 18, DepartmentName = "QHSE", ManagerId = "50882" },
          new Department { Id = 19, DepartmentName = "Security", DepartmentIcon = "Security.svg", ManagerId = "50263" },
          new Department { Id = 20, DepartmentName = "Store", DepartmentIcon = "Stores.svg", ManagerId = "50000" },
          new Department { Id = 21, DepartmentName = "Engineering", DepartmentIcon = "Technical Engineering.svg", ManagerId = "50136" }
              );

            #endregion Department

            #region Section

            builder.Entity<Section>().HasData(
                 new Section { Id = 1, SectionName = "Administration", DepartmentId = 1 },
           new Section { Id = 2, SectionName = "Freight Forwarding", DepartmentId = 2 },
           new Section { Id = 3, SectionName = "Business Transformation", DepartmentId = 3 },
           new Section { Id = 4, SectionName = "Commercial / Containers", DepartmentId = 4, HeadId = "51509" },
           new Section { Id = 5, SectionName = "Commercial Bulk / GC", DepartmentId = 4,  HeadId = "51583" },
           new Section { Id = 6, SectionName = "Communications", DepartmentId = 5 },
           new Section { Id = 7, SectionName = "Customer Service", DepartmentId = 6 },
           new Section { Id = 8, SectionName = "Executive Management", DepartmentId = 7 },
           new Section { Id = 9, SectionName = "Finance", DepartmentId = 8 },
           new Section { Id = 10, SectionName = "Governmental Relation", DepartmentId = 9 },
           new Section { Id = 11, SectionName = "Samsung SDS project", DepartmentId = 10, HeadId = "90015" },
           new Section { Id = 12, SectionName = "DUBUY- Sales", DepartmentId = 11, HeadId = "90008" },
           new Section { Id = 13, SectionName = "IT", DepartmentId = 12 },
           new Section { Id = 14, SectionName = "OPS-Cargo & Bulk", DepartmentId = 13, HeadId = "51449" },
           new Section { Id = 15, SectionName = "OPS- DRI", DepartmentId = 13, HeadId = "50844" },
           new Section { Id = 16, SectionName = "OPS-Containers", DepartmentId = 14, HeadId = "50670" },
           new Section { Id = 17, SectionName = "OPS-CFS", DepartmentId = 14, HeadId = "50128" },
           new Section { Id = 18, SectionName = "People", DepartmentId = 15 },
           new Section { Id = 19, SectionName = "Procurement", DepartmentId = 16 },
           new Section { Id = 20, SectionName = "Projects", DepartmentId = 17 },
           new Section { Id = 21, SectionName = "Safety", DepartmentId = 18, HeadId = "51520" },
           new Section { Id = 22, SectionName = "Clinic", DepartmentId = 18 },
           new Section { Id = 23, SectionName = "Security", DepartmentId = 19 },
           new Section { Id = 24, SectionName = "Store", DepartmentId = 20 },
           new Section { Id = 25, SectionName = "TEC-Crane", DepartmentId = 21, HeadId = "51090" },
           new Section { Id = 26, SectionName = "Projects", DepartmentId = 21, HeadId = "51529" },
           new Section { Id = 27, SectionName = "TEC-Planning", DepartmentId = 21, HeadId = "50562" },
           new Section { Id = 28, SectionName = "TEC-Workshop", DepartmentId = 21, HeadId = "51126" }
               );

            #endregion Section

            #region Defined Request
            builder.Entity<DefinedRequest>().HasData(
                new DefinedRequest { Id = 1, RequestName= "PO" ,RouteName = "/Procurement/PO/" , ReviewersNumber =1, DepartmentId =16}
                );
            #endregion

            #region Defined Request Reviewers
            builder.Entity<DefinedRequestReviewer>().HasData(
                new DefinedRequestReviewer { DefinedRequestId = 1, ReviewerId = "51124" ,StageName="Finance Reviewer", StageNumber=1, ReviewerType =ReviewerType.Basic}
                );
            #endregion

            #region Add Users Roles

            builder.Entity<IdentityUserRole<string>>().HasData(
              new IdentityUserRole<string> { UserId = "51188", RoleId= ProcurementId },
              new IdentityUserRole<string> { UserId = "51124", RoleId = FinanceId }
              );

            #endregion

            #region Add Roles Permissions
            builder.Entity<DefinedRequestRole>().HasData(
             new DefinedRequestRole {  RoleId = ProcurementId, DefinedRequestId=1,Permission=Permission.Request },
             new DefinedRequestRole { RoleId = FinanceId, DefinedRequestId = 1, Permission = Permission.Review }
            );
            #endregion

            #endregion Seeding
        }
    }
}