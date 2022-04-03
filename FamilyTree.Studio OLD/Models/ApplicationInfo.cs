using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTree.Studio.Models
{
    internal class ApplicationInfo
    {
        public DirectoryInfo Folder { get; set; }
        public (bool missing, string status) FolderStatus { get; set; }
        public FileInfo DataBaseFile { get; set; }
        public (bool missing, string status) DatabaseStatus { get; set; }
    }
}
