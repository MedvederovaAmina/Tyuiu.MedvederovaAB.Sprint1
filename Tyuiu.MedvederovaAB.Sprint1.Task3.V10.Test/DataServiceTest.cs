using Tyuiu.MedvederovaAB.Sprint1.Task3.V10.Lib;

namespace Tyuiu.MedvederovaAB.Sprint1.Task3.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds= new DataService();
            var res = $"23,6 ���. - ��� 23 ���. 60 ���.";
            Assert.AreEqual(res, ds.NumberToMoney(23.6));

        }
    }
}