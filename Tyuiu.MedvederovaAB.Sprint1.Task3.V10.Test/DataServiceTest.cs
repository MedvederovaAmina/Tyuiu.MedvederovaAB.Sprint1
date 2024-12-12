using Tyuiu.MedvederovaAB.Sprint1.Task3.V10.Lib;

namespace Tyuiu.MedvederovaAB.Sprint1.Task3.V10.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidExpression(string res)
    {
        DataService ds = new DataService();
       
        string result1 = ds.NumberToMoney(30.5);
        Assert.AreEqual("30.50 руб. Ч это 30 руб. 50 коп.", result1);

       
        string result2 = ds.NumberToMoney(100);
        Assert.AreEqual("100.00 руб. Ч это 100 руб. 0 коп.", result2);

        
        string result3 = ds.NumberToMoney(-12.345);
        Assert.AreEqual("-12.35 руб. Ч это -12 руб. -34 коп.", result3);

        string result4 = ds.NumberToMoney(5.67);
        Assert.AreEqual("5.67 руб. Ч это 5 руб. 67 коп.", result4);
    }
}