using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CarDataStorage;

namespace UI_Forms
{
    public class FactoryStorageCars
    {
        private const string SAVE_FORMAT_CAR = "SaveFormatCar";
        private const string FILE_NAME_CAR = "FileNameCar";

        public static IDataStorageCars GetAdminStorageCar()
        {
            string saveFormat = ConfigurationManager.AppSettings[SAVE_FORMAT_CAR];

            string fileName = ConfigurationManager.AppSettings[FILE_NAME_CAR];
            string solutionFileLocation = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName;
            string completeFilePath = solutionFileLocation + "\\" + fileName;

            if (saveFormat != null)
            {
                switch(saveFormat)
                {
                    default:
                    case "bin":
                        return new CarAdministration_BinaryFile(completeFilePath + "." + saveFormat);
                    case "txt":
                        return new CarAdministration(completeFilePath + "." + saveFormat);
                }
            }
            return null;
        }

    }
}
