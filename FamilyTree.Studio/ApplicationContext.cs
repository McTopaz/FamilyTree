using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using FamilyTree.Studio.Models;

namespace FamilyTree.Studio
{
    internal static class ApplicationContext
    {
        public static ApplicationInfo ApplicationInfo { get; set; } = new ApplicationInfo();
    }
}
