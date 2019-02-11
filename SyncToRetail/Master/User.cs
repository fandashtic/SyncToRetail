using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncToRetail
{
    public class User
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

    public class Users
    {
        public string UserId { get; set; }
        public User User { get; set; }
    }
}
