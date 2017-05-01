using Microsoft.WindowsAzure.MobileServices;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cats.Services
{
    public class AzureService<T>
    {
        public AzureService()
        {
            string MyAppServiceURL = "http://mycatsapplication.azurewebsites.net";
            Client = new MobileServiceClient(MyAppServiceURL);
            Table = Client.GetTable<T>();
        }

        public Task<IEnumerable<T>> GetTable()
        {
            return Table.ToEnumerableAsync();
        }

        private IMobileServiceClient Client;
        private IMobileServiceTable<T> Table;
    }
}