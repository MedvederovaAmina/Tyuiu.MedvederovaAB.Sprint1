using Tyuiu.MedvederovaAB.Sprint1.Task0.V10.Lib;

namespace Tyuiu.MedvederovaAB.Sprint1.Task0.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(-10.5 , res);
        }
    }
}