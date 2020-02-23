using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        bool CheckLogsAgeLimit(string logsPath, int limitDays);

    }
}
