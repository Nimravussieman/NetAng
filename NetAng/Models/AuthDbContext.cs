using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
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
        { }
       


        public DbSet<Account> Accounts { get; set; }
        //public DbSet<AccountCompanyFieldsPermissions> AccountCompanyFieldsPermissions { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<AddressType> AddressTypes { get; set; }
        public DbSet<BankDetails> BankDetails { get; set; }
        public DbSet<BooleanField> BooleanFields { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Company> Companies { get; set; }
        //public DbSet<CompanyFieldsPermissions> CompanyFieldsPermissions { get; set; }
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
        //public DbSet<OperationFieldsPermissions> OperationFieldsPermissions { get; set; }
        public DbSet<OperationType> OperationTypes { get; set; }
        public DbSet<Phase> Phases { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<PhoneType> PhoneTypes { get; set; }
        public DbSet<Product> Products { get; set; }
        //public DbSet<ProductFieldsPermissions> ProductFieldsPermissions { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<OperationSource> OperationSources { get; set; }
        public DbSet<StringField> StringFields { get; set; }
        public DbSet<Url> Urls { get; set; }
        public DbSet<UrlType> UrlTypes { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Account>().ToTable("Account");
            //modelBuilder.Entity<Contact>().ToTable("Contact");
            //modelBuilder.Entity<Address>().ToTable("Address");

            modelBuilder.Entity<ApplicationUser>(entity => entity.Property(a => a.IsAdmin).HasValueGenerator<AccountGenerator>());            //modelBuilder.Entity<ApplicationUser>(entity => entity.Property(a => a.Account).HasValueGenerator<AccountGenerator>());
            //modelBuilder.Entity<ApplicationUser>().HasOne(a=>a.Account).WithMany(x => x.Addresses).HasForeignKey(x => x);


            modelBuilder
            .Entity<ApplicationUser>()
            .HasOne(u => u.Account)
            .WithOne(p => p.ApplicationUser)
            .HasForeignKey<Account>(p => p.ApplicationUserId);
            //modelBuilder.Entity<ApplicationUser>().ToTable("AspNetUsers");
            //modelBuilder.Entity<Account>().ToTable("AspNetUsers");

            //modelBuilder.Entity<ApplicationUser>().OwnsOne(i => i.Account, a =>
            //{
            //    a.OwnsOne(c => c.Permissions);
            //});
            //modelBuilder.Entity<ApplicationUser>().OwnsOne(i => i.Account);
            modelBuilder.Entity<Account>().OwnsOne(i => i.Permissions);
            modelBuilder.Entity<Company>().OwnsOne(i => i.Permissions);
            modelBuilder.Entity<Contact>().OwnsOne(i => i.Permissions);
            modelBuilder.Entity<Operation>().OwnsOne(i => i.Permissions);
            modelBuilder.Entity<Product>().OwnsOne(i => i.Permissions);
            modelBuilder.Entity<Contact>().OwnsOne(i => i.Name);

            //modelBuilder.Entity<Contact>().Property(c => c.Name.Name)
            //    //.HasComputedColumnSql("[UserNames.LastName] + ' '+ [UserNames.FirstName]+ ' '+ [UserNames.SurName]", stored: true);
            //.HasComputedColumnSql(@"""FirstName"" || ' ' || ""LastName""|| ' ' || ""SurName""", stored: true);//    for PostgresSQL
            
            //modelBuilder.ApplyConfiguration(new EntityDbConfigurationForUsrName());
            modelBuilder.ApplyConfiguration(new EntityDbConfigurationForProduct());
            //modelBuilder.ApplyConfiguration(new EntityDbConfigurationForProductFieldsPermissions());
            //modelBuilder.ApplyConfiguration(new EntityDbConfigurationForAccountCompanyFieldsPermissions());
            //modelBuilder.ApplyConfiguration(new EntityDbConfigurationForOperationFieldsPermissions());
            //modelBuilder.ApplyConfiguration(new EntityDbConfigurationForContactFieldsPermissions());
            //modelBuilder.ApplyConfiguration(new EntityDbConfigurationForCompanyFieldPermissions());

        }
    }

    public class EntityDbConfigurationForCompanyFieldPermissions : IEntityTypeConfiguration<CompanyFieldsPermissions>
    {
        public void Configure(EntityTypeBuilder<CompanyFieldsPermissions> builder)
        {
            //builder.Property(e => e.Id).UseIdentityColumn();
            builder.Property(e => e.IsPublic).HasDefaultValue(true);
            builder.Property(e => e.MessangerUrls_IsPublic).HasDefaultValue(true);
            builder.Property(e => e.NumericFields_IsPublic).HasDefaultValue(false);
            builder.Property(e => e.Permissions_IsPublic).HasDefaultValue(false);
            builder.Property(e => e.Phones_IsPublic).HasDefaultValue(true);
            builder.Property(e => e.Sites_IsPublic).HasDefaultValue(true);
            builder.Property(e => e.StringFields_IsPublic).HasDefaultValue(false);
            builder.Property(e => e.UrlsFields_IsPublic).HasDefaultValue(false);
            builder.Property(e => e.Addresses_IsPublic).HasDefaultValue(true);
            builder.Property(e => e.BankDetails_IsPublic).HasDefaultValue(false);
            builder.Property(e => e.Description_IsPublic).HasDefaultValue(true);
            builder.Property(e => e.Contacts_IsPublic).HasDefaultValue(false);
            builder.Property(e => e.DateTimeFields_IsPublic).HasDefaultValue(false);
            builder.Property(e => e.Details_IsPublic).HasDefaultValue(false);
            builder.Property(e => e.Emails_IsPublic).HasDefaultValue(true);
            builder.Property(e => e.Employees_IsPublic).HasDefaultValue(false);
            builder.Property(e => e.FileFields_IsPublic).HasDefaultValue(false);
            builder.Property(e => e.BooleanFields_IsPublic).HasDefaultValue(false);
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
            //builder.Property(e => e.Id).UseIdentityColumn();
            builder.Property(e => e.IsPublic).HasDefaultValue(false);
            builder.Property(e => e.Addresses_IsPublic).HasDefaultValue(true);
            builder.Property(e => e.Companies_IsPublic).HasDefaultValue(false);
            builder.Property(e => e.ContactSource_IsPublic).HasDefaultValue(true);
            builder.Property(e => e.ContactType_IsPublic).HasDefaultValue(true);
            builder.Property(e => e.DateOfBirth_IsPublic).HasDefaultValue(true);
            builder.Property(e => e.Description_IsPublic).HasDefaultValue(false);
            builder.Property(e => e.Details_IsPublic).HasDefaultValue(false);
            builder.Property(e => e.Emails_IsPublic).HasDefaultValue(true);
            builder.Property(e => e.MessangerUrls_IsPublic).HasDefaultValue(true);
            builder.Property(e => e.Phones_IsPublic).HasDefaultValue(true);
            builder.Property(e => e.Photo_IsPublic).HasDefaultValue(true);
            builder.Property(e => e.Position_IsPublic).HasDefaultValue(true);
            builder.Property(e => e.Sites_IsPublic).HasDefaultValue(true);
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
            //builder.Property(e => e.Id).UseIdentityColumn();
            builder.Property(e => e.IsPublic).HasDefaultValue(false);
            builder.Property(e => e.CreateDate_IsPublic).HasDefaultValue(false);
            builder.Property(e => e.DateOfChange_IsPublic).HasDefaultValue(false);
            builder.Property(e => e.DateTimeFields_IsPublic).HasDefaultValue(false);
            builder.Property(e => e.Description_IsPublic).HasDefaultValue(true);
            builder.Property(e => e.FileFields_IsPublic).HasDefaultValue(false);
            builder.Property(e => e.Images_IsPublic).HasDefaultValue(true);
            builder.Property(e => e.IsActive).HasDefaultValue(true);
            builder.Property(e => e.MeasurementUnit_IsPublic).HasDefaultValue(false);
            builder.Property(e => e.Name_IsPublic).HasDefaultValue(true);
            builder.Property(e => e.NumericFields_IsPublic).HasDefaultValue(false);
            builder.Property(e => e.Permissions_IsPublic).HasDefaultValue(false);
            builder.Property(e => e.Price_IsPublic).HasDefaultValue(true);
            builder.Property(e => e.Quantity_IsPublic).HasDefaultValue(false);
            builder.Property(e => e.SortIndex_IsPublic).HasDefaultValue(false);
            builder.Property(e => e.StartActivityDate_IsPublic).HasDefaultValue(false);
            builder.Property(e => e.StopActivityDate_IsPublic).HasDefaultValue(false);
            builder.Property(e => e.StringFields_IsPublic).HasDefaultValue(false);
            builder.Property(e => e.UrlsFields_IsPublic).HasDefaultValue(true);
        }
    }
    public class EntityDbConfigurationForAccountCompanyFieldsPermissions : IEntityTypeConfiguration<AccountCompanyFieldsPermissions>
    {
        public void Configure(EntityTypeBuilder<AccountCompanyFieldsPermissions> builder)
        {
            //builder.Property(e => e.Id).UseIdentityColumn();
            builder.Property(e => e.IsPublic).HasDefaultValue(true);
            builder.Property(e => e.Currency_IsPublic).HasDefaultValue(false);
            builder.Property(e => e.Currency_IsPublic).HasDefaultValue(false);
            builder.Property(e => e.Products_IsPublic).HasDefaultValue(false);
            builder.Property(e => e.Products_IsPublic).HasDefaultValue(false);
            builder.Property(e => e.Projects_IsPublic).HasDefaultValue(false);
            builder.Property(e => e.Projects_IsPublic).HasDefaultValue(false);
            builder.Property(e => e.Jobs_IsPublic).HasDefaultValue(false);
            builder.Property(e => e.Jobs_IsPublic).HasDefaultValue(false);
            builder.Property(e => e.Companies_IsPublic).HasDefaultValue(false);
            builder.Property(e => e.Companies_IsPublic).HasDefaultValue(false);
            builder.Property(e => e.ImageLogo_IsPublic).HasDefaultValue(false);
            builder.Property(e => e.ImageLogo_IsPublic).HasDefaultValue(false);
            builder.Property(e => e.FieldOfActivities_IsPublic).HasDefaultValue(false);
            builder.Property(e => e.FieldOfActivities_IsPublic).HasDefaultValue(false);
            builder.Property(e => e.Phones_IsPublic).HasDefaultValue(false);
            builder.Property(e => e.Phones_IsPublic).HasDefaultValue(false);
            builder.Property(e => e.Emails_IsPublic).HasDefaultValue(false);
            builder.Property(e => e.Emails_IsPublic).HasDefaultValue(false);
            builder.Property(e => e.Sites_IsPublic).HasDefaultValue(false);
            builder.Property(e => e.Sites_IsPublic).HasDefaultValue(false);
            builder.Property(e => e.MessangerUrls_IsPublic).HasDefaultValue(false);
            builder.Property(e => e.MessangerUrls_IsPublic).HasDefaultValue(false);
            builder.Property(e => e.Contacts_IsPublic).HasDefaultValue(false);
            builder.Property(e => e.Contacts_IsPublic).HasDefaultValue(false);
            builder.Property(e => e.Addresses_IsPublic).HasDefaultValue(false);
            builder.Property(e => e.Addresses_IsPublic).HasDefaultValue(false);
            builder.Property(e => e.Employees_IsPublic).HasDefaultValue(false);
            builder.Property(e => e.Employees_IsPublic).HasDefaultValue(false);
            builder.Property(e => e.Details_IsPublic).HasDefaultValue(false);
            builder.Property(e => e.Details_IsPublic).HasDefaultValue(false);
            builder.Property(e => e.BankDetails_IsPublic).HasDefaultValue(false);
            builder.Property(e => e.BankDetails_IsPublic).HasDefaultValue(false);
            builder.Property(e => e.Description_IsPublic).HasDefaultValue(false);
            builder.Property(e => e.Description_IsPublic).HasDefaultValue(false);
            builder.Property(e => e.StringFields_IsPublic).HasDefaultValue(false);
            builder.Property(e => e.NumericFields_IsPublic).HasDefaultValue(false);
            builder.Property(e => e.NumericFields_IsPublic).HasDefaultValue(false);
            builder.Property(e => e.DateTimeFields_IsPublic).HasDefaultValue(false);
            builder.Property(e => e.DateTimeFields_IsPublic).HasDefaultValue(false);
            builder.Property(e => e.UrlsFields_IsPublic).HasDefaultValue(false);
            builder.Property(e => e.UrlsFields_IsPublic).HasDefaultValue(false);
            builder.Property(e => e.FileFields_IsPublic).HasDefaultValue(false);
            builder.Property(e => e.FileFields_IsPublic).HasDefaultValue(false);
            builder.Property(e => e.ImageFields_IsPublic).HasDefaultValue(false);
            builder.Property(e => e.ImageFields_IsPublic).HasDefaultValue(false);
            builder.Property(e => e.BooleanFields_IsPublic).HasDefaultValue(false);
            builder.Property(e => e.BooleanFields_IsPublic).HasDefaultValue(false);
            builder.Property(e => e.Operations_IsPublic).HasDefaultValue(false);
            builder.Property(e => e.Operations_IsPublic).HasDefaultValue(false);
            builder.Property(e => e.Permissions_IsPublic).HasDefaultValue(false);
            builder.Property(e => e.Permissions_IsPublic).HasDefaultValue(false);
        }
    }
    public class EntityDbConfigurationForOperationFieldsPermissions : IEntityTypeConfiguration<OperationFieldsPermissions>
    {
        public void Configure(EntityTypeBuilder<OperationFieldsPermissions> builder)
        {
            //builder.Property(e => e.Id).UseIdentityColumn();
            builder.Property(e => e.IsPublic).HasDefaultValue(true);
            builder.Property(e => e.Amount_IsPublic).HasDefaultValue(true);
            builder.Property(e => e.CreateDate_IsPublic).HasDefaultValue(true);
            builder.Property(e => e.DateOfChange_IsPublic).HasDefaultValue(false);
            builder.Property(e => e.EndDate_IsPublic).HasDefaultValue(true);
            builder.Property(e => e.Phase_IsPublic).HasDefaultValue(true);
            builder.Property(e => e.TypeOfOperation_IsPublic).HasDefaultValue(true);
            builder.Property(e => e.Description_IsPublic).HasDefaultValue(true);
            builder.Property(e => e.AvailableToEveryone_IsPublic).HasDefaultValue(false);
            builder.Property(e => e.Contacts_IsPublic).HasDefaultValue(false);
            builder.Property(e => e.Contractors_IsPublic).HasDefaultValue(false);
            builder.Property(e => e.Permissions_IsPublic).HasDefaultValue(false);
        }
    }




    public class AccountGenerator : Microsoft.EntityFrameworkCore.ValueGeneration.ValueGenerator
    {
        public override bool GeneratesTemporaryValues => false;
        //private readonly AMCDbContext db;
        //public SampleIDGenerator(AMCDbContext context)
        //{
        //    db = context;
        //}
        protected override object NextValue(EntityEntry entry)
        {
            AuthDbContext db = (AuthDbContext)entry.Context;
            Account account = new Account();
            //account.Permissions = new AccountCompanyFieldsPermissions();
            db.Accounts.Add(account);
            ((ApplicationUser)(entry.Entity)).Account = account;
            return true;
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
