using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WPAppStudio.Services;

namespace UnitTests
{
    [TestClass]
    public class WordWrapTests
    {
        [TestMethod]
        public void CanGetZeroWords()
        {
            WordWrapService service = new WordWrapService();
            string words = service.GetWords("’Twas brillig, and the slithy toves Did gyre and gimble in the wabe", 0);

            Assert.AreEqual("", words);
        }

        [TestMethod]
        public void CanGetOneWord()
        {
            WordWrapService service = new WordWrapService();
            string words = service.GetWords("’Twas brillig, and the slithy toves Did gyre and gimble in the wabe", 1);

            Assert.AreEqual("’Twas", words);
        }

        [TestMethod]
        public void CanGetTwoWords()
        {
            WordWrapService service = new WordWrapService();
            string words = service.GetWords("’Twas brillig, and the slithy toves Did gyre and gimble in the wabe", 2);

            Assert.AreEqual("’Twas brillig,", words);
        }

        [TestMethod]
        public void CanGetThreeWords()
        {
            WordWrapService service = new WordWrapService();
            string words = service.GetWords("’Twas brillig, and the slithy toves Did gyre and gimble in the wabe", 3);

            Assert.AreEqual("’Twas brillig, and", words);
        }
    }
}
