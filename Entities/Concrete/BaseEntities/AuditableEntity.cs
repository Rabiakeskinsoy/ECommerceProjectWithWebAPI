using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.BaseEntities
{
    /// <summary>
    /// hepsini toparlayacağımız bir class
    /// </summary>
    public class AuditableEntity : BaseEntity, ICreatedEntity,IUpdatedEntiy
    {
        public int CreatedUserId { get; set; }
        public DateTime CreatedDate { get; set; }
        int? IUpdatedEntiy.UpdatedUserId { get; set; }
        DateTime? IUpdatedEntiy.UpdatedDate { get; set; }
    }
}
