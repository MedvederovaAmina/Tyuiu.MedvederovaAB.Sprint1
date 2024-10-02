using Tyuiu.MedvederovaAB.Sprint1.Task6.V5.Lib;

namespace Tyuiu.MedvederovaAB.Sprint1.Task6.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            DataService  dataService = new DataService();
            Assert.AreEqual(dataService.CheckSymmetricalWords("шалаш кофе казак"), "шалашказак");
        }
    }
}