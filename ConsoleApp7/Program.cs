namespace ConsoleApp7
{
    public class Program
    {
        public static string Createphone(int[] numbers)
        { 
            if (numbers.Length != 10)
            {
                return "Ошибка: должно быть 10 символов";
            }

            return "8" + "(" + numbers[0] + numbers[1] + numbers[2] + ")" + numbers[3] + numbers[4] + numbers[5] + "-" + numbers[6] + numbers[7] + "-" + numbers[8] +numbers[9];
        }
        public static void Main()
        {
            int[] phoneMassiv = { 9, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            string phoneNomers = Createphone(phoneMassiv);
            Console.WriteLine(phoneNomers);
        }
    }
}
