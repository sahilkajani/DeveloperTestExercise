using System;
using System.Globalization;
using FileData;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace FileDataTests
{
    [TestClass]
    public class FileManagerTests
    {
        [TestMethod]
        public void RunFunctionality_FileVersion_ReturnsStringOfFileVersion()
        {
            //Arrange 
            FileManager fileManager = new FileManager();

            //Act 
            var result = fileManager.RunFunctionality("-v", "c:/test.txt");

            //Assert
            Assert.IsTrue(result.Contains("."));

        }

        [TestMethod]
        public void RunFunctionality_FileSize_ReturnsStringOfFileSize()
        {
            //Arrange
            FileManager fileManager = new FileManager();

            //Act 
            var result = fileManager.RunFunctionality("-s", "c:/test.txt");

            //Assert
            Assert.IsFalse(result.Contains("."));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void RunFunctionality_InvalidFunctionality_ReturnsArgumentException()
        {
            //Arrange
            FileManager fileManager = new FileManager();

            //Act 
            var result = fileManager.RunFunctionality("f", "c:/test.txt");

        }



    }
}
