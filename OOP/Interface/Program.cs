using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            // Interfaces always start 'I' . It's a not rule. But it is important for intelligibility.

            FileLogger fileLogger = new FileLogger();
            fileLogger.WriteLog();
            
            DatabaseLogger databaseLogger = new DatabaseLogger();
            databaseLogger.WriteLog();

            SmsLogger smsLogger = new();
            smsLogger.WriteLog();

            LogManager logManager =new LogManager(new FileLogger());
            logManager.WriteLog();
            
        }
    }
}
