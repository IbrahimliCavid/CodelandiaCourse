namespace HomeTask
{
    public class Program
    {
       

        static void Main(string[] args)
        {
            
            //First Task

            Console.WriteLine("Please enter a number:");
             string number = (Console.ReadLine());
            int result = 0;
            foreach (var item in number)
            {
                int digit = int.Parse(item.ToString());
                result += digit*digit;
            }

            Console.WriteLine($"Result  is: {result}");


        }

        static void Main2(string[] args)
        {
            //Second Task

            Console.WriteLine("Please enter a three-digit number: ");
            string number = Console.ReadLine();

            int num1 = int.Parse(number[2].ToString());
            int num2 = int.Parse(number[0].ToString());

            int residue = num1 % num2;

            Console.WriteLine($"Residue is: {residue}");

        }
    }
}
