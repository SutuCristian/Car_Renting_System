using CarLibrary;

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CarDataStorage
{
    public class CarAdministration: IDataStorageCars
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

        public List<Cars> GetCars()
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

            return cars.Cast<Cars>().ToList();

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

        private int GetCar()
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

        public Cars GetCar(int idCar)
        {

            using (StreamReader streamReader = new StreamReader(fileNameCar))
            {
                string fileLine;

                while ((fileLine = streamReader.ReadLine()) != null)
                {
                    Cars car = new Cars(fileLine);
                    if (car.IdCar == idCar)
                        return car;
                }
            }
            return null;

        }

        public bool UpdateCar(Cars updatedCar)
        {
            List<Cars> cars = GetCars();
            bool successfullyUpdated = false;

            using (StreamWriter streamWriterTextFile = new StreamWriter(fileNameCar, false))
            {
                foreach (Cars car in cars)
                {
                    Cars writeInFileCar = car;

                    if (car.IdCar == updatedCar.IdCar)
                    {
                        writeInFileCar = updatedCar;
                    }
                    streamWriterTextFile.WriteLine(writeInFileCar.ConvertToString_ForFile());
                }
                successfullyUpdated = true;
            }
            return successfullyUpdated;
        }

        private int GetIdCar()
        {
            int IdCar = FIRST_CAR_ID;

            using (StreamReader streamReader = new StreamReader(fileNameCar))
            {
                string fileLine;

                while((fileLine = streamReader.ReadLine())!= null)
                {
                    Cars car = new Cars(fileLine);
                    IdCar = car.IdCar + INCREMENT_CAR;
                }

            }
            return IdCar;

        }

    }
}
