using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClass;

namespace MyClassTest
{
    [TestClass]
    public class FileProcessTest
    {
        [TestMethod]
        public void FileNameDoesExist()
        {
            FileProcess fp = new FileProcess();
            bool fromCall;

            fromCall = fp.FileExists(@"C:Windows\Regedit.exe");
            Assert.IsTrue(fromCall);
        }

        [TestMethod]
        public void FileNameDoesNotExist()
        {
            FileProcess fp = new FileProcess();
            bool fromCall;

            fromCall = fp.FileExists(@"C:\Regedit.exe");
            Assert.IsFalse(fromCall);
        }

        [TestMethod]
        public void FileNameNullOrEmptyTrowArgumentNullException_()
        {
            //Todo
            Assert.Inconclusive();
        }
    }
}
