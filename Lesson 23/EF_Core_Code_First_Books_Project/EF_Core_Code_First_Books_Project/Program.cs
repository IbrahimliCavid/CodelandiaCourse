


using EF_Core_Code_First_Books_Project.DataAccess.Abstract;
using EF_Core_Code_First_Books_Project.DataAccess.Concret;
using EF_Core_Code_First_Books_Project.Entities.Concret;

namespace EF_Core_Code_First_Books_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - Nationality Manage");
            bool IsCommand = int.TryParse(Console.ReadLine(), out int command);

            while (true)
            {
                if (IsCommand)
                {
                    switch (command)
                    {
                        case 1:
                            NationalityManager();
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        private static void NationalityManager()
        {
        StartNationalityManage:
            NationalityRepository nationalityRepository = new NationalityRepository();
        

            while (true)
            {
                Console.WriteLine("1 - Add, 2 - Remove by ID, 3 - Remove All, 4 - Show All Nationality, 5 - Update Nationality, 0 - Log Out");
                bool IsCommand = int.TryParse(Console.ReadLine(), out int command);
                if (IsCommand)
                {
                    switch (command)
                    {
                        case 1:
                            var nationality = NationalityCreate();
                            if (nationality != null)
                            {
                                nationalityRepository.Add(nationality);
                                Console.WriteLine($"{nationality.Name} succssesfuly added to Nationality...");
                            }
                            else
                            {
                                Console.WriteLine("You can't leave the information blank!!!");
                                goto StartNationalityManage;
                            }
                            break;
                        case 2:
                            Console.Clear();
                            var nationalitiesDelete = nationalityRepository.GetAll();
                            ShowNationalities(nationalitiesDelete);
                            int id =  CheckNationalityId();
                            nationalityRepository.DeleteById(id);
                            break;
                        case 3:
                            nationalityRepository.DeleteAll();
                            Console.WriteLine("All nationality removed successfully...");
                            break;
                        case 4:
                            Console.Clear();
                            var nationalitiesShow = nationalityRepository.GetAll();
                            ShowNationalities(nationalitiesShow);
                            break;
                        case 5:
                            Console.Clear();
                            var nationalitiesUpdate = nationalityRepository.GetAll();
                            ShowNationalities(nationalitiesUpdate);

                            UpdateNationlity(nationalityRepository);
                            break;
                        default:
                            break;
                    }
                }
            }
        }


        private static Nationality UpdateNationlity(NationalityRepository item)
        {
            Console.Write("Please enter a name:");
            string name = Console.ReadLine();
            Console.Write("Please enter ID:");
            int id = int.Parse(Console.ReadLine());
            var nationality = item.Get(id);

            nationality.Name = name;
            return nationality;
        }
        private static int CheckNationalityId()
        {
            StartEnterID:
            Console.Write("Please enter nationality ID: ");
            bool isId = int.TryParse(Console.ReadLine(), out int id);
            if (isId)
            {
                Console.WriteLine("Succesfuly removed...");
                return id;
            }
            Console.WriteLine("Please enter correct simvol!!!");
            goto StartEnterID;
            
           

        }

        private static void ShowNationalities(List<Nationality> nationalities)
        {
            Console.WriteLine();
            foreach (var item in nationalities)
            {
                Console.WriteLine($"Name: {item.Name} ----- ID: {item.Id}\n");
            }
        }

        private static Nationality NationalityCreate()
        {

            Console.WriteLine("Please enter a nationalty name: ");
            string name = Console.ReadLine();

            Nationality nationality = new Nationality()
            {
                Name = name
            };

            return nationality;


        }
    }
}
