using System;
using System.Collections.Generic;
using Tracker.Definitions;

namespace Tracker.Data.Entities
{
    public partial class UserLogin : IHaveIdentifier
    {
        public UserLogin()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public Guid Id { get; set; }

        public string EmailAddress { get; set; }

        public Guid? UserId { get; set; }

        public string UserAgent { get; set; }

        public string Browser { get; set; }

        public string OperatingSystem { get; set; }

        public string DeviceFamily { get; set; }

        public string DeviceBrand { get; set; }

        public string DeviceModel { get; set; }

        public string IpAddress { get; set; }

        public bool IsSuccessful { get; set; }

        public string FailureMessage { get; set; }

        public DateTimeOffset Created { get; set; }

        public string CreatedBy { get; set; }

        public DateTimeOffset Updated { get; set; }

        public string UpdatedBy { get; set; }

        public Byte[] RowVersion { get; set; }

        #endregion

        #region Generated Relationships
        public virtual User User { get; set; }

        #endregion

    }
}
