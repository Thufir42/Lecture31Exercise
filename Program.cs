using System;

namespace Lecture31Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var menu = new Menu();
            }
            catch (ArgumentException message)
            {
                Console.WriteLine("Invalid Argument Exception Error received: \n\t" + message.Message);
            }
            catch(TimeoutException message)
            {
                Console.WriteLine("Timeout Exception Error received: \n\t" + message.Message);
            }

        }
    }
}
