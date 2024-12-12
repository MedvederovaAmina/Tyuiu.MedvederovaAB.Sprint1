using Tyuiu.MedvederovaAB.Sprint1.Task3.V10.Lib;

namespace Tyuiu.MedvederovaAB.Sprint1.Task3.V10.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidExpression(string res)
    {
        DataService ds = new DataService();
        double number = 23.6;
        
        Assert.AreEqual($"23.6 руб. - это 23 руб. 60 коп.", ds.NumberToMoney(number));
    }
}