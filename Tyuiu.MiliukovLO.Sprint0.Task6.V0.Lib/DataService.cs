namespace Tyuiu.MiliukovLO.Sprint0.Task6.V0.Lib
{
    public class DataService
    {
        public static int AdditionArray(int[] numbers)
        {
            int result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                result += numbers[i];
            }
            return result;
        }
        public static int SubtractionArray(int[] numbers)
        {
            int result = 0;
            int index = 0;
            while (index < numbers.Length)
            {
                result -= numbers[index];
                index++;
            }
            return result;
        }
        public static int MultiplieArray(int[] numbers)
        {
            int result = 1;
            int index = 0;
            do
            {
                result = result * numbers[index];
                index++;
            }
            while (index < numbers.Length);
            return result;
        }
    }
}
