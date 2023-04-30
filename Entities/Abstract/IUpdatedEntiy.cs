using System;

namespace Entities.Abstract
{
    public interface IUpdatedEntiy
    {
        int? UpdatedUserId { get; set; }
        DateTime? UpdatedDate { get; set; }
    }
}
