using System;
using System.Resources;
using System.Reflection;
using System.Globalization;

namespace HelloWorldApp
{
    class Program
    {
        static void Main()
        {
            
            var rm = new ResourceManager("HelloWorldApp.Resources.Resources", Assembly.GetExecutingAssembly());
            
           
            string message = rm.GetString("HelloWorldMessage", CultureInfo.InvariantCulture) ?? "Default message: Hello, World!";

            
            
            Console.WriteLine(message);
        }
    }
}
