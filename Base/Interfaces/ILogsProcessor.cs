namespace LogCollectorTest.Base.Interfaces
{
    public interface ILogsProcessor
    {
        string ReadLog(string pathToLog);

        /// <summary>
        /// Compares actual logs with predefined template. If equals - returns true
        /// </summary>
        /// <param name="actual"></param>
        /// <param name="expected"></param>
        /// <returns></returns>
        bool CompareLogs(string actual, string expected);

        /// <summary>
        /// Checks whether the logs age doesn't exceed the limit
        /// </summary>
        /// <param name="logsPath"></param>
        /// <param name="limitDays"></param>
        /// <returns></returns>
        bool CheckLogsAgeLimit(string logsPath, int limitDays);

    }
}
