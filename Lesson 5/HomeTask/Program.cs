namespace HomeTask
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Task1
            //try
            //{
            //    int number;

            //    int sum = 0;
            //    List<int> numbers = new List<int>();

            //    Console.WriteLine("Please enter the number of numbers you would like to input: ");
            //    int count = int.Parse(Console.ReadLine());


            //    for (int i = 0; i < count; i++)
            //    {
            //        Console.WriteLine("Please enter a number: ");
            //        number = int.Parse(Console.ReadLine());
            //        numbers.Add(number);
            //        sum += number;
            //    }

            //    int maxNumber = numbers.Max();
            //    int minNumber = numbers.Min();
            //    double average = sum / numbers.Count();
            //    Console.WriteLine($"Calculation results: \n" +
            //        $"Maximum number: {maxNumber} \n" +
            //        $"Minimum number: {minNumber} \n" +
            //        $"Avarage numbers: {average}");
            //}
            //catch (DivideByZeroException c)
            //{
            //    Console.WriteLine(c.Message);
            //}
            //catch (IndexOutOfRangeException d)
            //{
            //    Console.WriteLine(d.Message);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            #endregion

            #region Task2
            Console.WriteLine("Please enter a number: ");
            string enterNum = Console.ReadLine();
            int power = enterNum.Length;
            int number = int.Parse(enterNum);
            long result = number * (long)Math.Pow(5, power);

            Console.WriteLine($"Result is: {number} * {result/number} = {result}");
            #endregion

        }
    }
}
