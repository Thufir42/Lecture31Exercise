using System;

namespace Lecture31Exercise
{
    class Menu
    {
        private static DbConnection _dbConnection;
        private static DbCommand _dbCommand;
        private static TimeSpan _timeOut = new TimeSpan(0, 0, 25);

        public Menu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\n1 - Open a database connection");
                Console.WriteLine("2 - Close a database connection");
                Console.WriteLine("3 - Send a database command");
                Console.WriteLine("4 - Force a database Timeout");
                Console.Write("\nChoose a menu item number, or press any other key to quit: ");
                var input = Console.ReadKey();
                var test = input.KeyChar;
                Console.Clear();
                switch (test)
                {
                    case '1':
                        DbOpen();
                        break;
                    case '2':
                        DbClose();
                        break;
                    case '3':
                        DbCommand();
                        break;
                    case '4':
                        DbTimeOut();
                        break;
                    default:
                        return;
                }
                Console.WriteLine("\nPress Enter to continue...");
                Console.ReadLine();
            }
        }
        private void DbOpen()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\n1 - Open a SQL database");
                Console.WriteLine("2 - Open an NULL SQL database");
                Console.WriteLine("3 - Open an Oracle database");
                Console.WriteLine("4 - Open an NULL Oracle database");
                Console.Write("\nChoose a menu item number, or press any other key return to previous menu: ");
                var input = Console.ReadKey();
                var test = input.KeyChar;
                Console.Clear();
                switch (test)
                {
                    case '1':
                        _dbConnection = new SqlConnection("SQL Database", _timeOut);
                        break;
                    case '2':
                        _dbConnection = new SqlConnection(null, _timeOut);
                        break;
                    case '3':
                        _dbConnection = new OracleConnection("Oracle Database", _timeOut);
                        break;
                    case '4':
                        _dbConnection = new OracleConnection(null, _timeOut);
                        break;
                    default:
                        return;
                }
                _dbConnection.Open();
                Console.WriteLine("\nPress Enter to continue...");
                Console.ReadLine();
            }
        }
        private void DbTimeOut()
        {
            _timeOut = new TimeSpan(0, 0, 50);

            while (true)
            {
                Console.Clear();
                Console.WriteLine("1 - Open a SQL database - Force Timeout");
                Console.WriteLine("2 - Open an Oracle database - Force Timeout");
                Console.Write("\nChoose a menu item number, or press any other key return to previous menu: ");
                var input = Console.ReadKey();
                var test = input.KeyChar;
                Console.Clear();
                switch (test)
                {
                    case '1':
                        _dbConnection = new SqlConnection("SQL Database", _timeOut);
                        break;
                    case '2':
                        _dbConnection = new OracleConnection("Oracle Database", _timeOut);
                        break;
                    default:
                        return;
                }
                _dbConnection.Open();
                Console.WriteLine("\nPress Enter to continue...");
                Console.ReadLine();
            }
        }
        private void DbClose()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\n1 - Close a SQL database");
                Console.WriteLine("2 - Close an NULL SQL database");
                Console.WriteLine("3 - Close an Oracle database");
                Console.WriteLine("4 - Close an NULL Oracle database");
                Console.Write("\nChoose a menu item number, or press any other key return to previous menu: ");
                var input = Console.ReadKey();
                var test = input.KeyChar;
                Console.Clear();
                switch (test)
                {
                    case '1':
                        _dbConnection = new SqlConnection("SQL Database", _timeOut);
                        break;
                    case '2':
                        _dbConnection = new SqlConnection(null, _timeOut);
                        break;
                    case '3':
                        _dbConnection = new OracleConnection("Oracle Database", _timeOut);
                        break;
                    case '4':
                        _dbConnection = new OracleConnection(null, _timeOut);
                        break;
                    default:
                        return;
                }
                _dbConnection.Close();
                Console.WriteLine("\nPress Enter to continue...");
                Console.ReadLine();
            }
        }
        private void DbCommand()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\n1 - Send a SQL command");
                Console.WriteLine("2 - Send an NULL SQL command");
                Console.WriteLine("3 - Send an Oracle command");
                Console.WriteLine("4 - Send an NULL Oracle command");
                Console.Write("\nChoose a menu item number, or press any other key return to previous menu: ");
                var input = Console.ReadKey();
                var test = input.KeyChar;
                Console.Clear();
                Console.Write("Enter a command to send: ");
                var commandInput = Console.ReadLine();
                switch (test)
                {
                    case '1':
                        _dbConnection = new SqlConnection("SQL Database", _timeOut);
                        _dbCommand = new DbCommand(_dbConnection, commandInput);
                        break;
                    case '2':
                        _dbConnection = new SqlConnection("SQL Database", _timeOut);
                        _dbCommand = new DbCommand(_dbConnection, null);
                        break;
                    case '3':
                        _dbConnection = new OracleConnection("Oracle Database", _timeOut);
                        _dbCommand = new DbCommand(_dbConnection, commandInput);
                        break;
                    case '4':
                        _dbConnection = new OracleConnection("Oracle Database", _timeOut);
                        _dbCommand = new DbCommand(_dbConnection, null);
                        break;
                    default:
                        return;
                }
                _dbCommand.ExecuteCommand();
                Console.WriteLine("\nPress Enter to continue...");
                Console.ReadLine();
            }
        }
    }
}