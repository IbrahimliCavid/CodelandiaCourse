using System.Collections;
namespace HomeTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1

            //string message = "Mən info@codelandia.edu.az adresindən mail aldım.";



            //string[] wordsArr = message.Split(' ');


            //Console.WriteLine(wordsArr[1]);


            #endregion

            #region Task 2

            //string word = "Codelandia";
            //string newWord = "";
            //foreach (var item in word)
            //{
            //    switch (item)
            //    {
            //        case 'C':
            //            newWord += 'C';
            //            break;
            //        case 'o':
            //            newWord += 'O';
            //            break;
            //        case 'd':
            //            newWord += 'D';
            //            break;
            //        case 'l':
            //            newWord += 'L';
            //            break;
            //        case 'a':
            //            newWord += 'A';
            //            break;
            //        case 'n':
            //            newWord += 'N';
            //            break;
            //        case 'i':
            //            newWord += 'I';
            //            break;

            //    }
            //}
            //Console.WriteLine(newWord);
            #endregion

            #region Task 3
            //int[] arr = new int[] { 1, 2, 3, 5, 6, 8, 3, 99, 22, 1, 108, 99};
            // var newArr = arr.ToList();


            // for (int i = 0; i < arr.Length; i++)
            // {
            //     for (int j = i + 1; j < arr.Length; j++)
            //     {
            //         if (arr[i] == arr[j])
            //         {

            //             newArr.Remove(arr[i]);
            //         }


            //     }
            // }

            // foreach (var item in newArr)
            // {
            //     Console.WriteLine(item);
            // }
            #endregion

            #region Task 4
            //Console.WriteLine("Please enter the text:");
            //string text = Console.ReadLine();
            //string[] wordsInText = text.Trim().Split(' ');
            //Console.WriteLine($"Word count is: {wordsInText.Length}");
            #endregion

            #region Task 5
            //Console.WriteLine("Please enter a word: ");
            //string word = Console.ReadLine().ToUpper();
            //Console.WriteLine("Please enter a letter: ");
            //string letter = Console.ReadLine().ToUpper();
            //if (word[0].ToString() == letter)
            //{
            //    Console.WriteLine(1);
            //}
            //else
            //{
            //    Console.WriteLine(0);
            //}
            #endregion

            #region Task6
            //const string staticUserName = "cavid";
            //const string staticPassword = "12345";
            //int tryCount = 1;

            //while (true)
            //{
            //    Console.WriteLine("Please enter user name: ");
            //    string userName = Console.ReadLine();
            //    Console.WriteLine("Please enter password :");
            //    string password = Console.ReadLine();
            //    if (userName == staticUserName && password == staticPassword)
            //    {
            //        Console.WriteLine("Sistemə girişiniz uğurludur...");
            //        break;
            //    }
            //    else if (tryCount == 3)
            //    {
            //        Console.WriteLine("3 uğursuz cəhd. Sistemə girişiniz bloklandı!");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Təkrar cəhd edin...");
            //        tryCount++;
            //    }



            //}


            #endregion

            #region task 7
            //int[] arr = { 6, 2, 1, 8, 10 };
            //int sum = 0;
            //foreach (var item in arr)
            //{
            //    sum += item;
            //}

            //int result = sum - arr.Max() - arr.Min();

            //Console.WriteLine(result);
            #endregion

        }
    }
}

