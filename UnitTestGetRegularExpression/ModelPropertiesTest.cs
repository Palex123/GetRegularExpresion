using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GetRegularExpresion;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestGetRegularExpression
{
    [TestClass]
    public class ModelPropertiesTest
    {
        ModelProperties modelProperties;
        [TestInitialize]
        public void Setup()
        {
            modelProperties = new ModelProperties();
        }

        [TestMethod]
        public void TestModelPropertiesAddValue()
        {
            modelProperties.PathWeb = "http://www.microsoft.com";
            modelProperties.PatternString1 = "@s*";
            modelProperties.PatternString2 = "@w*/>";

            Assert.AreEqual("http://www.microsoft.com", modelProperties.PathWeb);
            Assert.AreEqual("@s*", modelProperties.PatternString1);
            Assert.AreEqual("@w*/>", modelProperties.PatternString2);
        }
    }
}
