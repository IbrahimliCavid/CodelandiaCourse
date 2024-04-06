using System.Text;

namespace HomeTask
{
    internal class Program
    {

        // First Task
        static void Main(string[] args)
        {
            Console.WriteLine("Şagirdin balını daxil edin (1-12): ");
            int score = int.Parse(Console.ReadLine());
            // Birinci tapşırığın if else ilə yazılışı

            if (score > 0 && score <= 3)
            {
                Console.WriteLine("Inital");
            }
            else if (score > 3 && score <= 6)
            {
                Console.WriteLine("Average");
            }
            else if (score > 6 && score <= 9)
            {
                Console.WriteLine("Sufficient");
            }
            else if (score > 9 && score <= 12)
            {
                Console.WriteLine("High");
            }
            else
            {
                Console.WriteLine("Zəhmət olmasa 1-12 arası ədədlər daxil edin...");
            }

            // Birinci tapşırığın switch case ilə yazılışı.

            switch (score)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("Inital");
                    break;
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("Average");
                    break;
                case 7:
                case 8:
                case 9:
                    Console.WriteLine("Sufficient");
                    break;
                case 10:
                case 11:
                case 12:
                    Console.WriteLine("High");
                    break;
                default:
                    Console.WriteLine("Zəhmət olmasa 1-12 arası ədədlər daxil edin...");
                    break;
            }


        }

        //Second Task
        static void Main1(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("3 rəqəmli ədəd daxil edin: ");
            int number = int.Parse(Console.ReadLine());

            int firstNum = number / 100;
            int lastNum = number % 10;

            if (firstNum > lastNum)
            {
                Console.WriteLine($"Birinci ədəd ({firstNum}), sonuncu ədəddən ({lastNum}) böyükdür.");
            }
            else if (firstNum < lastNum)
            {
                Console.WriteLine($"Sonuncu ədəd ({lastNum}), birinci ədəddən ({firstNum}) böyükdür.2");
            }
            else
            {
                Console.WriteLine($"Birinci ədəd ({firstNum}), sonuncu ədədə ({lastNum}) bərabərdir.");
            }
        }

    }
}
