using Dotty.BLL;
using Dotty.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotty.MsTests.BLLTests
{
    [TestClass]
    public class NumberLogicTests
    {
        [TestMethod]
        public void WhenDigitsMatchReturnsValidInt()
        {

            FileOperations fileOperations = new();
            fileOperations.FilePath = @"C:\Work\Dotty\Dotty\input.txt";
            var filecontent = fileOperations.ReadInputFile();
            NumberLogic numberLogic = new();
            var result= numberLogic.GetIntFromStringArr(filecontent);

            Assert.AreEqual(3, result);

        }
    }
}
