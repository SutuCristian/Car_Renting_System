using CarLibrary;

using System.IO;

namespace CarDataStorage
{
    public class CarAdministration
    {
        private const int MaxCars = 50;
        private string fileNameCar;

        public CarAdministration(string fileName)
        {
            this.fileNameCar = fileName;
            Stream streamTextFile = File.Open(fileName, FileMode.OpenOrCreate);
            streamTextFile.Close();
        }

        public void AddCar(Cars car)
        {
            using (StreamWriter streamWriterTextFile = new StreamWriter(fileNameCar, true))
            {
                streamWriterTextFile.WriteLine(car.ConvertToString_ForFile());
            }
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
