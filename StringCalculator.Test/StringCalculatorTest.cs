namespace StringCalculator.Test
{
    [TestClass]
    public class StringCalculatorTest
    {
        [TestMethod]
        public void ReturnZeroIfEmptyString()
        {
            // Arrange
            StringCalculatorService service = new StringCalculatorService();
            //Act
            int resultado = service.Add("");
            //Assert
            Assert.AreEqual(0, resultado);
        }

        [TestMethod]
        [DataRow("5",5)]
        [DataRow("10000",10000)]

        public void ReturnNumberIfEmptyNumber(string numero, int resultadocorrecto)
        {
            // Arrange
            StringCalculatorService service = new StringCalculatorService();
            //Act
            int resultado = service.Add(numero);
            //Assert
            Assert.AreEqual(resultadocorrecto, resultado);
        }
        [TestMethod]
        public void ReturnSunIfTwoNumber()
        {
            // Arrange
            StringCalculatorService service = new StringCalculatorService();
            //Act
            int resultado = service.Add("5,15");
            //Assert
            Assert.AreEqual(20, resultado);
        }

        [TestMethod]
        [DataRow("5, 10, 20", 35)]
        [DataRow("1, 2, 5, 9", 17)]
        [DataRow("1 \n2, 5, 9", 17)]
        [DataRow("//; \n1;2", 3)]
        [DataRow("//% \n1%2%5%9", 17)]
        [DataRow("//% \n1%-2%-5%-9", 1)]
        public void ReturnSunIfManyNumberIsUnknown(string numero, int resultadocorrecto)
        {
            // Arrange
            StringCalculatorService service = new StringCalculatorService();
            //Act
            int resultado = service.Add(numero);
            //Assert
            Assert.AreEqual(resultadocorrecto, resultado);
        }


    }
}