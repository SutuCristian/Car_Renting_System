using CarLibrary;

using System.Collections;
using System.IO;
using System.Reflection;

namespace CarDataStorage
{
    public class CarAdministration
    {
        private const int MaxCars = 50;
        private const int FIRST_CAR_ID = 1;
        private const int INCREMENT_CAR = 1;

        private string fileNameCar;

        public CarAdministration(string fileName)
        {
            this.fileNameCar = fileName;
            Stream streamTextFile = File.Open(fileName, FileMode.OpenOrCreate);
            streamTextFile.Close();
        }

        public void AddCar(Cars car)
        {
            car.IdCar = GetIdCar();

            using (StreamWriter streamWriterTextFile = new StreamWriter(fileNameCar, true))
            {
                streamWriterTextFile.WriteLine(car.ConvertToString_ForFile());
            }
        }

        public ArrayList GetCars()
        {
            ArrayList cars = new ArrayList();

            using (StreamReader streamReader = new StreamReader(fileNameCar))
            {
                string fileLine;

                while((fileLine = streamReader.ReadLine()) != null)
                {
                    Cars car = new Cars(fileLine);
                    cars.Add(car);
                }
            }

            return cars;

        }

        public Cars GetCar(string make, string model)
        {
            using (StreamReader streamReader = new StreamReader(fileNameCar))
            {
                string fileLine;

                while ((fileLine = streamReader.ReadLine()) != null)
                {
                    Cars car = new Cars(fileLine);
                    if (car.Make.Equals(make) && car.Model.Equals(model))
                        return car;
                }
            }

            return null;

        }

        private int GetIdCar()
        {
            int IdCar = FIRST_CAR_ID;

            using (StreamReader streamReader = new StreamReader(fileNameCar))
            {
                string fileLine;

                while ((fileLine = streamReader.ReadLine()) != null)
                {
                    Cars car = new Cars(fileLine);
                    IdCar = car.IdCar + INCREMENT_CAR;
                }
            }

            return IdCar;

        }

        public Cars[] GetCars(out int nrCars)
        {
            Cars[] cars = new Cars[MaxCars];

            using (StreamReader streamReader = new StreamReader(fileNameCar))
            {
                string fileLine;
                nrCars = 0;

                while ((fileLine = streamReader.ReadLine()) != null)
                {
                    cars[nrCars++] = new Cars(fileLine);
                }
            }

            return cars;
        }

    }
}
