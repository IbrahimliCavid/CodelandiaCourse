using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace ConsoleApp2
{
    internal class Program
    {
        static List<User> userList = new List<User>();
        static UserManager userManager = new UserManager(userList);
        static void Main(string[] args)
        {
        startProgram:
            try
            {
                bool isContinue = true;
                while (isContinue)
                {
                    Console.WriteLine("1-User Log in, 2-Admin Login\n");
                    bool isCommand = int.TryParse(Console.ReadLine(), out int command);
                    if (isCommand)
                    {
                        switch (command)
                        {
                            //User section
                            case 1:
                                UserAccount();
                                break;
                            //Admin section
                            case 2:
                                AdminAccount();
                                break;
                            default:
                                Console.WriteLine("Please enter true command!\n");
                                break;
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Please enter true command!\n");
                    }
                }
            }
            catch (FormatException)
            {
                Console.Clear();
                Console.WriteLine("Enter only number!!! Please try again\n");
                goto startProgram;
            }catch(Exception)
            {
                Console.Clear();
                Console.WriteLine("Unexpected erorr!!! Please try again:)...\n");
                goto startProgram;
            }
          
        }
        // User section Start
        public static void UserAccount()
        {
            Console.WriteLine("1-Sign up, 2-Log in, 3-Main menu\n");
            bool isUserChoose = int.TryParse(Console.ReadLine(), out int userChoose);
            if (isUserChoose)
            {
                switch (userChoose)
                {
                    //Sign up
                    case 1:
                        SignUp();
                        Console.WriteLine("User succsesfuly added.\n");
                        break;
                    //Log in
                    case 2:
                        LogIn();
                        break;
                    //Main Menu
                    case 3:
                        isUserChoose = false;
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Please enter true command!\n");
                        break;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Please enter true command!\n");
            }
        }

        public static void SignUp()
        {
            Console.Write("Please enter name: ");
            string name = Console.ReadLine();
            Console.Write("Please enter surname: ");
            string surname = Console.ReadLine();
            Console.Write("Please enter age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Please enter email: ");
            string email = Console.ReadLine();
            Console.Write("Please enter password: ");
            string password = Console.ReadLine();
            DateTime dateTime = DateTime.Now;

            Random random = new Random();
            int rndNum = random.Next(1, 100);
            decimal id = dateTime.Millisecond * rndNum;

            User user = new()
            {
                Name = name,
                Surname = surname,
                Age = age,
                Email = email,
                Password = password,
                Id = id
            };
            userList.Add(user);

        }

        public static void LogIn()
        {
            Console.Clear();
            int countEnter = 1;
        startLogIn:

            Console.Write("Please enter email: ");
            string email = Console.ReadLine();
            Console.Write("Please enter password: ");
            string password = Console.ReadLine();

            var foundedUser = userList.Find(x => x.Email == email && x.Password == password);

            if (foundedUser != null)
            {
                Console.Clear();
                Console.WriteLine("1-Remove account, 2-Log Out\n");
                Console.WriteLine($"Welcom {foundedUser.Name} {foundedUser.Surname}!\n\n" +
                    $"Name: {foundedUser.Name}\n" +
                    $"Surname: {foundedUser.Surname}\n" +
                    $"Email: {foundedUser.Email}");


                bool isAccountChoose = int.TryParse(Console.ReadLine(), out int accountChoose);
                if (isAccountChoose)
                {
                    switch (accountChoose)
                    {
                        case 1:
                            Console.Clear();
                            userList.Remove(foundedUser);

                            Console.WriteLine("Your account is succsesfuly removed.");
                            break;
                        case 2:

                            Console.Clear();
                            Console.WriteLine("Log out...");
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Please enter true command!\n");
                            break;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Please enter true command!\n");
                }


            }
            else if (countEnter == 3)
            {
                Console.Clear();
                Console.WriteLine("User blocked, because 3 incorrect try.!!!\n");
            }
            else
            {

                Console.Clear();
                countEnter++;
                Console.WriteLine("Email or password incorrected!!! Please try again...\n");

                goto startLogIn;
            }
        }
        // User section end

        //Admin section

        public static void AdminAccount()
        {
            const string email = "adminadmin";
            const string password = "admin123";
            Console.Write("Please enter email: ");
            string enterEmail = Console.ReadLine();
            Console.Write("Please enter password: ");
            string enterPassword = Console.ReadLine();

            if (email == enterEmail && password == enterPassword)
            {
            startAdminChoose:
                Console.WriteLine("1-List All User, Remove User With Name, 3-Remove All User, 4-Update User");
                bool isAdminChoose = int.TryParse(Console.ReadLine(), out int adminChoose);
                if (isAdminChoose)
                {
                    switch (adminChoose)
                    {
                        case 1:
                            if (userList.Count != 0)
                            {
                              ListAllUser();
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("List is empty...\n");
                                goto startAdminChoose;
                            }



                            break;
                        case 2:
                            if (userList.Count != 0)
                            {

                                Console.Clear();
                                Console.WriteLine("Please enter name for remove the list:");
                                string nameForRemove = Console.ReadLine();
                                RemoveUserWithName(nameForRemove);
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("List is empty...\n");
                                goto startAdminChoose;
                            }

                            break;
                        case 3:
                            Console.Clear();
                            RemoveAllUser();
                            Console.WriteLine("All user succesfuly removed...\n");
                            break;
                        case 4:
                            if (userList.Count != 0)
                            {
                                UpdateUserWithId();
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("List is empty...\n");
                                goto startAdminChoose;
                            }

                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Please enter true command!\n");
                            break;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Please enter true command!\n");
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("User blocked, because 3 incorrect try.!!!\n");
            }
        }

        public static void ListAllUser()
        {
            List<User> users = userManager.GetAllUser();
            foreach (var item in users)
            {
                Console.WriteLine($"Name: {item.Name}\n" + $"Surname: {item.Surname}\n" + $"Age: {item.Age}\n" + $"Email: {item.Email}\n" + $"Id: {item.Id}");
            }
        }
        public static void RemoveUserWithName(string nameForRemove)
        {
            userManager.RemoveUser(nameForRemove, out string message);
            Console.WriteLine(message);
        }

        public static void RemoveAllUser()
        {
            userList.Clear();
        }
        public static void UpdateUserWithId()
        {
            Console.WriteLine("Please enter id for update");
            int idForUp = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter name:");
            string nameForUp = Console.ReadLine();
            Console.WriteLine("Please enter surname:");
            string surnameForUp = Console.ReadLine();
            Console.WriteLine("Please enter age:");
            int ageForUp = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter email:");
            string emailForUp = Console.ReadLine();
            User userUp = new()
            {
                Name = nameForUp,
                Age = ageForUp,
                Surname = surnameForUp,
                Email = emailForUp,
                Id = idForUp
            };


            userManager.UpdateUser(userUp, idForUp, out string messageUp);
            Console.WriteLine(messageUp);
        }

        //End Admin Section


    }

    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Id { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public class UserManager
    {
        private List<User> _users = new List<User>();
        public UserManager(List<User> users)
        {
            _users = users;
        }

        public List<User> GetAllUser()
        {
            return _users;
        }

        public void RemoveUser(string name, out string message)
        {
            bool isTrue = false;
            foreach (var item in _users)
            {
                if (item.Name == name)
                {
                    isTrue = true;
                }

            }

            if (isTrue)
            {
                message = "Succesfuly removed..\n";
            }
            else
            {
                message = "User not find.\n";
            }



        }

        public void UpdateUser(User user, int id, out string message)
        {
            bool isTrue = false;
            foreach (var item in _users)
            {
                if (item.Id == id)
                {
                    isTrue = true;
                    int index = _users.IndexOf(item);
                    _users.Remove(item);
                    _users.Insert(index, user);
                    break;
                }
            }

            if (isTrue)
            {
                message = "Succsesfuly update.";
            }
            else
            {
                message = $"User not found (ID = {id})";
            }
        }


    }

}
