using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityLibraryTest
{
    [TestClass]
    public class LibraryTests
    {
        [TestMethod]
        public void AddBook() 
        {
            Assert.AreEqual(5, 3 + 2, "I was looking for 5");
        }

    }
}
