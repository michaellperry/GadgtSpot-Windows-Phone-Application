using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WPAppStudio.Services;

namespace UnitTests
{
    [TestClass]
    public class WordCountTests
    {

        
        private WordWrapService _wws;

        //[TestInitialize]
        //public void Initialize() 
        //{
        //    _wws = new WordWrapService(null);
        //}

        //private const string Saying = "’Twas brillig, and the slithy toves Did gyre and gimble in the wabe";

        //[TestMethod]
        //public void CanGetZeroWords()
        //{
        //    string words = _wws.GetWords(Saying, 0);

        //    Assert.AreEqual("", words);
        //}

        //[TestMethod]
        //public void CanGetOneWord()
        //{
        //    string words = _wws.GetWords(Saying, 1);

        //    Assert.AreEqual("’Twas", words);
        //}

        //[TestMethod]
        //public void CanGetTwoWords()
        //{
        //    string words = _wws.GetWords(Saying, 2);

        //    Assert.AreEqual("’Twas brillig,", words);
        //}

        //[TestMethod]
        //public void CanGetThreeWords()
        //{
        //    string words = _wws.GetWords(Saying, 3);

        //    Assert.AreEqual("’Twas brillig, and", words);
        //}

        //[TestMethod]
        //public void CanGetTwelveWords()
        //{
        //    string words = _wws.GetWords(Saying, 12);

        //    Assert.AreEqual("’Twas brillig, and the slithy toves Did gyre and gimble in the", words);
        //}

        //[TestMethod]
        //public void CanGetThirteenWords()
        //{
        //    string words = _wws.GetWords(Saying, 13);

        //    Assert.AreEqual("’Twas brillig, and the slithy toves Did gyre and gimble in the wabe", words);
        //}

        //[TestMethod]
        //public void CanGetNintyNineWords()
        //{
        //    string words = _wws.GetWords(Saying, 99);

        //    Assert.AreEqual("’Twas brillig, and the slithy toves Did gyre and gimble in the wabe", words);
        //}

        //[TestMethod]
        //public void CanGetTenThousandWords()
        //{
        //    string words = _wws.GetWords(Saying, 10000);

        //    Assert.AreEqual("’Twas brillig, and the slithy toves Did gyre and gimble in the wabe", words);
        //}
    }
}
