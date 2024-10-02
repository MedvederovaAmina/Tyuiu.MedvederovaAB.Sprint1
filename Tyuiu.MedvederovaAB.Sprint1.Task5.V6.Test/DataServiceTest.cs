using Tyuiu.MedvederovaAB.Sprint1.Task5.V6.Lib;

namespace Tyuiu.MedvederovaAB.Sprint1.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            int k = 8;
            DataService ds = new DataService();
            var res = ds.Calculate(k);
            int n = Convert.ToInt32(res);
            int wait = 1;
            Assert.AreEqual(wait, n);
        }
    }
}