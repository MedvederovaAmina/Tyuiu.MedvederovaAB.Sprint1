using Tyuiu.MedvederovaAB.Sprint1.Task6.V5.Lib;

namespace Tyuiu.MedvederovaAB.Sprint1.Task6.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "�����, ����, �����";
            DataService ds = new DataService();
            string res = ds.CheckSymmetricalWords( strTest );
            string wait = "�����, �����";
            Assert.AreEqual(wait, res);
        }
    }
}