using Tyuiu.MedvederovaAB.Sprint1.Task1.V17.Lib;

namespace Tyuiu.MedvederovaAB.Sprint1.Task1.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExrpession()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 2.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(8, res);
        }
    }
}