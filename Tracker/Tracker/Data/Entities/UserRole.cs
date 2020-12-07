using System;
using System.Collections.Generic;
using Tracker.Definitions;

namespace Tracker.Data.Entities
{
    public partial class UserRole : IHaveIdentifier
    {
        public UserRole()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public Guid UserId { get; set; }

        public Guid RoleId { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Role Role { get; set; }

        public virtual User User { get; set; }
        public Guid Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        #endregion

    }
}
