using ChatApplication.Models;
using ChatApplication.Repositories;


namespace ChatApplication.Data
{
    internal class DataStorage
    {
        public Repository<User> Users { get; }
        private DataStorage storage { get; set; }
        private DataStorage()
        {
            Users = new Repository<User>();
        }
        public DataStorage GetDataStorage()
        {
            if (storage == null)
            {
                storage = new DataStorage();

            }

            return storage;
        }
    }
}
