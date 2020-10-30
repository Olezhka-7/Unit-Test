using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Unit_Test.Tests
{
    [TestClass]
    public class PowerTasksTests
    {
        [TestMethod]
        public void Power_5_25()
        {
            int a = 5;
            double expected = 25;

            PowerTasks c = new PowerTasks();
            double actual = c.Power(a);

            Assert.AreEqual(expected, actual, 0.1d);
        }

        [TestMethod]
        public void Sum_4and7_11()
        {
            int a = 4;
            int b = 7;
            double expected = 11;

            PowerTasks c = new PowerTasks();
            double actual = c.Sum(a,b);

            Assert.AreEqual(expected, actual, 0.1d);
        }
    }
}
