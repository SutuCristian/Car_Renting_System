using ClientLibrary;

using System;
using System.Collections;
using System.IO;




namespace ClientDataStorage
{
    public class ClientAdministration
    {
        private const int MaxClients = 50;
        private const int FIRST_CLIENT_ID = 1;
        private const int INCREMENT_CLIENT = 1;

        private string fileName;

        public ClientAdministration(string fileName)
        {
            this.fileName = fileName;
            Stream streamTextFile = File.Open(fileName, FileMode.OpenOrCreate);
            streamTextFile.Close();
        }

        public void AddClient(Clients client)
        {
            client.IdClient = GetIdClient();

            using (StreamWriter streamWriterTextFile = new StreamWriter(fileName, true))
            {
                streamWriterTextFile.WriteLine(client.ConvertToString_ForFile());
            }
        }

        public ArrayList GetClients()
        {
            ArrayList clients = new ArrayList();

            using (StreamReader streamReader = new StreamReader(fileName))
            {
                string fileLine;

                while((fileLine = streamReader.ReadLine()) != null)
                {
                    Clients client = new Clients(fileLine);
                    clients.Add(client);
                }
            }

            return clients;

        }

        public Clients GetClient(string first_name, string last_name)
        {
            using (StreamReader streamReader = new StreamReader(fileName))
            {
                string fileLine;

                while ((fileLine = streamReader.ReadLine()) != null)
                {
                    Clients client = new Clients(fileLine);
                    if (client.First_name.Equals(first_name) && client.Last_name.Equals(last_name))
                        return client;
                }
            }

            return null;

        }

        private int GetIdClient()
        {
            int IdClient = FIRST_CLIENT_ID;

            using (StreamReader streamReader = new StreamReader(fileName))
            {
                string fileLine;

                while ((fileLine = streamReader.ReadLine()) != null)
                {
                    Clients client = new Clients(fileLine);
                    IdClient = client.IdClient + INCREMENT_CLIENT;
                }
            }

            return IdClient;

        }

        public Clients[] GetClients(out int nrClients)
        {
            Clients[] clients = new Clients[MaxClients];

            using (StreamReader streamReader = new StreamReader(fileName))
            {
                string fileLine;
                nrClients = 0;

                while ((fileLine = streamReader.ReadLine()) != null)
                {
                    clients[nrClients++] = new Clients(fileLine);
                }
            }

            Array.Resize(ref clients, nrClients);

            return clients;
        }

    }
}