using System;
namespace OOP3
{
    class DataBaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veri Tabanına Log'landı.");
        }
    }
}

