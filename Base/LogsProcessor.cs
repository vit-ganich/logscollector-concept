using LogCollectorTest.Base.Interfaces;

namespace LogCollectorTest.Base
{
    public class LogsProcessor : ILogsProcessor
    {
        public bool CheckLogsAgeLimit(string logsPath, int limitDays)
        {
            throw new System.NotImplementedException();
        }

        public bool CompareLogs(string actual, string expected)
        {
            //throw new System.NotImplementedException();
            return true;
        }

        public string ReadLog(string pathToLog)
        {
            throw new System.NotImplementedException();
        }
    }
}
