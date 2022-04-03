using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTree.Types.Entities
{
    public class RelationshipEntity : BasePeriodEntity
    {
        public RelationshipTypeEntity Type { get; set; }
        public List<int> Persons { get; set; }
    }
}
