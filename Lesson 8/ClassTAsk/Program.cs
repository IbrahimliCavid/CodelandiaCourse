using System.Text;

namespace ClassTAsk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int number = 0;
            NumberGame(number);

            #region TryParse
            //Console.WriteLine("Please enter a number: ");
            //string txt = Console.ReadLine();

            //if (TryParseClone(txt, out int result))
            //{
            //    Console.WriteLine($"Daxil etdiyiniz eded: {result}");
            //}
            //else
            //{
            //    Console.WriteLine("Zehmet olmasa eded daxil edin!!!");
            //}
            #endregion

            #region Name Check
            //NameChek("", out string value);
            //Console.WriteLine(value);
            #endregion

            #region Arr Check
            //int[] arr = { 1, 2, 45, 43, 23 };

            //if (ArrCheck(arr, out int[] newArr))
            //{
            //    foreach (var item in newArr)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Massivdeki butun elementler musbetdir!!!!");
            //}
            #endregion

        }
        #region TryParse
        //static bool TryParseClone(string txt, out int result)
        //{
        //    try
        //    {
        //        result = int.Parse(txt);
        //        return true;
        //    }
        //    catch (Exception)
        //    {
        //        result = 0;
        //        return false;
        //    }

        //}
        #endregion

        #region Name Check
        //public static void NameChek(string name, out string value)
        //{
        //    if (name.Trim() == "")
        //    {
        //        value = "False";
        //    }
        //    else
        //    {
        //        value = name;
        //    }
        //}
        #endregion

        #region Arr Check
        //public static bool ArrCheck(int[] arr, out int[] newArr)
        //{
        //    List<int> list = new List<int>();
        //    foreach (int item in arr)
        //    {
        //        if (item < 0)
        //        {
        //            list.Add(item);
        //        }
        //    }

        //    if (list.Count != 0)
        //    {
        //        newArr = list.ToArray();
        //        return true;
        //    }
        //    else
        //    {
        //        newArr = new int[0];
        //        return false;
        //    }
        //}
        #endregion

        public static void NumberGame(int number)
        {
            Random random = new Random();
            int rndNum = random.Next(1, 10);
            for (int i = 2; i >= 0; i--)
            {
                
                Console.WriteLine("Zəhmət olmasa ədəd daxil edin: ");
                number = int.Parse(Console.ReadLine());

                if (number > rndNum)
                {
                    Console.WriteLine($"Daxil etdiyiniz ədəd, təsadüfi ədəddən böyükdür... (Sizin {i} şansınız qaldı!)");
                }
                else if (number < rndNum)
                {
                    Console.WriteLine($"Daxil etdiyiniz ədəd, təsadüfi ədəddən kiçikdir... (Sizin {i} şansınız qaldı!)");
                }
                else
                {
                    Console.WriteLine("Siz qalib gəldiniz...");
                    break;
                }

                if (i == 0)
                {
                    Console.WriteLine("Şansınız bitdi, doğru ədədi tapmadınız...");
                    break;
                }
            }



        }
    }
}
