using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncToRetail
{
    public class Temp
    {
        public Centres Centres { get; set; }
        public List<Users1> Users1 { get; set; }
    }

    public class Users1
    {
        public string UserId { get; set; }
        public string ExternalId { get; set; }
        public string FirstName { get; set; }
        public string AdditionalFirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string PasswordSalt { get; set; }
        public string Email1 { get; set; }
        public string Email2 { get; set; }
        public string ReceiveEmails { get; set; }
        public string ProfilePhotoId { get; set; }
        public string LastLogOnDate { get; set; }
        public string IsPasswordChangeRequired { get; set; }
        public string LastPasswordChangeDate { get; set; }
        public string FailedPasswordAttemptCount { get; set; }
        public string FailedPasswordAttemptWindowStart { get; set; }
        public string PasswordResetCode { get; set; }
        public string PasswordResetDate { get; set; }
        public string UserTypeId { get; set; }
        public string ApprovalStatusId { get; set; }
        public string DateCreated { get; set; }
        public string CreatedByUserId { get; set; }
        public string LastModified { get; set; }
        public string LastModifiedByUserId { get; set; }
        public string IsDeleted { get; set; }
        public string IsTermsAgreedTo { get; set; }
        public string ShowGettingStarted { get; set; }
        public string WelcomeEmailSent { get; set; }
        public string LastWelcomeEmailSentDate { get; set; }
        public string HeadOfficeId { get; set; }
        public string LastLogOnDateByMobileDevice { get; set; }
        public string ReceivePushNotifications { get; set; }
        public string SourceId { get; set; }
        public string NumericPasswordResetCode { get; set; }
        public string IsDefaultUser { get; set; }

    }

    public class Centres
    {
        public string CentreId { get; set; }
        public string ExternalId { get; set; }
        public string ShortName { get; set; }
        public string Name { get; set; }
        public string CompanyNumber { get; set; }
        public string BusinessContactEmail { get; set; }
        public string CentreEmail { get; set; }
        public string Website { get; set; }
        public string CountryId { get; set; }
        public string MainPhone { get; set; }
        public string AlternatePhone { get; set; }
        public string Fax { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Postcode { get; set; }
        public string TimeZoneId { get; set; }
        public string ThemeId { get; set; }
        public string LogoFileName { get; set; }
        public string RestrictByIP { get; set; }
        public string PasswordExpiry { get; set; }
        public string PasswordRulesId { get; set; }
        public string PaymentFrequencyId { get; set; }
        public string AccountTypeId { get; set; }
        public string DeactivationDate { get; set; }
        public string MaxLicencedActiveChildren { get; set; }
        public string MaxLicencedInactiveChildren { get; set; }
        public string IsChildrensUpdatesEnabled { get; set; }
        public string IsFormsEnabled { get; set; }
        public string IsLearningJourneysEnabled { get; set; }
        public string IsNewsEnabled { get; set; }
        public string IsPoliciesEnabled { get; set; }
        public string DateCreated { get; set; }
        public string CreatedByUserId { get; set; }
        public string LastModified { get; set; }
        public string LastModifiedByUserId { get; set; }
        public string IsActive { get; set; }
        public string IsProgrammingEnabled { get; set; }
        public string CentreTypeId { get; set; }
        public string IsProvisioned { get; set; }
        public string HeadOfficeId { get; set; }
        public string IsTasksEnabled { get; set; }
        public string VimeoAlbumId { get; set; }
        public string IsParentCommunicationEnabled { get; set; }
        public string IsRatioEnabled { get; set; }
        public string IsTransitionStatementsEnabled { get; set; }
        public string IsCustomFieldEnabled { get; set; }
        public string IsPostApprovalsEnabled { get; set; }

    }

}
