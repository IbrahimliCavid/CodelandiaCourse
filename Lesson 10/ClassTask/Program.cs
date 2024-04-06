using System.Net.Quic;

namespace ClassTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isTrue = true;
          Questions questions = new Questions();

            while (true)
            {
                Console.WriteLine($"1 - Add question\n" +
                    $"2 - Show questions list\n" +
                    $"3 - Remove a question\n" +
                    $"4 - Start exam\n" +
                    $"5 - Leave program");
                int button = int.Parse(Console.ReadLine());
                switch (button)
                {
                    case 1:
                        Console.WriteLine("Enter Id: ");
                        int id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter question: ");
                        string txt = Console.ReadLine();
                        Console.WriteLine("Enter variant A: ");
                        string variantA = Console.ReadLine();
                        Console.WriteLine("Enter variant B: ");
                        string variantB = Console.ReadLine();
                        Console.WriteLine("Enter variant C: ");
                        string variantC = Console.ReadLine();
                        Console.WriteLine("Enter variant D: ");
                        string variantD = Console.ReadLine();
                        Console.WriteLine("Enter true variant: ");
                        char variantTrue = Convert.ToChar(Console.ReadLine());
                        Questions questionAdd = new Questions()
                        {
                            Id = id,
                            QuestionText = txt,
                            A = variantA,
                            B = variantB,
                            C = variantC,
                            D = variantC,
                            TrueAnswer = variantTrue
                        };
                        break;
                    case 2:
                       List<Questions> questionList =  questions.GetAllQuestions();
                        foreach (var item in questionList)
                        {
                            Console.WriteLine($" ID: {item.Id}\n" +
                                $"Question: \n" +
                                $"{item.QuestionText}\n" +
                                $"A) {item.A}\n" +
                                $"B) {item.B}\n" +
                                $"C) {item.C}\n" +
                                $"D) {item.D}\n" +
                                $"True variant {item.TrueAnswer}");

                        }
                        break;
                    case 3:
                       
                        break;
                    case 4:
                       
                        break;
                    case 5:
                        break;
                }
            }
        }
    }

    public class Questions
    {
        List<Questions> questions = new List<Questions>();
        public int Id { get; set; }
        public string QuestionText { get; set; }
        public string A { get; set; }
        public string B { get; set; }
        public string C { get; set; }
        public string D { get; set; }
        public char TrueAnswer { get; set; }

        public void AddQuestion(Questions question)
        {
            questions.Add(question);
        }

        public List<Questions> GetAllQuestions()
        {
            return questions;
        }

        public void DeleteQuestion(int id)
        {
            Questions finded = questions.Find(x => x.Id == id);\
           questions.Remove(finded);
        }
    }
}
