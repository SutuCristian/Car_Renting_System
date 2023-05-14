using CarLibrary;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDataStorage
{
    public interface IDataStorageCars
    {
        void AddCar(Cars carr);

        List<Cars> GetCars();

        Cars GetCar(string make, string model);

        Cars GetCar(int idCar);

        bool UpdateCar(Cars carr);
    }
}
