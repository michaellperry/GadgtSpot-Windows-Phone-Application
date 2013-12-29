﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WPAppStudio.Services;

namespace UnitTests
{
    [TestClass]
    public class WordWrapTests
    {

        private const string Saying = "’Twas brillig, and the slithy toves Did gyre and gimble in the wabe";

        [TestMethod]
        public void CanGetZeroWords()
        {
            WordWrapService service = new WordWrapService();
            string words = service.GetWords(Saying, 0);

            Assert.AreEqual("", words);
        }

        [TestMethod]
        public void CanGetOneWord()
        {
            WordWrapService service = new WordWrapService();
            string words = service.GetWords(Saying, 1);

            Assert.AreEqual("’Twas", words);
        }

        [TestMethod]
        public void CanGetTwoWords()
        {
            WordWrapService service = new WordWrapService();
            string words = service.GetWords(Saying, 2);

            Assert.AreEqual("’Twas brillig,", words);
        }

        [TestMethod]
        public void CanGetThreeWords()
        {
            WordWrapService service = new WordWrapService();
            string words = service.GetWords(Saying, 3);

            Assert.AreEqual("’Twas brillig, and", words);
        }

        [TestMethod]
        public void CanGetTwelveWords()
        {
            WordWrapService service = new WordWrapService();
            string words = service.GetWords(Saying, 12);

            Assert.AreEqual("’Twas brillig, and the slithy toves Did gyre and gimble in the", words);
        }

        [TestMethod]
        public void CanGetThirteenWords()
        {
            WordWrapService service = new WordWrapService();
            string words = service.GetWords(Saying, 13);

            Assert.AreEqual("’Twas brillig, and the slithy toves Did gyre and gimble in the wabe", words);
        }

        [TestMethod]
        public void CanGetNintyNineWords()
        {
            WordWrapService service = new WordWrapService();
            string words = service.GetWords(Saying, 99);

            Assert.AreEqual("’Twas brillig, and the slithy toves Did gyre and gimble in the wabe", words);
        }

        [TestMethod]
        public void CanGetTenThousandWords()
        {
            WordWrapService service = new WordWrapService();
            string words = service.GetWords(Saying, 10000);

            Assert.AreEqual("’Twas brillig, and the slithy toves Did gyre and gimble in the wabe", words);
        }
    }
}
