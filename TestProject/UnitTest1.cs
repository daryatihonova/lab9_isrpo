using lab_9;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        private Matrix matrix;

        [TestInitialize]
        public void Setup()
        {
            // Создание матрицы для тестов
            double[,] testMatrix = {
                { 6.3, 28.31, 3.45 },
                { 0.29, 34.12, 35.02 },
                { 26.72, 18.05, 46.38 }
            };
            matrix = new Matrix(testMatrix);
        }

        [TestMethod]
        public void CountElementsGreaterThanTestMethod1()
        {
            // Исходные данные
            double number = 10.03;
            int expectedCount = 6;

            // Получение значения с помощью тестируемого метода
            int result = matrix.CountElementsGreaterThan(number);

            // Сравнение ожидаемого результата с полученным
            Assert.AreEqual(expectedCount, result);
        }

        [TestMethod]
        public void CountElementsGreaterThanTestMethod2()
        {
            // Исходные данные
            double number = 50.03;
            int expectedCount = 0;

            // Получение значения с помощью тестируемого метода
            int result = matrix.CountElementsGreaterThan(number);

            // Сравнение ожидаемого результата с полученным
            Assert.AreEqual(expectedCount, result);
        }

        [TestMethod]
        public void CountElementsGreaterThanMultipleTestMethod3()
        {
            // Исходные данные
            double number = 10.03;
            int divisor = 2;
            int expectedCount = 3;

            // Получение значения с помощью тестируемого метода
            int result = matrix.CountElementsGreaterThanMultiple(number, divisor);

            // Сравнение ожидаемого результата с полученным
            Assert.AreEqual(expectedCount, result);
        }

        [TestMethod]
        public void CountElementsGreaterThanMultipleTestMethod4()
        {
            // Исходные данные
            double number = 10.03;
            int divisor = 1;
            int expectedCount = 6;

            // Получение значения с помощью тестируемого метода
            int result = matrix.CountElementsGreaterThanMultiple(number, divisor);

            // Сравнение ожидаемого результата с полученным
            Assert.AreEqual(expectedCount, result);
        }

        [TestMethod]
        public void CountElementsGreaterThanMultipleTestMethod5()
        {
            // Исходные данные
            double number = 50.03;
            int divisor = 2;
            int expectedCount = 0;

            // Получение значения с помощью тестируемого метода
            int result = matrix.CountElementsGreaterThanMultiple(number, divisor);

            // Сравнение ожидаемого результата с полученным
            Assert.AreEqual(expectedCount, result);
        }

        [TestMethod]
        public void CountElementsGreaterThanMultipleTestMethod6()
        {
            // Исходные данные
            double number = 50.03;
            int divisor = 1;
            int expectedCount = 0;

            // Получение значения с помощью тестируемого метода
            int result = matrix.CountElementsGreaterThanMultiple(number, divisor);

            // Сравнение ожидаемого результата с полученным
            Assert.AreEqual(expectedCount, result);
        }
    }
}
