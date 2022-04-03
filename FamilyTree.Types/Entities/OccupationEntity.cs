using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTree.Types.Entities
{
    public class OccupationEntity : BasePeriodEntity
    {
        public string Name { get; set; }
        public RegionEntity Region { get; set; }
    }
}
