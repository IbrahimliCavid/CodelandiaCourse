namespace ClassTask
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> birds = new List<int>() { 1, 2, 4, 3, 5, 4, 3, 2, 1, 3, 4, 4 , 3};
            migratoryBirds(birds);

        }

        public static void migratoryBirds(List<int> arr)
        {
            int birdType = 0;
            int count = 1;
            int countBirds = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                for (int j = 1; j < arr.Count; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        if(count >= countBirds)
                        {
                            if (birdType >= arr[i] || birdType == 0)
                            {
                                birdType = arr[i];
                            }
                           
                            countBirds = count;
                        }
                    }
                }
                count = 0;
            }
            Console.WriteLine(birdType);
        }
    }
}
