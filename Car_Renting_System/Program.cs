using System;
using System.Configuration;

using ClientLibrary;
using CarLibrary;

using ClientDataStorage;
using CarDataStorage;
using static CarLibrary.Cars;
using System.IO;

namespace CarRenting_System
{
    class Program
    {
        static void Main()
        {
            Clients client = new Clients();
            string fileName = ConfigurationManager.AppSettings["FileName"];
            string ClientsSolutionFileLocation = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string ClientsCompleteFileLocation = ClientsSolutionFileLocation + "\\" + fileName;
            ClientAdministration adminClients = new ClientAdministration(ClientsCompleteFileLocation);
            int nrClients = 0;
            adminClients.GetClients(out nrClients);

            Cars car = new Cars();
            string fileNameCar = ConfigurationManager.AppSettings["FileNameCar"];
            string CarSolutionFileLocation = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string CarCompleteFileLocation = CarSolutionFileLocation + "\\" + fileNameCar;
            CarAdministration adminCars = new CarAdministration(CarCompleteFileLocation);
            int nrCars = 0;
            adminCars.GetCars(out nrCars);

            string option;
            do
            {
                Console.WriteLine("Welcome to the Car Rental System!");
                Console.WriteLine("1. Add New Client");
                Console.WriteLine("2. Show the last client added");
                Console.WriteLine("3. Show Clients from file");
                Console.WriteLine("4. Save Client in file");
                Console.WriteLine("5. Add New Car");
                Console.WriteLine("6. Show the last car added");
                Console.WriteLine("7. Show Cars from file");
                Console.WriteLine("8. Save Car in file");
                Console.WriteLine("X. Exit");
                Console.WriteLine("Choose an option:");
                option = Console.ReadLine();
                switch (option.ToUpper())
                {
                    case "1":
                        client = ReadClientFromKeyboard();

                        break;

                    case "2":
                        ShowClient(client);

                        break;

                    case "3":
                        Clients[] clients = adminClients.GetClients(out nrClients);
                        ShowClients(clients, nrClients);

                        break;

                    case "4":
                        int idClient = nrClients + 1;
                        client.IdClient = idClient;
                        adminClients.AddClient(client);

                        nrClients++;

                        break;

                    case "5":
                        car = ReadCarFromKeyboard();

                        break;

                    case "6":
                        ShowCar(car);

                        break;

                    case "7":
                        Cars[] cars = adminCars.GetCars(out nrCars);
                        ShowCars(cars, nrCars);

                        break;

                    case "8":
                        int idCar = nrCars + 1;
                        car.IdCar = idCar;
                        adminCars.AddCar(car);

                        nrCars++;

                        break;

                    case "X":

                        return;

                    default:
                        Console.WriteLine("Missing option");

                        break;
                }
            } while (option.ToUpper() != "X");

            Console.ReadKey();
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------
        //Clients

        public static void ShowClient(Clients client)
        {
            string infoClient = string.Format("\nThe client with the id #{0} have the name: {1} {2} , the email {3} and the phone number {4}\n",
                client.IdClient,
                client.First_name ?? " UNKNOWN ",
                client.Last_name ?? " UNKNWON ",
                client.Email_address ?? " UNKNOWN ",
                client.Phone_number ?? " UNKNOWN ");

            Console.WriteLine(infoClient);
        }

        public static void ShowClients(Clients[] clients, int nrClients)
        {
            Console.WriteLine("The clients are: ");
            for (int contor = 0; contor < nrClients; contor++)
            {
                ShowClient(clients[contor]);
            }
        }

        public static Clients ReadClientFromKeyboard()
        {
            Console.WriteLine("Enter the FirstName: ");
            string firstname = Console.ReadLine();

            Console.WriteLine("Enter the LastName: ");
            string lastname = Console.ReadLine();

            Console.WriteLine("Enter the client's email: ");
            string email = Console.ReadLine();

            Console.WriteLine("Enter the client's phone number: ");
            string phone = Console.ReadLine();

            Clients client = new Clients(0, firstname, lastname, email, phone);

            return client;
        }


        //-----------------------------------------------------------------------------------------------------------------------------------------------------
        //Cars

        public static void ShowCar(Cars car)
        {
            string infoCar = string.Format("\nThe car with the id #{0} is a {1} {2}, from the year {3} and the price for renting is {4} euro. " +
                "The color is {5} and it has the following options: {6}.\n",
                car.IdCar,
                car.Make ?? " UNKNOWN ",
                car.Model ?? " UNKNWON ",
                car.Year ?? " UNKNOWN ",
                car.Price ?? " UNKNOWN ",
                car.Color,
                car.Options);

            Console.WriteLine(infoCar);
        }

        public static void ShowCars(Cars[] cars, int nrCars)
        {
            Console.WriteLine("The cars are: ");
            for (int contor = 0; contor < nrCars; contor++)
            {
                ShowCar(cars[contor]);
            }
        }

        public static Cars ReadCarFromKeyboard()
        {
            Console.WriteLine("Enter the maker of the car: ");
            string make = Console.ReadLine();

            Console.WriteLine("Enter the model of the car: ");
            string model = Console.ReadLine();

            Console.WriteLine("Enter the car's year: ");
            string year = Console.ReadLine();

            Console.WriteLine("Enter the car's price for renting: ");
            string price = Console.ReadLine();

            Console.WriteLine("Enter the car's color (Black, White, Gray, Red, Blue, Green, Silver, Brown, Yellow):");
            CarColor color = (CarColor)Enum.Parse(typeof(CarColor), Console.ReadLine(), true);

            Console.WriteLine("Enter the car's options (separated by commas, choose from: AirConditioner, AutomaticTransmission, CruiseControl, NavigationSystem, Sunroof, FourWheelDrive):");
            string[] options = Console.ReadLine().Split(',');

            CarOptions carOptions = CarOptions.None;

            foreach (string option in options)
            {
                if (Enum.TryParse(option.Trim(), out CarOptions parsedOption))
                {
                    carOptions |= parsedOption;
                }
            }

            Cars car = new Cars(0, make, model, year, price /*, color, carOptions*/);

            return car;
        }

    }
}