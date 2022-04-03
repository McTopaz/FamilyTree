using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTree.Types.Entities
{
    public class RegionEntity : BaseEntity
    {
        public string Name { get; set; }
        public string PostCode { get; set; }
        public RegionEntity Parent { get; set; }
        public CountryEntity Country { get; set; }
    }
}
