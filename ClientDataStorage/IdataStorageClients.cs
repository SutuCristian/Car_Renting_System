using ClientLibrary;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientDataStorage
{
    public interface IDataStorageClients
    {
        void AddClient(Clients cli);

        List<Clients> GetClients();

        Clients GetClient(string first_name, string last_name);

        Clients GetClient(int idClient);

        bool UpdateClient(Clients cli);
    }
}
