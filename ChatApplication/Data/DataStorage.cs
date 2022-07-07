namespace ChatApplication.Data
{
    internal class DataStorage
    {
        private DataStorage storage { get; set; }
        private DataStorage()
        {
            
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
