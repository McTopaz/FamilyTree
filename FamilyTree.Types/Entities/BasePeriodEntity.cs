using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTree.Types.Entities
{
    public abstract class BasePeriodEntity : BaseEntity
    {
        public DateOnly? From { get; set; }
        public DateOnly? To { get; set; }
    }
}
