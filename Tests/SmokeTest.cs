using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.White.Factory;
using TestStack.White;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;
using System.Diagnostics;
using System.Collections.Generic;
using LogCollectorTest.PageObjects;
using TestStack.White.UIItems;
using System.Windows.Automation;
using LogCollectorTest.Base;

namespace LogCollectorTest
{
    [TestClass]
    public class SmokeTest: BaseTest<MainPage>
        
    {
        [TestMethod]
        public void CollectLogsForAllSelected()
        {
            TestPage.SelectAllCheckboxes();
            TestPage.CollectLogs(out string message);
            Assert.AreEqual(expected: "Logs collected successfully", actual: message);

            bool logsAreEqual = new LogsProcessor().CompareLogs(actual: "Path to collected logs", expected: "Path to logs template");
            Assert.IsTrue(logsAreEqual);
        }

        [TestMethod]
        public void CollectWindowsProcessesOnly()
        {
            TestPage.SelectWindowsProcesses();
            TestPage.CollectLogs(out string message);
            Assert.AreEqual(expected: "Logs collected successfully", actual: message);

            bool logsAreEqual = new LogsProcessor().CompareLogs(actual: "Path to collected logs", expected: "Path to logs template");
            Assert.IsTrue(logsAreEqual);
        }

        public void CollectWindowsLogsOnly()
        {
            TestPage.SelectWindowsProcesses();
            TestPage.CollectLogs(out string message);
            Assert.AreEqual(expected: "Logs collected successfully", actual: message);

            bool logsAreEqual = new LogsProcessor().CompareLogs(actual: "Path to collected logs", expected: "Path to logs template");
            Assert.IsTrue(logsAreEqual);
        }

        public void CollectSystemConfigurationOnly()
        {
            TestPage.SelectSystemConfiguration();
            TestPage.CollectLogs(out string message);
            Assert.AreEqual(expected: "Logs collected successfully", actual: message);

            bool logsAreEqual = new LogsProcessor().CompareLogs(actual: "Path to collected logs", expected: "Path to logs template");
            Assert.IsTrue(logsAreEqual);
        }

        public void TestLogsAgeLimit5Days()
        {
            TestPage.SelectInDropDown(TestPage.LogsAgeLimitDrDown, "5");
            TestPage.CollectLogs(out string message);
            Assert.AreEqual(expected: "Logs collected successfully", actual: message);

            bool logsLimitNotExceeded = new LogsProcessor().CheckLogsAgeLimit(logsPath: "Path to collected logs", limitDays: 5);
            Assert.IsTrue(logsLimitNotExceeded);
        }
    }
}
