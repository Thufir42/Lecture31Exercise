using System;

namespace Lecture31Exercise
{
    class SqlConnection : DbConnection
    {
        string _sqlConnectionString;

        public SqlConnection(string ConnectionString, TimeSpan TimeOut)
            :base (ConnectionString, TimeOut)
        {
            _sqlConnectionString = ConnectionString;
        }

        public override void Open()
        {
            Console.WriteLine("SQL Connection Opened: " + _sqlConnectionString);
        }

        public override void Close()
        {
            Console.WriteLine("SQL Connection Closed: " + _sqlConnectionString);
        }
    }
}