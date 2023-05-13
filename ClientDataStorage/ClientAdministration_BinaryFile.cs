using ClientLibrary;

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography.X509Certificates;

namespace ClientDataStorage
{
    public class ClientAdministration_BinaryFile: IDataStorageClients
    {
        private const int FIRST_CLIENT_ID = 1;
        private const int INCREMENT_CLIENT = 1;

        string FileName { get; set; }

        public ClientAdministration_BinaryFile(string fileName)
        {
            this.FileName = fileName;
            Stream cliBinFile = File.Open(FileName, FileMode.OpenOrCreate);
            cliBinFile.Close();
        }

        public void AddClient(Clients cli)
        {
            cli.IdClient = GetIdClient();

            try
            {
                BinaryFormatter b_cli = new BinaryFormatter();

                using (Stream cliBinFile = File.Open(FileName, FileMode.Append, FileAccess.Write))
                {
                    b_cli.Serialize(cliBinFile, cli);
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Error at file opening. Message: " + eIO.Message);
            }
            catch(Exception eGen)
            {
                throw new Exception("Generic error. Message: " + eGen.Message);
            }
        }

        public List<Clients> GetClients()
        {
            List<Clients> clients = new List<Clients>();

            try
            {
                BinaryFormatter b_cli = new BinaryFormatter();

                using (Stream cliBinFile = File.Open(FileName, FileMode.Open))
                {
                    while (cliBinFile.Position < cliBinFile.Length)
                    {
                        clients.Add((Clients)b_cli.Deserialize(cliBinFile));
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

            return clients;

        }

        public Clients GetClient(int idClient)
        {
            throw new Exception("GetClient by Id not implemented");
        }

        public Clients GetClient(string first_name, string last_name)
        {
            throw new Exception("GetClient not implemented");
        }

        public bool UpdateClient(Clients cli)
        {
            throw new Exception(" UpdateClient not implemented");
        }

        private int GetIdClient()
        {
            int IdClient = FIRST_CLIENT_ID;

            try
            {
                using (Stream cliBinFile = File.Open(FileName, FileMode.Open))
                {
                    BinaryFormatter b_cli = new BinaryFormatter();

                    while (cliBinFile.Position < cliBinFile.Length)
                    {
                        Clients cli = (Clients)b_cli.Deserialize(cliBinFile);
                        IdClient = cli.IdClient + INCREMENT_CLIENT;
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
            return IdClient;
        }

    }
}
