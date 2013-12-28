using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WPAppStudio.Services;

namespace UnitTests
{
    [TestClass]
    public class WordWrapTests
    {
        [TestMethod]
        public void CanSplitWords()
        {
            WordWrapService service = new WordWrapService();
            string words = service.GetWords("’Twas brillig, and the slithy toves Did gyre and gimble in the wabe", 4);

            Assert.AreEqual("’Twas brillig, and the", words);
        }
    }
}
