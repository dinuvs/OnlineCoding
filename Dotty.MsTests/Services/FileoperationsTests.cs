using Dotty.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotty.MsTests.Services
{
    [TestClass]
    public class FileoperationsTests
    {
        [TestMethod]
        public void ReadInputFromFileWithCorrectPathReturnsNotNullString()
        {
            FileOperations fileOperations = new();
            fileOperations.FilePath = @"C:\Work\Dotty\Dotty\input.txt";
            var result=fileOperations.ReadInputFile();

            Assert.IsTrue(result.Length>0);
        }

        [TestMethod]
        public void ReadInputFromFileWithInCorrectPathReturnsNullString()
        {
            FileOperations fileOperations = new();
            fileOperations.FilePath = "Incorrecttestpath";
            var result = fileOperations.ReadInputFile();

            Assert.IsTrue(result.Length==0);
        }
    }
}
