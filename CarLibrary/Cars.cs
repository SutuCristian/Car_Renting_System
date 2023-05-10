using System;

namespace CarLibrary
{
    public class Cars
    {
        private const char MAIN_FILE_SEPARATOR = ';';

        private const int ID_CAR = 0;
        private const int MAKE = 1;
        private const int MODEL = 2;
        private const int YEAR = 3;
        private const int PRICE = 4;
        private const int COLOR = 5;
        private const int OPTIONS = 6;

        [Flags]
        public enum CarOptions
        {
            None = 0,
            AirConditioner = 1,
            AutomaticTransmission = 2,
            CruiseControl = 4,
            NavigationSystem = 8,
            Sunroof = 16,
            FourWheelDrive = 32
        }

        public int IdCar { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }
        public CarColor Color { get; set; }
        public CarOptions Options { get; set; }

        public Cars()
        {
            Make = Model = string.Empty;
            Year = 0;
            Price = 0;
            Color = CarColor.Unknown;
            Options = CarOptions.None;
        }

        public Cars(int idCar, string make, string model, int year, double price, CarColor color, CarOptions options)
        {
            this.IdCar = idCar;
            this.Make = make ?? throw new ArgumentNullException(nameof(make));
            this.Model = model ?? throw new ArgumentNullException(nameof(model));
            this.Year = year;
            this.Price = price;
            this.Color = color;
            this.Options = options;
        }

        public Cars(string fileLine)
        {
            var fileData = fileLine.Split(MAIN_FILE_SEPARATOR);

            IdCar = Convert.ToInt32(fileData[ID_CAR]);
            Make = fileData[MAKE];
            Model = fileData[MODEL];
            Year = Convert.ToInt32(fileData[YEAR]);
            Price = Convert.ToDouble(fileData[PRICE]);
            Color = (CarColor)Enum.Parse(typeof(CarColor), fileData[COLOR], true);
            Options = (CarOptions)Convert.ToInt32(fileData[OPTIONS]);
        }

        public string InfoCar()
        {
            string info = string.Format("IdCar:{0}, Make: {1}, Model: {2}, Year: {3}, Price: {4}, Color: {5}, Options: {6}",
                IdCar.ToString(),
                (Make ?? " UNKNOWN "),
                (Model ?? " UNKNOWN "),
                Year.ToString(),
                Price.ToString(),
                Color.ToString(),
                Options.ToString());

            return info;
        }

        public string ConvertToString_ForFile()
        {
            string clientObjectForFile = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}{0}{7}",
                MAIN_FILE_SEPARATOR,
                IdCar.ToString(),
                (Make ?? " UNKNOWN "),
                (Model ?? " UNKNOWN "),
                Year.ToString(),
                Price.ToString(),
                Color.ToString(),
                ((int)Options).ToString());

            return clientObjectForFile;
        }
    }

    public enum CarColor
    {
        Unknown,
        Black,
        White,
        Gray,
        Red,
        Blue,
        Green,
        Silver,
        Brown,
        Yellow
    }

    /*public int GetIdCar()
    {
        return idCar;
    }

    public string GetCarMake()
    {
        return make;
    }

    public string GetCarModel()
    {
        return model;
    }

    public int GetCarYear() 
    {
        return year;
    }

    public double GetCarPrice() 
    {
        return price;
    }

    public void SetIdCar(int idCar) 
    {
        this.IdCar = idCar;
    }*/

}

