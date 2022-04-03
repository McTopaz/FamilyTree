using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using FamilyTree.Types.Entities;

namespace FamilyTree.Test.RepositoryTest
{
    [TestClass]
    internal class FooEntityTest
    {
        [TestMethod]
        public void InsertAndSelect()
        {
            var foo = new FooEntity
            {
                Name = System.IO.Path.GetRandomFileName(),
                Age = new Random().Next()
            };
        }
    }
}
