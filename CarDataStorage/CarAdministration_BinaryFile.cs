using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using CarLibrary;
using System.IO;

namespace CarDataStorage
{
    public class CarAdministration_BinaryFile: IDataStorageCars
    {

        private const int FIRST_CAR_ID = 1;
        private const int INCREMENT_CAR = 1;

        string FileName { get; set; }

        public CarAdministration_BinaryFile(string fileName)
        {
            this.FileName = fileName;
            Stream carBinFile = File.Open(FileName, FileMode.OpenOrCreate);
            carBinFile.Close();
        }

        public void AddCar(Cars carr)
        {
            carr.IdCar = GetIdCar();

            try
            {
                BinaryFormatter b_car = new BinaryFormatter();

                using (Stream carBinFile = File.Open(FileName, FileMode.Append, FileAccess.Write))
                {
                    b_car.Serialize(carBinFile, carr);
                }

            }
            catch (IOException eIO)
            {
                throw new Exception("Error at file opening. Message: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Generic error. Message: " + eGen.Message);
            }

        }

        public List<Cars> GetCars()
        {
            List<Cars> cars = new List<Cars>();
            try
            {
                BinaryFormatter carr = new BinaryFormatter();

                using (Stream carBinFile = File.Open(FileName, FileMode.Open))
                {

                    while(carBinFile.Position < carBinFile.Length)
                    {
                        cars.Add((Cars)carr.Deserialize(carBinFile));
                    }

                }

            }
            catch (IOException eIO)
            {
                throw new Exception("Error at file opening. Message: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Generic error. Message: " + eGen.Message);
            }
            return cars;
        }

        public Cars GetCar(int idCar)
        {
            throw new Exception("GetCar by Id not implemented");
        }

        public Cars GetCar(string make, string model)
        {
            throw new Exception("GetCar not implemented");
        }

        public bool UpdateCar(Cars carr)
        {
            throw new Exception(" UpdateClient not implemented");
        }

        private int GetIdCar()
        {
            int IdCar = FIRST_CAR_ID;
            try
            {

                using (Stream carBinFile = File.Open(FileName, FileMode.Open))
                {
                    BinaryFormatter b_car = new BinaryFormatter();

                    while (carBinFile.Position < carBinFile.Length)
                    {
                        Cars carr = (Cars)b_car.Deserialize(carBinFile);
                        IdCar = carr.IdCar + INCREMENT_CAR;
                    }

                }

            }
            catch (IOException eIO)
            {
                throw new Exception("Error at file opening. Message: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Generic error. Message: " + eGen.Message);
            }
            return IdCar;
        }

    }
}
