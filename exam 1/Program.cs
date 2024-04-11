using System.Linq;
using System.Runtime.ExceptionServices;

namespace exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            Console.WriteLine("Nomre daxil edin: ");
            string phoneNum = Console.ReadLine();


            SerachNumber(phoneNum);

            #endregion
            #region Task2

            //string text = "Codelandia";
            //string textReverse = "";
            //for (int i = text.Length-1; i >= 0; i--)
            //{
            //    textReverse += text[i];
            //}
            //Console.WriteLine(textReverse);
            #endregion
        }

        public static void SerachNumber(string phoneNum)
        {
            List<int> list = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
            int count = 10;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < phoneNum.Length; j++)
                {
                    if(i == int.Parse(phoneNum[j].ToString()))
                    {
                        count--;
                        list.Remove(i);
                        break; 
                    }
                }
            }
            Console.WriteLine($"Count is: {count}");
            
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

        }
       
     
    }
}
