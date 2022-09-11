using Example_Practice;

namespace UnitTest
{
    [TestClass]
    public class Problem7Tests
    {
        [TestMethod]
        public void MultiplyTest()
        {
            // arrange
            double expected = 1 * 2 * 3 * 4;
            double[] entries = { 1, 2, 3, 4 };
            ProblemSeven examples = new ProblemSeven();

            // Act
            double actual = examples.MultiplyX(entries);

            // Assert
            Assert.AreEqual(expected, actual, .0001, "Fail");
        }

        [TestMethod]
        public void DivideTest()
        {
            // arrange
            double[] entries = { 1, 2, 3, 4 };
            double expected = entries[0];
            for (int i = 1; i < entries.Length; i++)
            {
                expected /= entries[i];
            }
            ProblemSeven examples = new ProblemSeven();

            // Act
            double actual = examples.DivideX(entries);

            // Assert
            Assert.AreEqual(expected, actual, .0001, "Fail");
        }

        [TestMethod]
        public void AddTest()
        {
            // arrange
            double expected = 1 + 2 + 3 + 4;
            double[] entries = { 1, 2, 3, 4 };
            ProblemSeven examples = new ProblemSeven();

            // Act
            double actual = examples.AddX(entries);

            // Assert
            Assert.AreEqual(expected, actual, .0001, "Fail");
        }

        [TestMethod]
        public void SubtractTest()
        {
            // arrange
            double expected = 1 - 2 - 3 - 4;
            double[] entries = { 1, 2, 3, 4 };
            ProblemSeven examples = new ProblemSeven();

            // Act
            double actual = examples.SubtractX(entries);

            // Assert
            Assert.AreEqual(expected, actual, .0001, "Fail");
        }

    }

    [TestClass]
    public class ProblemEightTests
    {
        [TestMethod]
        public void MultiplyTablesTest()
        {
            // arrange
            int[] expected = {5, 10, 15, 20, 25, 30, 35, 40, 45, 50};
            int entries = 5;
            ProblemEight examples = new ProblemEight();

            // Act
            int[] actual = examples.MultiplyTable(entries);

            // Assert
            for (int i = 0; i < 10; i++)
            {
                Assert.AreEqual(expected[i], actual[i], $"Failed - Iteration: {i + 1}, Expected: {expected[i]}, Actual: {actual[i]}");
            }
            
        }
    }
}