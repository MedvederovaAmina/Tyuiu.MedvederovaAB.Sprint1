using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MedvederovaAB.Sprint1.Task3.V10.Lib
{
    public class DataService : ISprint1Task3V10
    {
        public string NumberToMoney(double number)
        {

            string num = Convert.ToString(number);
            int rub = (int)number; 
            int kop = (int)Math.Round((number - rub) * 100);

            string rubles = Convert.ToString(rub);
            string kopecks = Convert.ToString(kop);

            rubles = rubles.Replace(',', '.');
            kopecks = kopecks.Replace(',', '.');
            num = num.Replace(",", ".");
            num = num.Replace("0", " ").Trim();

            return $"{num:F3} руб. — это {rubles} руб. {kopecks} коп."; 
        }
    }
}
