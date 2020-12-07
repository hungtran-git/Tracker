using System;
using System.Collections.Generic;
using Tracker.Definitions;

namespace Tracker.Data.Entities
{
    public partial class TaskExtended : IHaveIdentifier
    {
        public TaskExtended()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public Guid Id { get; set; }
        public Guid TaskId { get; set; }

        public string UserAgent { get; set; }

        public string Browser { get; set; }

        public string OperatingSystem { get; set; }

        public DateTimeOffset Created { get; set; }

        public string CreatedBy { get; set; }

        public DateTimeOffset Updated { get; set; }

        public string UpdatedBy { get; set; }

        public Byte[] RowVersion { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Task Task { get; set; }

        #endregion

    }
}
