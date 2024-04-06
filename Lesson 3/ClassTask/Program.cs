using System.Text;

namespace ClassTask
{
    internal class Program
    {

        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Birinci ədədi daxil edin: ");
            int firstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("İkinci ədədi daxil edin: ");
            int secondNum = int.Parse(Console.ReadLine());

            if(firstNum % secondNum != 0)
            {
                Console.WriteLine($"Tam hissə: {firstNum / secondNum}, Qalıq hissə: {firstNum % secondNum}");
            }
            else
            {
                Console.WriteLine($"{firstNum} ədədi {secondNum} ədədinə tam bölünür.s");
            }

        }


        static void Main3(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Birinci tərəfi daxil edin: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ikinci tərəfi daxil edin: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Üçüncü tərəfi daxil edin: ");
            int num3 = int.Parse(Console.ReadLine());

            //bool result = firstKat * firstKat + secondKat * secondKat == hipetonuz * hipetonuz;

            //if(result)
            //{
            //    Console.WriteLine("Daxil edilən rəqəmlər düzbucaqlı üçbucağın tərəfləridir.");
            //}
            //else
            //{
            //    Console.WriteLine("Daxil edilən rəqəmlər düzbucaqlı üçbucağın tərəfləri deyil!");
            //}
           bool result1 = num1 * num1 == num2 * num2 + num3 * num3;
            bool result2 = num2 * num2 == num1 * num1 + num3 * num3;
            bool result3 = num3 * num3 == num2 * num2 + num1 * num1;

            if ( result1)
            {
                Console.WriteLine("Daxil edilən ədədlər Pifaqor ədədləridir");
            }
            else if(result2) 
            {
                Console.WriteLine("Daxil edilən ədədlər Pifaqor ədədləridir");
            }
            else if(result3)
            {
                Console.WriteLine("Daxil edilən ədədlər Pifaqor ədədləridir");
            }
            else
            {
                Console.WriteLine("Daxil edilən ədədlər Pifaqor ədədləri deyil!!!");
            }

            Console.WriteLine(num1);
        }

        static void Main2(string[] args)
        {
          
            Console.WriteLine("Birinci ədədi daxil edin: ");
            double firstNum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("İkinci ədədi daxil edin: ");
            double secondNum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Yerinə yetirmək istədiyiniz əməliyyatı daxil edin (+, -, *, /): ");


            char operand = Convert.ToChar(Console.ReadLine());


            double result;
            switch (operand)
            {
                case '+':
                    result = firstNum + secondNum;
                    Console.WriteLine($"{firstNum} + {secondNum} = {result}");
                    break;
                case '-':
                    result = firstNum - secondNum;
                    Console.WriteLine($"{firstNum} - {secondNum} = {result}");
                    break;
                case '*':
                    result = firstNum * secondNum;
                    Console.WriteLine($"{firstNum} * {secondNum} = {result}");
                    break;
                case '/':
                    if (secondNum != 0)
                    {
                        result = firstNum / secondNum;
                        Console.WriteLine($"{firstNum} / {secondNum} = {result}");
                    }
                    else
                    {
                        Console.WriteLine("Sıfıra bölmə yoxdur!!!");
                    }

                    break;
                default:
                    Console.WriteLine("Zəhmət olmasa doğru operator daxil edin!");
                    break;
            }







        }
    }
}
