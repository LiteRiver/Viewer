using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;

namespace Viewer.Test {
    [TestClass]
    public class NextIntervalParserTest {
        [TestMethod]
        public void ParseIntervalFromDomTest() {
            var dom = @" <input name=""hidIsExistsUserKnowledge"" type=""hidden"" id=""hidIsExistsUserKnowledge"" value=""1"" />
    <input name=""hidKnowledgeID"" type=""hidden"" id=""hidKnowledgeID"" value=""23674407-43e7-7335-94ef-c2b9768b6c60"" />
    <input name=""hidStandardStudyHours"" type=""hidden"" id=""hidStandardStudyHours"" value=""22"" />";
            Console.WriteLine(dom);
            var parser = new DefaultNextIntervalParser();
            var interval = parser.Parse(dom);
            Console.WriteLine(interval);
            Assert.AreEqual(TimeSpan.FromMinutes(22), interval);            
        }
    }
}
