using System;

namespace Lecture31Exercise
{
    class DbCommand
    {
        private DbConnection _dbConnection;
        private string _dbCommand;

        public DbCommand(DbConnection dbConnection, string command)
        {
            if( dbConnection == null)
                throw new ArgumentNullException("Database connection information can not be null.");

            if (string.IsNullOrEmpty(command))
                throw new ArgumentException("Database command must not be blank");

            _dbConnection = dbConnection;
            _dbCommand = command;
        }

        public void ExecuteCommand()
        {
            _dbConnection.Open();
            Console.WriteLine(_dbCommand);
            _dbConnection.Close();

        }
    }
}