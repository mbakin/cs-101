using System;

namespace Interface
{
  public class DatabaseLogger : ILogger
    {
        public void WriteLog()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Logging Success!");
            
        }
    }
}