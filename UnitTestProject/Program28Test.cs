using Microsoft.VisualStudio.TestTools.UnitTesting;
using ForumPrograms;

namespace UnitTestProject {

    [TestClass]
    public class Program28Test {
        
        [TestMethod]
        public void ReverseText_WithString() {
            Program28 app = new Program28();                          
            string expected = "gnitset";
            string results = app.ReverseText("testing");            
            Assert.AreEqual(expected, results, "Did not reverse strings correctly");
        }
        
        [TestMethod]
        public void ReverseText_WithEmptyString() {
            Program28 app = new Program28();
            string expected = string.Empty;
            string results = app.ReverseText(string.Empty);
            Assert.AreEqual(expected, results, "Did not combine strings correctly");
        }    

        [TestMethod]
        public void ReverseText_WithNull() {
            Program28 app = new Program28();
            string expected = null;
            string results = app.ReverseText(null);
            Assert.AreEqual(expected, results, "Did not combine strings correctly");
        }    
        
    }
}
