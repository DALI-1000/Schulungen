using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SageAufbaukursCSharp.ServiceImplementations;

namespace SageAufbaukursCSharpTest
{
    [TestClass]
    public class SaveFilesUtilTest
    {
        [TestMethod]
        public void TDO()
        {
            var mock = new SaveFilesUtil();
            mock.Save(null);
        }
    }
}
