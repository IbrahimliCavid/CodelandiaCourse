using System.Threading.Channels;

namespace profile
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            UserManager userManager = new UserManager(new List<User>());
            try
            {
                bool isTrue = true;
                User user = new User();
                while (true)
                {
                    Console.WriteLine("\n1 - Sign Up, 2 - Sign In, 3 - Users list,  4 - Logout\n" +
                        "_____________________________________________________________\n");



                    if (int.TryParse(Console.ReadLine(), out int command))
                    {
                        switch (command)
                        {
                            case 1:
                                Console.Clear();
                                Console.WriteLine("Please enter a name:");
                                string name = Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine("Please enter a surname:");
                                string surname = Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine("Please enter username");
                                string userName = Console.ReadLine().ToLower();
                                Console.Clear();
                                
                            startAge:
                                Console.WriteLine("Please enter age:");
                                int age = 0;
                                if (int.TryParse(Console.ReadLine(), out int enteredAge))
                                {
                                    age = enteredAge;
                                    Console.Clear();
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine($"Please enter correct age!!!\n" +
                                   $"_____________________________________________________________\n");
                                    goto startAge;
                                }

                            startEmail:
                                Console.WriteLine("Please enter a e-mail:");
                                string email = Console.ReadLine();
                                if (!email.Contains('@') || !email.Contains('.'))
                                {
                                    Console.Clear();
                                    Console.WriteLine($"Please enter correct email!!!\n" +
                                   $"_____________________________________________________________\n");
                                    goto startEmail;
                                }
                                Console.Clear();
                                startPassword:
                                Console.WriteLine("Please enter a password:");
                                string password = Console.ReadLine();

                                if (password.Length < 8 || password.Length >16)
                                {
                                    Console.Clear();
                                    Console.WriteLine($"The length of the password must be between 8 and 12 digits!!!\n" +
                              $"_____________________________________________________________\n");
                                    goto startPassword;
                                }
                                DateTime dateTime = DateTime.Now;
                                Random randomNum = new Random();
                                int random = randomNum.Next(1, 3000);
                                decimal id = dateTime.Millisecond * random;

                                User newUser = new User()
                                {
                                    Name = name,
                                    Surname = surname,
                                    UserName = userName,
                                    Age = age,
                                    Email = email,
                                    Password = password,
                                    Id = id,

                                };

                                userManager.AddUser(newUser);
                                Console.Clear();
                                Console.WriteLine($"User successfully added.\n" +
                               $"_____________________________________________________________\n");
                                break;
                            case 2:
                                Console.Clear();
                            startLogin:
                                List<User> users = userManager.GetUser();
                                Console.WriteLine("Please enter username or username");
                                string emailOrUserName = Console.ReadLine();
                                Console.Clear();
                                startLoginPassword:
                                Console.WriteLine("Please enter a password:");
                                string enterPassword = Console.ReadLine();
                                Console.Clear();
                                bool isInto = false;
                                foreach (var item in users)
                                {

                                    if ((item.UserName == emailOrUserName || item.Email == emailOrUserName) && item.Password == enterPassword)
                                    {
                                        Console.Clear();
                                        Console.WriteLine($"Successfully logged in.\n" +
                                       $"_____________________________________________________________\n");
                                        isInto = true;
                                    }

                                    if (item.Password.Length > 16 || item.Password.Length < 8)
                                    {
                                        Console.Clear();
                                        Console.WriteLine($"The length of the password must be between 8 and 12 digits!!!\n" +
                                       $"_____________________________________________________________\n");
                                        goto startLoginPassword;
                                    }
                                }

                                if (!isInto)
                                {
                                    Console.Clear();
                                    Console.WriteLine($"The password or username you entered is incorrect!!!\n" +
                                        $"_____________________________________________________________\n");
                                    goto startLogin;
                                }

                                break;
                            case 3:
                                Console.Clear();
                                List<User> userList = userManager.GetUser();
                                foreach (var item in userList)
                                {
                                    Console.WriteLine($"\nName: {item.Name}\n" +
                                        $"Surname: {item.Surname}\n" +
                                        $"E-mail: {item.Email}\n" +
                                        $"ID: {item.Id}");
                                }
                                break;
                            case 4:
                                Console.Clear();
                                Console.WriteLine($"Logout\n" +
                                        $"_____________________________________________________________\n");
                                isTrue = false;
                                break;
                          
                            default:
                                Console.Clear();
                                Console.WriteLine($"Please enter a correct simvol!!!\n" +
                                        $"_____________________________________________________________\n");
                                break;
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine($"Please enter a correct simvol!!!\n" +
                                $"_____________________________________________________________\n");
                    }


                }
            }
            catch (Exception)
            {

                Console.Clear();
                Console.WriteLine($"UNEXPECTED ERROR\n" +
                        $"_____________________________________________________________\n");
             
            }
        }
    }


  

    
}
