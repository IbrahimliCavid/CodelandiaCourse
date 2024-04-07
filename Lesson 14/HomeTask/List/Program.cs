namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Number numbers = new Number();
                bool isContinue = true;
                while (isContinue)
                {
                    Console.WriteLine("1-Add Number, 2-Show List, 3-Remove Number from list, 4-Update number, 5-Leave");
                    bool isCommand = int.TryParse(Console.ReadLine(), out int command);
                    if (isCommand)
                    {
                        switch (command)
                        {
                            case 1:
                                Console.Clear();
                                Console.WriteLine("Please enter number: ");
                                int number = int.Parse(Console.ReadLine());
                                numbers.AddNumber(number);
                                break;
                            case 2:
                                Console.Clear();
                                List<int> getNumber = numbers.GetNumbers();
                                foreach (var item in getNumber)
                                {
                                    Console.WriteLine(item);
                                }
                                break;
                            case 3:
                                Console.Clear();
                                Console.WriteLine("Please enter a number for remove.");
                                int delNum = int.Parse(Console.ReadLine());
                                numbers.DeleteNumber(delNum);
                                break;
                            case 4:
                                Console.Clear();
                                Console.WriteLine("Please enter a number for update");
                                int updateNum = int.Parse(Console.ReadLine());
                                Console.WriteLine("Please enter a change number.");
                                int enterNumber = int.Parse(Console.ReadLine());
                                numbers.UpdateNumber(enterNumber, updateNum);
                                break;
                            default:
                                Console.Clear();
                                Console.WriteLine("Please enter true command");

                                break;
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Please enter true command");
                    }

                }
            }
            catch (FormatException)
            {
                Console.Clear();
                Console.WriteLine("Please enter only number!!!");
               
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Unexpected error!");
            }
        }
    }

    public class Number
    {
        List<int> numbers = new();

        public void AddNumber(int number)
        {
            numbers.Add(number);
        }

        public List<int> GetNumbers()
        {
            return numbers;
        }

        public void DeleteNumber(int number)
        {
            numbers.Remove(number);
        }

        public void UpdateNumber(int enterNum, int updateNum)
        {
            int findNum = numbers.Find(x => x == updateNum);


            numbers[numbers.IndexOf(findNum)] = enterNum;

         
        }
    }

}
