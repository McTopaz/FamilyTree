using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTree.Types.Entities
{
    public class TelephoneEntity : BasePeriodEntity
    {
        public TelephoneTypeEntity Type { get; set; }
        public string Number { get; set; }
    }
}
