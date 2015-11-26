using System;

namespace Lecture31Exercise
{
    class OracleConnection : DbConnection
    {
        private string _oracleConnectionString;

        public OracleConnection(string ConnectionString, TimeSpan TimeOut)
            :base (ConnectionString, TimeOut)
        {
            _oracleConnectionString = ConnectionString;
        }

        public override void Open()
        {
            Console.WriteLine("Oracle Connection Opened: " + _oracleConnectionString);
        }

        public override void Close()
        {
            Console.WriteLine("Oracle Connection Closed: " + _oracleConnectionString);
        }
    }
}