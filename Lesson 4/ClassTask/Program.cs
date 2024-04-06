using System.Text;

namespace ClassTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region UTF8
            Console.OutputEncoding = Encoding.UTF8;
            #endregion


            #region Task1

            //Console.WriteLine("Zəhmət olmasa ədəd daxil edin: ");
            //int number = int.Parse(Console.ReadLine());
            //if (number % 40 == 0 && number % 9 == 0 && number % 7 == 0)
            //{
            //    Console.WriteLine("Verilmiş ədəd 40-a, 9-a, 7-yə bölünür.");

            //}else if (number % 40 == 0 && number % 9 == 0)
            //{
            //    Console.WriteLine("Verilmiş ədəd 40-a və 9-a bölünür.");
            //}
            //else if (number % 40 == 0)
            //{
            //    Console.WriteLine("Verilmiş ədəd yalnız 40-a bölünür.");
            //}
            //else
            //{
            //    Console.WriteLine("Verilmiş ədəd 40-a, 9-a, 7-yə bölünmür.");
            //}
            #endregion

            #region Task2
            //int oddNums = 0;
            //int evenNums = 0;
            //for (int i = 1; i <=100 ;  i++)
            //{
            //    if (i % 2 == 0 )
            //    {
            //        oddNums += i;
            //    }
            //    else
            //    {
            //        evenNums += i;  
            //    }
            //}


            //Console.WriteLine($"Tək ədədlərin cəmi(1-100): {evenNums} \n" +
            //    $"Cüt ədədlərin cəmi (1-100): {oddNums}");


            #endregion

            #region Task3

            //int faktorial = int.Parse(Console.ReadLine());
            //int result = 1;
            //for (int i = 1; i <= faktorial; i++)
            //{
            //    result *=  i;
            //}
            //Console.WriteLine(result);
            #endregion

            #region Task4

            //int num;
            //bool isTrue = true;
            //int sum = 0;
            //while (isTrue)
            //{
            //    Console.WriteLine("Please enter a number (If you want to find sum, press 0): ");
            //    num = int.Parse(Console.ReadLine());
            //    sum += num; //sum = sum + num
            //    if (num == 0)
            //    {
            //        isTrue = false;
            //    }

            //} 
            //Console.WriteLine($"Sum is: {sum}");


            #endregion


        }
    }
}
