using Tyuiu.MedvederovaAB.Sprint1.Task2.V13.Lib;

namespace Tyuiu.MedvederovaAB.Sprint1.Task2.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 2;
            var res = ds.ConvertMilesToKm(x);
            Assert.AreEqual(3.218, res);
        }
    }
}