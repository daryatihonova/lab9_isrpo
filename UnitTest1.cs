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
            // �������� ������� ��� ������
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
            // �������� ������
            double number = 10.03;
            int expectedCount = 6;

            // ��������� �������� � ������� ������������ ������
            int result = matrix.CountElementsGreaterThan(number);

            // ��������� ���������� ���������� � ����������
            Assert.AreEqual(expectedCount, result);
        }

        [TestMethod]
        public void CountElementsGreaterThanTestMethod2()
        {
            // �������� ������
            double number = 50.03;
            int expectedCount = 0;

            // ��������� �������� � ������� ������������ ������
            int result = matrix.CountElementsGreaterThan(number);

            // ��������� ���������� ���������� � ����������
            Assert.AreEqual(expectedCount, result);
        }

        [TestMethod]
        public void CountElementsGreaterThanMultipleTestMethod3()
        {
            // �������� ������
            double number = 10.03;
            int divisor = 2;
            int expectedCount = 3;

            // ��������� �������� � ������� ������������ ������
            int result = matrix.CountElementsGreaterThanMultiple(number, divisor);

            // ��������� ���������� ���������� � ����������
            Assert.AreEqual(expectedCount, result);
        }

        [TestMethod]
        public void CountElementsGreaterThanMultipleTestMethod4()
        {
            // �������� ������
            double number = 10.03;
            int divisor = 1;
            int expectedCount = 6;

            // ��������� �������� � ������� ������������ ������
            int result = matrix.CountElementsGreaterThanMultiple(number, divisor);

            // ��������� ���������� ���������� � ����������
            Assert.AreEqual(expectedCount, result);
        }

        [TestMethod]
        public void CountElementsGreaterThanMultipleTestMethod5()
        {
            // �������� ������
            double number = 50.03;
            int divisor = 2;
            int expectedCount = 0;

            // ��������� �������� � ������� ������������ ������
            int result = matrix.CountElementsGreaterThanMultiple(number, divisor);

            // ��������� ���������� ���������� � ����������
            Assert.AreEqual(expectedCount, result);
        }

        [TestMethod]
        public void CountElementsGreaterThanMultipleTestMethod6()
        {
            // �������� ������
            double number = 50.03;
            int divisor = 1;
            int expectedCount = 0;

            // ��������� �������� � ������� ������������ ������
            int result = matrix.CountElementsGreaterThanMultiple(number, divisor);

            // ��������� ���������� ���������� � ����������
            Assert.AreEqual(expectedCount, result);
        }
    }
}
