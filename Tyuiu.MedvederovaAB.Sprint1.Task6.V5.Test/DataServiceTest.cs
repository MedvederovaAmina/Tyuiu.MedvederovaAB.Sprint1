using Tyuiu.MedvederovaAB.Sprint1.Task6.V5.Lib;

namespace Tyuiu.MedvederovaAB.Sprint1.Task6.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "шалаш, кофе, казак";
            DataService ds = new DataService();
            string res = ds.CheckSymmetricalWords( strTest );
            string wait = "шалаш, казак";
            Assert.AreEqual(wait, res);
        }
    }
}