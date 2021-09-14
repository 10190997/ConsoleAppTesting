using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Solver.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private void CheckResults(double a, double b, double c, double[] expectedResult)
        {
            var result = QuadraticSolver.Solve(a, b, c);

            Assert.AreEqual(expectedResult.Length, result.Length);

            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], result[i]);
            }
        }
        [TestMethod]
        public void OrdinaryEquation()
        {
            CheckResults(1, -3, 2, new double[] { 2.0, 1.0 });
        }
        [TestMethod]
        public void NegativeDescriminantEquation()
        {
            CheckResults(1, 1, 1, new double[0]);
        }
    }
}
