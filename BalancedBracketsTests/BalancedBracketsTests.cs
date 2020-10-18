using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add tests to this file.
        
            [TestMethod]
        public void OnlyBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
        }
        [TestMethod]
        public void OnlyBracketsReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]"));
        }
        [TestMethod]
        public void BracketswordsReturnsTrue()
        {
        
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[Launchcode]"));
        }
        [TestMethod]
        public void BracketswordsAfterReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]Launchcode"));
        }
        [TestMethod]
        public void BracketsAndStringReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]LaunchCode"));
        }
        [TestMethod]
        public void BracketswordsReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("Laun]"));
        }
        [TestMethod]
        public void TwoSetsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]LaunchCode[]"));
        }
        [TestMethod]
        public void NestedReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[[LaunchCode]]"));
        }
        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(true, true);
        }
        [TestMethod]
        public void InitTest()
        {
            Assert.AreEqual(true, BalancedBrackets.HasBalancedBrackets(""));
        }
        [TestMethod]
        public void WrongOrderBracketsReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("Launch]Code["));
        }
        [TestMethod]
        public void MismatchReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[launch[]"));
        }
        [TestMethod]
        public void LeftBracketReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("["));
        }
    }
}
