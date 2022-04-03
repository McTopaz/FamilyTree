using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTree.Types.Entities
{
    public class AddressEntity : BasePeriodEntity
    {
        public RegionEntity Region { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
    }
}
