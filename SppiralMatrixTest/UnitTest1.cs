using NUnit.Framework;
using SpiralMatrixProject;

namespace SppiralMatrixTest
{
    public class TestSpiralMatrix
    {
        [Test]
        public void TestSpiralMatrixWithRightInput()
        {

            var testMatrixObject = new SpiralMatrixProject.SpiralMatrixProblem();
            //Starts with [1,1] and ends [6,6]
            int[,] matrix = new int[,] { {  1,  2,  3,  4,  5,  6 },
                                         { 20, 21, 22, 23, 24,  7 },
                                         { 19, 32, 33, 34, 25,  8 },
                                         { 18, 31, 36, 35, 26,  9 },
                                         { 17, 30, 29, 28, 27, 10 },
                                         { 16, 15, 14, 13, 12, 11 }
                                       };
            //Paramerts - Actual Matrix, Number To Find & Matrix square Size
            //Outout for this test = [6, 6]
            int[,] validator = new int[,] { { 6, 6 } };
            int[,] output = testMatrixObject.SpiralOrder(matrix, 11, 6);
            Assert.AreEqual(output, validator);
        }
    }
}