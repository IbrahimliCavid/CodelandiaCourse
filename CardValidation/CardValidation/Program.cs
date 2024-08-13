namespace CardValidation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter card number: ");
            string cardNumber = Console.ReadLine();
          
            Console.WriteLine(CardValidation(cardNumber));
        }

        public static bool CardValidation(string cardNumber)
        {
            var sum = 0;
            for (int i = cardNumber.Length -2; i >= 0; i-=2)
            {
                var value = (cardNumber[i] - '0') * 2;
                if (value > 9)
                {
                    sum += value % 10 + value / 10;
                }
                else
                {
                    sum += value;
                }
            }
            for (int i = cardNumber.Length - 1; i >= 0; i -= 2)
            {
                sum += cardNumber[i] - '0';
            }

            if (sum % 10 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
