using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTree.Types.Entities
{
    public class PersonEntity : BaseEntity
    {
        public string Alias { get; set; }
        public DateOnly? Birthday { get; set; }
        public DateOnly? DeathDate { get; set; }
        public int? Mother { get; set; }
        public int? Father { get; set; }
        public string Notes { get; set; }

        public List<int> Names { get; set; }
        public List<int> Telephones { get; set; }
        public List<int> Addresses { get; set; }
        public List<int> Emails { get; set; }
        public List<int> AdoptiveParents { get; set; }
        public List<int> RelationShips { get; set; }
        public List<int> Occupations { get; set; }
    }
}
