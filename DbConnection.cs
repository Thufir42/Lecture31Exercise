using System;

namespace Lecture31Exercise
{
    public abstract class DbConnection
    {
        private string _connectionString;
        private TimeSpan _timeout;

        public DbConnection(string ConnectionString, TimeSpan TimeOut)
        {
            if(string.IsNullOrEmpty(ConnectionString) )
                throw new ArgumentException("Connection String cannot be null or empty!");

            _connectionString = ConnectionString;
            _timeout = TimeOut;

            if (_timeout.TotalSeconds > 30)
                throw new TimeoutException("Connection timed out");

        }

        public abstract void Open();
        public abstract void Close();

    }
}