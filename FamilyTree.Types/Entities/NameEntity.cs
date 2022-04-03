using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTree.Types.Entities
{
    public class NameEntity : BasePeriodEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<string> MiddleNames { get; set; }
        public string Alias { get; set; }
    }
}
