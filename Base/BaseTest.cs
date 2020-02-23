using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogCollectorTest.Base.Interfaces;
using LogCollectorTest.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.White;
using TestStack.White.UIItems.WindowItems;

namespace LogCollectorTest
{
    public class BaseTest<TPage>
        where TPage: ITestPage, new()
    {
        private string appPath = "..\\..\\Utils\\esetlogcollector.exe";
        public Application application;
        public Window window;

        /// <summary>
        /// Page Object for the main window
        /// </summary>
        public TPage TestPage { get; set; }

        [TestInitialize]
        public void BeforeTest()
        {
            application = Application.Launch(appPath);
            application.WaitWhileBusy();
            window = Desktop.Instance.Windows().Find(obj => obj.Name.Equals("ESET Log Collector"));
            TestPage = new TPage { Application = this.application, Window = this.window };
        }

        [TestCleanup]
        public void AfterTest()
        {
            if (window != null)
                window.Close();
            if (application != null)
                application.Kill();

            var cmd = Process.Start("CMD.exe", "TASKKILL /im esetlogcollector* /f");
            cmd.Kill();
        }
    }
}
 
