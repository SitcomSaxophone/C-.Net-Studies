using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UtilitiesLibraries;

namespace StringLibraryTest
{
    [TestClass]
    public static class UnitTest1
    {
        [TestMethod]
        public void TestStartsWithUpper()
        {
            //Test what we expect to return true
            string[] words = {"Alphabet", "Zebra", "ABC", "Αθήνα", "Москва"};
            foreach(var word in words) 
            {
                bool result = word.StartsWithUpper();
                Assert.IsTrue(result,
                        String.Format("Expected for '{0}': true; Actual: {1}",
                                      word, result));
            }
        }
    }
}