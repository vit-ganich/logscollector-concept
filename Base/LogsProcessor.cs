using System;
using LogCollectorTest.Base.Interfaces;

namespace LogCollectorTest.Base
{
    public class LogsProcessor : ILogsProcessor
    {
        public bool CheckLogsAgeLimit(string logsPath, int limitDays)
        {
            throw new NotImplementedException();
        }

        public bool CompareLogs(string actual, string expected)
        {
            throw new NotImplementedException();
        }

        public string ReadLog(string pathToLog)
        {
            throw new NotImplementedException();
        }
    }
}
