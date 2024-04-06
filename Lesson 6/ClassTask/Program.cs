using System.Collections;

namespace ClassTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region lesson
            //ArrayList arr = new ArrayList();
            //arr.Add(1);
            //arr.Add(1);
            //arr.Add(1);
            //arr.Add(1);
            //arr.Add(1);
            //Console.WriteLine(arr.Capacity);
            //arr.Clear();
            //Console.WriteLine(arr.Capacity);
            //arr.Add(1);
            //arr.Add(1);
            //arr.Add(1);
            //arr.Add(1);
            //arr.Add(1);
            //Console.WriteLine(arr.Capacity);

            //ArrayList list = new ArrayList();
            //string a = "";
            #endregion

            #region Task1

            string word = "S456lam39";
            int sum = 0;

            foreach (var item in word)
            {
                if (char.IsDigit(item))
                {
                    sum += int.Parse(item.ToString());
                }
            }

            Console.WriteLine("Sum is: {0}", sum);
            #endregion

            #region Task2
            //Console.WriteLine("Please enter a text: ");
            //string text = Console.ReadLine();
            //int count = 0;
            //foreach (var item in text)
            //{
            //    if(item == 'a')
            //    {
            //        count++;
            //    }
            //}

            //Console.WriteLine($"Count is 'a':{count} ");
            #endregion

            #region Task3
            //string text = "Codelandia";
            //string textReversed = "";
            //for (int i = text.Length-1; i >= 0; i--)
            //{
            //    textReversed += text[i];
            //}

            //Console.WriteLine(textReversed);


            #endregion

        }
    }
}
