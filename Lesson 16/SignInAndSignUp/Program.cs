using SignInAndSignUp.Controls.Concret;
using SignInAndSignUp.DataBase;
using SignInAndSignUp.Entity;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace SigInAndSignUp
{
    internal class Program
    {
        private readonly static UserManager userManager = new UserManager();

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            bool isC = true;
            while (isC)
            {
                Console.WriteLine("1-Daxil ol \n2-Qeydiyyat \n3-Çıxış");
                Console.Write("Seçim et(1-3): ");
                var isInteger = int.TryParse(Console.ReadLine(), out int value);

                if (isInteger)
                {
                    switch (value)
                    {
                        case 1:
                            User user = new User();
                            Console.WriteLine("Profil adı: ");
                            user.UserName = Console.ReadLine();
                            Console.WriteLine("Parol: ");
                            user.Password = Console.ReadLine();
                            (string ms, bool ch) = SignIn(user, out User outUser);
                           
                            Console.WriteLine("\nDoğrulama aparılır...");
                            Thread.Sleep(2000);
                            Console.Clear();
                            if (ch)
                            {
                                Account account = new Account(outUser);
                                if (account.Profile.UserName == "admin" && account.Profile.Password == "admin123")
                                {
                                    AdminAccount();
                                }
                                else {
                                    UserAccount(account, ms);
                                }
                              

                            }
                            Console.WriteLine(ms);
                            break;
                        case 2:
                            SignUpController(out User signUpUser, out string repeatPassword);
                            if (SignUp(signUpUser, repeatPassword))
                            {
                                Console.Clear();
                                Console.WriteLine("Əlavə edildi!!");
                                Console.WriteLine("----------------------------------------\n");
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Əlavə edilmədi!!");
                                Console.WriteLine("----------------------------------------\n");
                            }
                            break;
                        case 3:
                            isC = false;
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Düzgün seçim edilməyib!!");
                            Console.WriteLine("----------------------------------------");
                            break;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Düzgün simvol daxil edilməyib!!");
                    Console.WriteLine("----------------------------------------");
                }
            }
        }

        private static bool SignUp(User signUpUser, string repeatPassword)
        {
            if (signUpUser.Password == repeatPassword)
                return userManager.Add(signUpUser);

            return false;
        }

        private static void SignUpController(out User signUpUser,  out string repeatPassword)
        {
            signUpUser = new User();
            Console.WriteLine("Profil adı: ");
            signUpUser.UserName = Console.ReadLine();
            Console.WriteLine("Email: ");
            signUpUser.Email = Console.ReadLine();
            Console.WriteLine("Parol: ");
            signUpUser.Password = Console.ReadLine();
            Console.WriteLine("Tekrar Parol: ");
             repeatPassword = Console.ReadLine();
        }

        private static void ConsoleShowUsers(List<User> users)
        {
            Console.Clear();
            foreach (var user in users)
            {
                if (user.UserName != "admin")
                {
                    Console.WriteLine("\n***********************************");
                    Console.WriteLine($"ID: {user.ID}");
                    Console.WriteLine("Profile adı: " + user.UserName);
                    Console.WriteLine("Email: " + user.Email);
                    Console.WriteLine("Parol: " + user.Password);
                    Console.WriteLine("***********************************");
                }
               
            }
        }

        private static (string m, bool ch) SignIn(User user, out User outUser)
        {
            var check = userManager.HasUser(user, out outUser);
            if (!check)
                return ("Profil adı və ya Parol səhvdir", false);

            return ("Daxil oldunuz)", true);
        }

        private static  void UserAccount(Account account, string ms)
        {
            Console.WriteLine(ms);
            Console.WriteLine("----------------------------------------");

        startSelectCom:
            Console.WriteLine("\n1-Profili göstər" +
                "\n2-Porfili redaktə et" +
                "\n3-Profili sil" +
                "\n4-Profildən çıx");
            Console.WriteLine("\nSeçim et(1-4): ");
            bool isIntegerLogIn = int.TryParse(Console.ReadLine(), out int loginValue);
            if (isIntegerLogIn)
            {
                switch (loginValue)
                {
                    case 1:
                        List<User> a = new List<User>();
                        a.Add(account.Profile);
                        ConsoleShowUsers(a);
                        goto startSelectCom;
                    case 2:
                        User upUser = new User();
                        Console.WriteLine("Profil adı: ");
                        upUser.UserName = Console.ReadLine();
                        Console.WriteLine("Email: ");
                        upUser.Email = Console.ReadLine();
                        Console.WriteLine("Parol: ");
                        upUser.Password = Console.ReadLine();
                        upUser.ID = account.Profile.ID;
                        userManager.Update(upUser);
                        break;

                    case 3:
                        userManager.Delete(account.Profile.ID);
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("Çıxış edildi!!");
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Düzgün seçim edilməyib!!");
                        Console.WriteLine("----------------------------------------");
                        goto startSelectCom;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Düzgün simvol daxil edilməyib!!");
                Console.WriteLine("----------------------------------------");
                goto startSelectCom;
            }
        }

        private static void AdminAccount()
        {
        startSelectCom:
            Console.WriteLine("1-Show all user, 2-Remove all user, 3-Add user, 4-Remove user, 5-Update user, 6-Log Out");
            
            var isAdminCommand = int.TryParse(Console.ReadLine(),out int adminCommand);

            if (isAdminCommand)
            {
                switch (adminCommand)
                {
                    case 1:
                            ConsoleShowUsers(userManager.GetAll());
                        break;
                    case 2:
                        userManager.RemoveAllUser();
                        Console.WriteLine("All users succsesfuly removed.");
                        break;
                    case 3:
                        SignUpController(out User signUpUser, out string repeatPassword);
                        if (SignUp(signUpUser, repeatPassword))
                        {
                            Console.Clear();
                            Console.WriteLine("Əlavə edildi!!");
                            Console.WriteLine("----------------------------------------\n");
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Əlavə edilmədi!!");
                            Console.WriteLine("----------------------------------------\n");
                        }
                        goto startSelectCom;
                        break;
                    case 4:
                        Console.WriteLine("Please enter Id for remove.");
                        int id = int.Parse(Console.ReadLine());
                        userManager.Delete(id);
                        goto startSelectCom;
                        break;
                    case 5:
                        ConsoleShowUsers(userManager.GetAll());
                        Console.WriteLine("\nPlease enter user and id:");
                        User upUser = new User();
                        Console.WriteLine("Id:");
                        upUser.ID = int.Parse(Console.ReadLine());
                        Console.WriteLine("Profil adı: ");
                        upUser.UserName = Console.ReadLine();
                        Console.WriteLine("Email: ");
                        upUser.Email = Console.ReadLine();
                        Console.WriteLine("Parol: ");
                        upUser.Password = Console.ReadLine();
                        userManager.Update(upUser);
                        goto startSelectCom;
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Çıxış edildi!!");
                        break;
                   
                    default:
                        Console.Clear();
                        Console.WriteLine("Düzgün seçim edilməyib!!");
                        Console.WriteLine("----------------------------------------");
                        goto startSelectCom;
                        break;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Düzgün simvol daxil edilməyib!!");
                Console.WriteLine("----------------------------------------");
                goto startSelectCom;
            }
        }
    }
}