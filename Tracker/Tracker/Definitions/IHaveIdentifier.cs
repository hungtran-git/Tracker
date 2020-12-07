using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tracker.Definitions
{
    public interface IHaveIdentifier
    {
        Guid Id { get; set; }
    }
}
