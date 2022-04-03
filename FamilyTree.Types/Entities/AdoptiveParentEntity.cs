using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTree.Types.Entities
{
    public class AdoptiveParentEntity : BasePeriodEntity
    {
        public AdoptiveParentTypeEntity Type { get; set; }
        public PersonEntity Person { get; set; }
    }
}
