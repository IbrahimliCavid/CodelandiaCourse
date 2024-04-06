using System.Net.Quic;
using System.Threading.Channels;

namespace ClassTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isTrue = true;
            Questions questions = new Questions();
            StudentInfo student = new StudentInfo();


            while (isTrue)
            {
                
                Console.WriteLine("************************************************************************************************************************");
                Console.WriteLine("1 - Add a question, 2 - Show questions list, 3 - Remove a question, 4 - Start exam, 5 - Leave program, 6 - Show students");
                Console.WriteLine("************************************************************************************************************************");
                Console.WriteLine("Please chose the command:");
               
                try
                {
                    int button = int.Parse(Console.ReadLine());
                    switch (button)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Enter Id: ");
                            int id = 0;
                        startId:
                            try
                            {
                                id = int.Parse(Console.ReadLine());
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Please enter number ID: ");
                                goto startId;
                            }
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
                            char enterVariant = '0';
                           
                        startChar:
                            try
                            {
                                enterVariant = Convert.ToChar(Console.ReadLine().ToUpper());
                                switch (enterVariant)
                                {
                                    case 'A':
                                    case 'B':
                                    case 'C':
                                    case 'D':
                                        enterVariant = enterVariant;
                                        break;
                                    default:
                                        Console.WriteLine("Please enter correct simvol(a, b, c, d)...");
                                        goto startChar;
                                        break;
                                }
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Please enter correct simvol(a, b, c, d)...");
                                goto startChar;
                            }

                            Questions questionAdd = new Questions()
                            {
                                Id = id,
                                QuestionText = txt,
                                A = variantA,
                                B = variantB,
                                C = variantC,
                                D = variantD,
                                TrueAnswer = enterVariant
                            };
                            questions.AddQuestion(questionAdd);
                            Console.Clear();
                            Console.WriteLine($"------------------------------------------------------------------------------------------------------------------------\n" +
                                $"Question succesfully added.\n" +
                                $"------------------------------------------------------------------------------------------------------------------------");

                            break;
                        case 2:
                            Console.Clear();
                            List<Questions> questionList = questions.GetAllQuestions();
                            if (questionList.Count() > 0)
                            {
                                foreach (var item in questionList)
                                {
                                    Console.WriteLine($"\n{item.QuestionText}\n\n" +
                                        $"A) {item.A}\n" +
                                        $"B) {item.B}\n" +
                                        $"C) {item.C}\n" +
                                        $"D) {item.D}\n" +
                                        $"True variant {item.TrueAnswer}");

                                }
                            }
                            else
                            {
                                 Console.Clear();
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("Sory, there is not any questions...");
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                            }
                            
                          
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("Please enter ID for delete question:");
                            int idForDelete = int.Parse(Console.ReadLine());
                            questions.DeleteQuestion(idForDelete);
                            break;
                        case 4:
                            questions.StartExam(student );
                            break;
                     
                        case 5:
                            Console.Clear();
                            isTrue = false;
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine("Exited the program...");
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                            break;
                        case 6:
                            Console.Clear();
                            List<StudentInfo> studentInfo = student.GetAllStudentsInfo();
                            if (studentInfo.Count > 0)
                            {
                                foreach (var item in studentInfo)
                                {
                                    Console.WriteLine($"\nName: {item.Name}\n" +
                                      $"Surname: {item.Surname}\n" +
                                      $"Age: {item.Age}\n" +
                                      $"Group: {item.Group}\n" +
                                      $"Result: {item.Result}\n");
                                }
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("Sory, there is not any student...");
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                            }
                           
                            break;
                        case 0:
                            Console.Clear();
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine("Please enter a correct button(0, 1, 2, 3, 4, 5, 6)");
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");

                            break;
                    }
                }
                catch (Exception)
                {

                    Console.Clear();
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("Unexpected error. Please try again...");
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
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
            Questions finded = questions.Find(x => x.Id == id);
            questions.Remove(finded);

        }

        public void StartExam(StudentInfo student)
        {
            
            if (questions.Count > 0)
            {
                Console.WriteLine("Please enter name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Please enter surname: ");
                string surname = Console.ReadLine();
                Console.WriteLine("Please enter age: ");
                byte age = byte.Parse(Console.ReadLine());
                Console.WriteLine("Please enter group: ");
                string group = Console.ReadLine();
                Console.Clear();
                Console.WriteLine($"------------------------------------------------------------------------------------------------------------------------\n" +
                    $"Start exam. Question count: {questions.Count}.\n" +
                    $"------------------------------------------------------------------------------------------------------------------------");

                int countTrue = 0;
                int questionsCount = 1;
                string result = "";
                foreach (var item in questions)
                {
                    Console.WriteLine($"\n{questionsCount}. {item.QuestionText}\n\n" +
                        $"A) {item.A}\n" +
                        $"B) {item.B}\n" +
                        $"C) {item.C}\n" +
                        $"D) {item.D}\n");
                    Console.WriteLine("Chose the correct variant");
                    char answer = Convert.ToChar(Console.ReadLine().ToUpper());
                    if (answer == item.TrueAnswer)
                    {
                        result += $"{questionsCount}. {item.TrueAnswer} + {answer}, ";
                        countTrue++;
                    }
                    else
                    {
                        result += $"{questionsCount}. {item.TrueAnswer} - {answer} ";
                    }

                    questionsCount++;
                }


                StudentInfo studentInfo = new StudentInfo()
                {
                    Name = name,
                    Surname = surname,
                    Age = age,
                    Group = group,
                    Result = result,
                };

                student.SetInfo(studentInfo);
                Console.Clear();
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine($"{result} True questions count {countTrue}");
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            }else
            {
                Console.Clear();
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine($"There are currently no questions in the database.");
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            }
          
        }
    }

    public class StudentInfo
    {
        List<StudentInfo> students = new List<StudentInfo>();
        public string Name { get; set; }
        public string Surname { get; set; }

        public string Group { get; set; }

        public string Result {  get; set; }

        public byte Age { get; set; }

        public void SetInfo(StudentInfo student)
        {
            students.Add(student);
        }

        public List<StudentInfo> GetAllStudentsInfo()
        {
            return students;
        }
    } 
}
