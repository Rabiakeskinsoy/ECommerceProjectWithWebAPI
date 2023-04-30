using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
 /// <summary>
 /// veritabanında karışılık gelen tablolarda olacak. eğer benim veritabanında user tablom var ise ben inreface bunu imlemente edeceğim
 /// Ientity imlement edilmiş bir class gördüğümde bunun karşılığı veritabanındada var
 /// </summary>
   public interface IEntity
    {
        int Id { get; set; }
    }
}
