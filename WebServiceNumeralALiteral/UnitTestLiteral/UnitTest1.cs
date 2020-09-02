using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebServiceNumeralALiteral.Controllers;

namespace UnitTestLiteral
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestLiteral()
        {
            //Arrange
            LiteralController objetoliteral = new LiteralController();
            int numero = 11;
            string expected = "once";

            //Act
            string actual = objetoliteral.literal(numero);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
