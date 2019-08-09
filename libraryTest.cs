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
            // Test what we expect to return true
            string[] words = { "Alphabet", "Zebra", "ABC", "Αθήνα", "Москва" };
            foreach (var word in words)
            {
                bool result = word.StartsWithUpper();
                Assert.IsTrue(result,
                        String.Format("Expected for '{0}': true; Actual: {1}",
                                      word, result));
            }
        }

        [TestMethod]
        public void TestDoesNotStartWithUpper()
        {
            // Test what we expect to return false
            string[] words = { "pelican", "desERT", "spoon", "1234", "." };
            foreach (var word in words)
            {
                bool result = word.StartsWithUpper();
                Assert.IsFalse(result,
                        String.Format("Expected for '{0}: false; Actual: {1}",
                                        word, result));
            }
        }

        [TestMethod]
        public void DirectCallWithNullOrEmpty()
        {
            // Test what we expect to return false
            string[] words = { String.Empty, null };
            foreach (var word in words)
            {
                bool result = StringLibrary.StartsWithUpper(word);
                Assert.IsFalse(result,
                        String.Format("Expected for '{0}': false; Actual: {1}",
                                        word == null ? "<null>" : word, result));
            }
        }
    }
}