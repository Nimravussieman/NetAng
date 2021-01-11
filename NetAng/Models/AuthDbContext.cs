using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetAng.Models
{
    class test : IOptions<OperationalStoreOptions>
    {
        public OperationalStoreOptions Value => null;
    }
    public class AuthDbContext : ApiAuthorizationDbContext<ApplicationUser>//Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityDbContext<ApplicationUser>//
    {
        public AuthDbContext(
            DbContextOptions<AuthDbContext> options,
            IOptions<OperationalStoreOptions> operationalStoreOptions)
            : base(options, operationalStoreOptions)
        {
        }


        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountCompanyFieldsPermissions> AccountCompanyFieldsPermissions { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<AddressType> AddressTypes { get; set; }
        public DbSet<BankDetails> BankDetails { get; set; }
        public DbSet<BooleanField> BooleanFields { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<CompanyFieldsPermissions> CompanyFieldsPermissions { get; set; }
        public DbSet<ContactSource> ContactSources { get; set; }
        public DbSet<CompanyType> CompanyTypes { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ContactType> ContactTypes { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<DateTimeField> DateTimeFields { get; set; }
        public DbSet<Details> Details { get; set; }
        public DbSet<DetailsType> DetailsTypes { get; set; }
        public DbSet<Email> Emails { get; set; }
        public DbSet<EmailType> EmailTypes { get; set; }
        public DbSet<Employe> Employes { get; set; }
        public DbSet<FieldOfActivity> FieldOfActivities { get; set; }
        public DbSet<File> Files { get; set; }
        public DbSet<FileField> FileFields { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<ImageField> ImageFields { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<MeasurementUnit> MeasurementUnits { get; set; }
        public DbSet<MessangerUrl> MessangerUrls { get; set; }
        public DbSet<MessangerUrlType> MessangerUrlTypes { get; set; }
        public DbSet<Money> Money { get; set; }
        public DbSet<MoneyField> MoneyFields { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<NotificationType> NotificationTypes { get; set; }
        public DbSet<Operation> Operations { get; set; }
        public DbSet<OperationFieldsPermissions> OperationFieldsPermissions { get; set; }
        public DbSet<OperationType> OperationTypes { get; set; }
        public DbSet<Phase> Phases { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<PhoneType> PhoneTypes { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductFieldsPermissions> ProductFieldsPermissions { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<OperationSource> OperationSources { get; set; }
        public DbSet<StringField> StringFields { get; set; }
        public DbSet<Url> Urls { get; set; }
        public DbSet<UrlType> UrlTypes { get; set; }
        public DbSet<UserName> UserNames { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);//necessary !!!!!!!!!!!!!!!!!!!!!!!
            //    modelBuilder.ApplyConfiguration(new MyEntityDbConfiguration());            //modelBuilder.Entity<CompanyFieldsPermissions>().Property(c => c.IsPublic).HasDefaultValue(true);
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            modelBuilder.Entity<ApplicationUser>().HasOne(u => u.Account).WithMany().HasForeignKey(a=>a.Id);

            modelBuilder.Entity<UserName>().Property(c => c.Name)
                //.HasComputedColumnSql("[UserNames.LastName] + ' '+ [UserNames.FirstName]+ ' '+ [UserNames.SurName]", stored: true);
            .HasComputedColumnSql(@"""FirstName"" || ' ' || ""LastName""|| ' ' || ""SurName""", stored: true);//    for PostgresSQL
            
            modelBuilder.ApplyConfiguration(new EntityDbConfigurationForCompanyFieldPermissions());
            //modelBuilder.ApplyConfiguration(new EntityDbConfigurationForUsrName());
            modelBuilder.ApplyConfiguration(new EntityDbConfigurationForContactFieldsPermissions());
            modelBuilder.ApplyConfiguration(new EntityDbConfigurationForProduct());
            modelBuilder.ApplyConfiguration(new EntityDbConfigurationForProductFieldsPermissions());
            modelBuilder.ApplyConfiguration(new EntityDbConfigurationForAccountCompanyFieldsPermissions());
            modelBuilder.ApplyConfiguration(new EntityDbConfigurationForOperationFieldsPermissions());
        }
    }
    //public class MyEntityDbConfiguration : IEntityTypeConfiguration<Url>//  =>  for Url table
    //{
    //    public void Configure(EntityTypeBuilder<Url> builder)
    //    {
    //        builder.Property(e => e.Link).HasConversion(v => v.ToString(), v => new Uri(v));
    //    }
    //}
    public class EntityDbConfigurationForCompanyFieldPermissions : IEntityTypeConfiguration<CompanyFieldsPermissions>
    {
        public void Configure(EntityTypeBuilder<CompanyFieldsPermissions> builder)
        {
            builder.Property(e => e.Id).UseIdentityColumn();
            builder.Property(e => e.IsPublic).HasDefaultValue(true);
            builder.Property(e => e.MessangerUrlsIsPublic).HasDefaultValue(true);
            builder.Property(e => e.NumericFieldsIsPublic).HasDefaultValue(false);
            builder.Property(e => e.PermissionsIsPublic).HasDefaultValue(false);
            builder.Property(e => e.PhonesIsPublic).HasDefaultValue(true);
            builder.Property(e => e.SitesIsPublic).HasDefaultValue(true);
            builder.Property(e => e.StringFieldsIsPublic).HasDefaultValue(false);
            builder.Property(e => e.UrlsFieldsIsPublic).HasDefaultValue(false);
            builder.Property(e => e.AddressesIsPublic).HasDefaultValue(true);
            builder.Property(e => e.BankDetailsIsPublic).HasDefaultValue(false);
            builder.Property(e => e.DescriptionIsPublic).HasDefaultValue(true);
            builder.Property(e => e.ContactsIsPublic).HasDefaultValue(false);
            builder.Property(e => e.DateTimeFieldsIsPublic).HasDefaultValue(false);
            builder.Property(e => e.DetailsIsPublic).HasDefaultValue(false);
            builder.Property(e => e.EmailsIsPublic).HasDefaultValue(true);
            builder.Property(e => e.EmployeesIsPublic).HasDefaultValue(false);
            builder.Property(e => e.FileFieldsIsPublic).HasDefaultValue(false);
            builder.Property(e => e.BooleanFieldsIsPublic).HasDefaultValue(false);
        }
    }
    //public class EntityDbConfigurationForUsrName : IEntityTypeConfiguration<UserName>
    //{
    //    public void Configure(EntityTypeBuilder<UserName> builder)
    //    {
    //        //builder.Property(e => e.Id).UseIdentityColumn();
    //        builder.Property(e => e.FirstName).HasDefaultValue("");
    //        builder.Property(e => e.LastName).HasDefaultValue("");
    //        builder.Property(u => u.Name).HasComputedColumnSql("[FirstName] + ' ' + [LastName]");
    //    }
    //}
    public class EntityDbConfigurationForContactFieldsPermissions : IEntityTypeConfiguration<ContactFieldsPermissions>
    {
        public void Configure(EntityTypeBuilder<ContactFieldsPermissions> builder)
        {
            builder.Property(e => e.Id).UseIdentityColumn();
            builder.Property(e => e.IsPublic).HasDefaultValue(false);
            builder.Property(e => e.AddressesIsPublic).HasDefaultValue(true);
            builder.Property(e => e.CompaniesIsPublic).HasDefaultValue(false);
            builder.Property(e => e.ContactSourceIsPublic).HasDefaultValue(true);
            builder.Property(e => e.ContactTypeIsPublic).HasDefaultValue(true);
            builder.Property(e => e.DateOfBirthIsPublic).HasDefaultValue(true);
            builder.Property(e => e.DescriptionIsPublic).HasDefaultValue(false);
            builder.Property(e => e.DetailsIsPublic).HasDefaultValue(false);
            builder.Property(e => e.EmailsIsPublic).HasDefaultValue(true);
            builder.Property(e => e.MessangerUrlsIsPublic).HasDefaultValue(true);
            builder.Property(e => e.PhonesIsPublic).HasDefaultValue(true);
            builder.Property(e => e.PhotoIsPublic).HasDefaultValue(true);
            builder.Property(e => e.PositionIsPublic).HasDefaultValue(true);
            builder.Property(e => e.SitesIsPublic).HasDefaultValue(true);
        }
    }
    public class EntityDbConfigurationForProduct : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(e => e.Id).UseIdentityColumn();
            builder.Property(e => e.SortIndex).HasDefaultValue(1);
        }
}
    public class EntityDbConfigurationForProductFieldsPermissions : IEntityTypeConfiguration<ProductFieldsPermissions>
    {
        public void Configure(EntityTypeBuilder<ProductFieldsPermissions> builder)
        {
            builder.Property(e => e.Id).UseIdentityColumn();
            builder.Property(e => e.IsPublic).HasDefaultValue(false);
            builder.Property(e => e.CreateDateIsPublic).HasDefaultValue(false);
            builder.Property(e => e.DateOfChangeIsPublic).HasDefaultValue(false);
            builder.Property(e => e.DateTimeFieldsIsPublic).HasDefaultValue(false);
            builder.Property(e => e.DescriptionIsPublic).HasDefaultValue(true);
            builder.Property(e => e.FileFieldsIsPublic).HasDefaultValue(false);
            builder.Property(e => e.Id).HasDefaultValue(false);
            builder.Property(e => e.ImagesIsPublic).HasDefaultValue(true);
            builder.Property(e => e.IsActive).HasDefaultValue(true);
            builder.Property(e => e.MeasurementUnitIsPublic).HasDefaultValue(false);
            builder.Property(e => e.NameIsPublic).HasDefaultValue(true);
            builder.Property(e => e.NumericFieldsIsPublic).HasDefaultValue(false);
            builder.Property(e => e.PermissionsIsPublic).HasDefaultValue(false);
            builder.Property(e => e.PriceIsPublic).HasDefaultValue(true);
            builder.Property(e => e.QuantityIsPublic).HasDefaultValue(false);
            builder.Property(e => e.SortIndexIsPublic).HasDefaultValue(false);
            builder.Property(e => e.StartActivityDateIsPublic).HasDefaultValue(false);
            builder.Property(e => e.StopActivityDateIsPublic).HasDefaultValue(false);
            builder.Property(e => e.StringFieldsIsPublic).HasDefaultValue(false);
            builder.Property(e => e.UrlsFieldsIsPublic).HasDefaultValue(true);
        }
    }
    public class EntityDbConfigurationForAccountCompanyFieldsPermissions : IEntityTypeConfiguration<AccountCompanyFieldsPermissions>
    {
        public void Configure(EntityTypeBuilder<AccountCompanyFieldsPermissions> builder)
        {
            builder.Property(e => e.Id).UseIdentityColumn();
            builder.Property(e => e.IsPublic).HasDefaultValue(true);
            builder.Property(e => e.CurrencyIsPublic).HasDefaultValue(false);
            builder.Property(e => e.CurrencyIsVisible).HasDefaultValue(false);
            builder.Property(e => e.ProductsIsPublic).HasDefaultValue(false);
            builder.Property(e => e.ProductssVisible).HasDefaultValue(false);
            builder.Property(e => e.ProjectsIsPublic).HasDefaultValue(false);
            builder.Property(e => e.ProjectssVisible).HasDefaultValue(false);
            builder.Property(e => e.JobsIsPublic).HasDefaultValue(false);
            builder.Property(e => e.JobssVisible).HasDefaultValue(false);
            builder.Property(e => e.CompaniesIsPublic).HasDefaultValue(false);
            builder.Property(e => e.CompaniessVisible).HasDefaultValue(false);
            builder.Property(e => e.ImageLogoIsPublic).HasDefaultValue(false);
            builder.Property(e => e.ImageLogosVisible).HasDefaultValue(false);
            builder.Property(e => e.FieldOfActivitiesIsPublic).HasDefaultValue(false);
            builder.Property(e => e.FieldOfActivitiessVisible).HasDefaultValue(false);
            builder.Property(e => e.PhonesIsPublic).HasDefaultValue(false);
            builder.Property(e => e.PhonessVisible).HasDefaultValue(false);
            builder.Property(e => e.EmailsIsPublic).HasDefaultValue(false);
            builder.Property(e => e.EmailssVisible).HasDefaultValue(false);
            builder.Property(e => e.SitesIsPublic).HasDefaultValue(false);
            builder.Property(e => e.SitessVisible).HasDefaultValue(false);
            builder.Property(e => e.MessangerUrlsIsPublic).HasDefaultValue(false);
            builder.Property(e => e.MessangerUrlssVisible).HasDefaultValue(false);
            builder.Property(e => e.ContactsIsPublic).HasDefaultValue(false);
            builder.Property(e => e.ContactssVisible).HasDefaultValue(false);
            builder.Property(e => e.AddressesIsPublic).HasDefaultValue(false);
            builder.Property(e => e.AddressessVisible).HasDefaultValue(false);
            builder.Property(e => e.EmployeesIsPublic).HasDefaultValue(false);
            builder.Property(e => e.EmployeessVisible).HasDefaultValue(false);
            builder.Property(e => e.DetailsIsPublic).HasDefaultValue(false);
            builder.Property(e => e.DetailssVisible).HasDefaultValue(false);
            builder.Property(e => e.BankDetailsIsPublic).HasDefaultValue(false);
            builder.Property(e => e.BankDetailssVisible).HasDefaultValue(false);
            builder.Property(e => e.DescriptionIsPublic).HasDefaultValue(false);
            builder.Property(e => e.DescriptionsVisible).HasDefaultValue(false);
            builder.Property(e => e.StringFieldssVisible).HasDefaultValue(false);
            builder.Property(e => e.NumericFieldsIsPublic).HasDefaultValue(false);
            builder.Property(e => e.NumericFieldssVisible).HasDefaultValue(false);
            builder.Property(e => e.DateTimeFieldsIsPublic).HasDefaultValue(false);
            builder.Property(e => e.DateTimeFieldssVisible).HasDefaultValue(false);
            builder.Property(e => e.UrlsFieldsIsPublic).HasDefaultValue(false);
            builder.Property(e => e.UrlsFieldssVisible).HasDefaultValue(false);
            builder.Property(e => e.FileFieldsIsPublic).HasDefaultValue(false);
            builder.Property(e => e.FileFieldssVisible).HasDefaultValue(false);
            builder.Property(e => e.ImageFieldsIsPublic).HasDefaultValue(false);
            builder.Property(e => e.ImageFieldssVisible).HasDefaultValue(false);
            builder.Property(e => e.BooleanFieldsIsPublic).HasDefaultValue(false);
            builder.Property(e => e.BooleanFieldssVisible).HasDefaultValue(false);
            builder.Property(e => e.OperationsIsPublic).HasDefaultValue(false);
            builder.Property(e => e.OperationssVisible).HasDefaultValue(false);
            builder.Property(e => e.PermissionsIsPublic).HasDefaultValue(false);
            builder.Property(e => e.PermissionssVisible).HasDefaultValue(false);
        }
    }
    public class EntityDbConfigurationForOperationFieldsPermissions : IEntityTypeConfiguration<OperationFieldsPermissions>
    {
        public void Configure(EntityTypeBuilder<OperationFieldsPermissions> builder)
        {
            builder.Property(e => e.Id).UseIdentityColumn();
            builder.Property(e => e.IsPublic).HasDefaultValue(true);
            builder.Property(e => e.Amount).HasDefaultValue(true);
            builder.Property(e => e.CreateDate).HasDefaultValue(true);
            builder.Property(e => e.DateOfChange).HasDefaultValue(false);
            builder.Property(e => e.EndDate).HasDefaultValue(true);
            builder.Property(e => e.Phase ).HasDefaultValue(true);
            builder.Property(e => e.TypeOfOperation).HasDefaultValue(true);
            builder.Property(e => e.Description ).HasDefaultValue(true);
            builder.Property(e => e.AvailableToEveryone).HasDefaultValue(false);
            builder.Property(e => e.Contacts).HasDefaultValue(false);
            builder.Property(e => e.Contractors ).HasDefaultValue(false);
            builder.Property(e => e.Permissions ).HasDefaultValue(false);
        }
    }

}



























//public class AuthDbContext : ApiAuthorizationDbContext<ApplicationUser>
//{
//    public AuthDbContext(
//        DbContextOptions<AuthDbContext> options,
//        IOptions<OperationalStoreOptions> operationalStoreOptions)
//        : base(options, operationalStoreOptions)
//    {
//    }

//    protected override void OnModelCreating(ModelBuilder builder)
//    {

//        base.OnModelCreating(builder);
//        // Customize the ASP.NET Identity model and override the defaults if needed.
//        // For example, you can rename the ASP.NET Identity table names and more.
//        // Add your customizations after calling base.OnModelCreating(builder);
//    }
//}
