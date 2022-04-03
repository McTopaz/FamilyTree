using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTree.Types.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public bool Valid { get; set; }
    }
}
