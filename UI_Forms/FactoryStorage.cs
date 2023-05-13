using ClientDataStorage;
using System.Configuration;
using System.IO;

namespace UI_Forms
{
    internal class FactoryStorage
    {
        private const string SAVE_FORMAT = "SaveFormat";
        private const string FILE_NAME = "FileName";

        public static IDataStorageClients GetAdminStorage()
        {
            string saveFormat = ConfigurationManager.AppSettings[SAVE_FORMAT];

            string fileName = ConfigurationManager.AppSettings[FILE_NAME];
            string solutionFileLocation = Directory.GetParent(System.IO.Directory.GetCurrentDirectory() ).Parent.FullName;
            string completeFilePath = solutionFileLocation + "\\" + fileName;

            if (saveFormat != null)
            {
                switch(saveFormat)
                {
                    default:
                    case "bin":
                        return new ClientAdministration_BinaryFile(completeFilePath + "." + saveFormat);
                    case "txt":
                        return new ClientAdministration(completeFilePath + "." + saveFormat);
                }
            }
            return null;
        }
    }
}
