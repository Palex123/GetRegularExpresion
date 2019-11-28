using GetRegularExpresion;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestGetRegularExpression
{
    [TestClass]
    public class ModelNameTest
    {
        public ModelName modelName;
        [TestInitialize]
        public void Setup()
        {
            modelName = new ModelName();
        }
        [TestMethod]
        public void TestModelNameAddValue()
        {
            modelName.Name = "Alexandr";
            Assert.AreEqual("Alexandr", modelName.Name);
        }

        [TestMethod]
        public void TestModelNameAddValueNull()
        {
            modelName.Name = "Alexandr";
            modelName.Name = null;
            Assert.IsNotNull(modelName.Name);
        }

        [TestMethod]
        public void TestModelNameAddValueShortLength()
        {
            modelName.Name = "A";
            Assert.AreEqual(null, modelName.Name);
        }
    }
}
