using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace rent_a_car
{
    internal class Program
    {
        static CarManager carManager = new CarManager();
        static List<Car> carList = carManager.GetCars();

        static void Main(string[] args)
        {
            bool isContunie = true;

            while (isContunie)
            {
                Console.WriteLine("1-Log in as the car owner.  2-Log in as a customer.");
                bool isMainCommand = int.TryParse(Console.ReadLine(), out int mainCommand);

                if (isMainCommand)
                {
                    switch (mainCommand)
                    {
                        //Owner Section
                        case 1:
                            ForOwner();
                            break;
                        //Customer Section
                        case 2:
                            if (carList.Count > 0)
                            {
                                ForCustomer();
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Sorry, Has not any car in list.\n");
                            }
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Please choose true command.\n");
                            break;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Please choose true command.\n");
                }
            }



        }

        // Owner section Start
        public static void AddCar()
        {
            Console.Clear();
            Console.WriteLine("Please enter car number:");
            string carNumber = Console.ReadLine();
            Console.WriteLine("Please enter car brand:");
            string carBrand = Console.ReadLine();
            Console.WriteLine("Please enter car model:");
            string carModel = Console.ReadLine();
            Console.WriteLine("Please enter car year:");
            int carYear = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter car price of day:");
            int priceOfDay = int.Parse(Console.ReadLine());
            Console.WriteLine("Is car active?:");
            bool isActive = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("\n1-Add Buisness Car, 2-Add Econom Car, 3-Add Lux Car");
            bool isAddCommand = int.TryParse(Console.ReadLine(), out int addCommand);

            if (isAddCommand)
            {

                switch (addCommand)
                {
                    case 1:

                        BuisnessCar newBuisnessCar = new()
                        {
                            CarNumber = carNumber,
                            CarBrand = carBrand,
                            CarModel = carModel,
                            CarYear = carYear,
                            PriceOfDay = priceOfDay,
                            IsActive = isActive
                        };

                        carManager.AddCar(newBuisnessCar);
                        Console.Clear();
                        Console.WriteLine("Buisness car succsesfuly added.\n");
                        break;
                    case 2:
                        EconomCar newEconomCar = new()
                        {
                            CarNumber = carNumber,
                            CarBrand = carBrand,
                            CarModel = carModel,
                            CarYear = carYear,
                            PriceOfDay = priceOfDay,
                            IsActive = isActive
                        };

                        carManager.AddCar(newEconomCar);
                        Console.Clear();
                        Console.WriteLine("Econom car succsesfuly added.\n");
                        break;
                    case 3:
                        LuxCar newLuxCar = new()
                        {
                            CarNumber = carNumber,
                            CarBrand = carBrand,
                            CarModel = carModel,
                            CarYear = carYear,
                            PriceOfDay = priceOfDay,
                            IsActive = isActive
                        };

                        carManager.AddCar(newLuxCar);
                        Console.Clear();
                        Console.WriteLine("Lux car succsesfuly added.\n");
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Please choose true command.\n");
                        break;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Please choose true command.\n");
            }
        }

        public static void GetAllCar()
        {
            Console.Clear();

            foreach (var item in carList)
            {
                Console.WriteLine($"Brand: {item.CarBrand}\n" +
                    $"Model: {item.CarModel} \n" +
                    $"Number: {item.CarNumber} \n" +
                    $"Year: {item.CarYear}\n" +
                    $"Is active: {item.IsActive}");

                
                if (item is BuisnessCar buisness)
                {
                    Console.WriteLine($"Class: {buisness.TypeCar}\n");
                }

                else if (item is LuxCar lux)
                {
                    Console.WriteLine($"Class: {lux.TypeCar}\n");
                }

                else if (item is EconomCar econom)
                {
                    Console.WriteLine($"Class: {econom.TypeCar}\n");
                }
            }
        }

        public static void RemoveCar(string carNumber)
        {
            Console.Clear();
            List<Car> carList = carManager.GetCars();
           
            bool isChek = false;

            for(int i = 0; i < carList.Count; i++)
            {
                if (carList[i].CarNumber == carNumber)
                {
                    carList.Remove(carList[i]);
                    Console.WriteLine($"{carList[i].CarBrand} succsesfuly remove or rezerved from car list.");
                    isChek = true;
                    break;
                }
            }

            if (isChek)
            {
                Console.WriteLine($"Car number {carNumber}  was not found");
            }

        }

        public static void ForOwner()
        {
            Console.Clear();
            Console.WriteLine("1-Add  car, 2-Show all car, 4-Remove car");
            bool isOwnerCommand = int.TryParse(Console.ReadLine(), out int ownerCommand);
            if (isOwnerCommand)
            {
                switch (ownerCommand)
                {
                    //Add section
                    case 1:

                        AddCar();
                        break;
                    //Car list section
                    case 2:

                        GetAllCar();

                        break;
                    //Car remove section
                    case 3:
                        Console.WriteLine("Please enter a car number for reamove from list.");
                        string carNumber = Console.ReadLine();
                        RemoveCar(carNumber); 

                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Please choose true command.\n");
            }
        }

        //Owner section end

        //Customer section start

        public static void ForCustomer()
        {
            Console.Clear();
            startChooseCar:
            Console.WriteLine("1-Business car, 2-Lux Car, 3-Econom car, 4-All car");
            bool isChoose = int.TryParse(Console.ReadLine(), out int choose);
            if (isChoose)
            {
                switch (choose)
                {
                    case 1:
                       
                        bool isBusines = true;
                        foreach (var item in carList)
                        {
                            if (item is BuisnessCar buisness)
                            {
                                Console.WriteLine($"Brand: {item.CarBrand}\n" +
                                $"Model: {item.CarModel} \n" +
                                $"Number: {item.CarNumber} \n" +
                                $"Year: {item.CarYear}\n" +
                                $"Is active: {item.IsActive}");
                                Console.WriteLine($"Class: {buisness.TypeCar}\n");
                                isBusines = false;
                                goto startChooseCar;
                            }
                        }

                        if (isBusines)
                        {
                            Console.Clear();
                            Console.WriteLine("Not find busines car/n");
                            goto startChooseCar;
                        }


                        break;
                    case 2:
                        bool isLux = true;
                        foreach (var item in carList)
                        {
                            if (item is LuxCar lux)
                            {
                                Console.WriteLine($"Brand: {item.CarBrand}\n" +
                                $"Model: {item.CarModel} \n" +
                                $"Number: {item.CarNumber} \n" +
                                $"Year: {item.CarYear}\n" +
                                $"Is active: {item.IsActive}\n" +
                                $"Class: {lux.TypeCar}");
                                isLux= false;
                            }
                            goto startChooseCar;
                        }

                        if (isLux)
                        {
                            Console.Clear();
                            Console.WriteLine("Not find Lux car.\n");
                            goto startChooseCar;

                        }
                        break;
                    case 3:
                        bool isEco = true;
                        foreach (var item in carList)
                        {
                            if (item is EconomCar eco)
                            {
                                Console.WriteLine($"Brand: {item.CarBrand}\n" +
                                $"Model: {item.CarModel} \n" +
                                $"Number: {item.CarNumber} \n" +
                                $"Year: {item.CarYear}\n" +
                                $"Is active: {item.IsActive}\n" +
                                $"Class: {eco.TypeCar}");
                                isEco = false;
                            }
                            goto startChooseCar;
                        }

                        if (isEco)
                        {
                            Console.Clear();
                            Console.WriteLine("Not find econom car.\n");
                            goto startChooseCar;
                        }
                        break;
                    case 4:
                        GetAllCar();
                        goto startChooseCar;
                        break;
                    case 5:
                        RentACar();
                       
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Please choose true command.\n");
                        goto startChooseCar;
                        break;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Please choose true command.\n");
                goto startChooseCar;
            }
        }

        public static void RentACar()
        {
        startBuyCar:
            Console.WriteLine("Please enter you want car number.");
            string carNumber = Console.ReadLine();
            int dayOfCar = 0;
            int TotalPrice = 0;
            foreach (var item in carList)
            {
                if (item.CarNumber == carNumber)
                {
                    Console.WriteLine("How many days do you want the car?");
                     dayOfCar = int.Parse(Console.ReadLine());
                     TotalPrice = dayOfCar * item.PriceOfDay;
                }
            }
            Console.Clear();
            Console.WriteLine($"Toatal price for {dayOfCar} day: {TotalPrice}");

            bool IsBuyChoose = int.TryParse(Console.ReadLine(), out int buyChoose);

            if (IsBuyChoose)
            {
                switch (buyChoose)
                {
                    case 1:
                        RemoveCar(carNumber);
                        Console.WriteLine("Car succesfuly rezerved.");
                        break;
                    case 2:
                        Console.WriteLine("Choose car.");
                        goto startBuyCar;
                        
                    default:
                        Console.WriteLine($"Please choose the true command.");
                        goto startBuyCar;
                     
                }
            }
            else
            {
                Console.WriteLine($"Please choose the true command.");
                goto startBuyCar;
            }
        }
    }
}
