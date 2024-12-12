using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MedvederovaAB.Sprint1.Task3.V10.Lib
{
    public class DataService : ISprint1Task3V10
    {
        public string NumberToMoney(double number)
        {
            number = Math.Round(number, 1);

            int rub = (int)number; 
            int kop = (int)Math.Round((number - rub) * 100);

            string rubles = Convert.ToString(rub);
            string kopecks = Convert.ToString(kop);

            rubles = rubles.Replace(',', '.');
            kopecks = kopecks.Replace(',', '.');

            return $"{number:F3} руб. — это {rubles} руб. {kopecks} коп."; 
        }
    }
}
