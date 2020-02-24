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
        public BaseControl control;

        /// <summary>
        /// Page Object for the main window
        /// </summary>
        public TPage TestPage { get; set; }

        [TestInitialize]
        public void BeforeTest()
        {
            application = Application.Launch(appPath);
            application.WaitWhileBusy();
            window = GetWindow();
            control = new BaseControl();

            TestPage = new TPage 
            { 
                Application = this.application, 
                Window = this.window,
                Control = this.control
            };
        }

        private Window GetWindow()
        {
            // TODO: add logic for apps with many windows
            string windowToTest = "ESET Log Collector";
            switch (windowToTest)
            {
                case "ESET Log Collector":
                    return Desktop.Instance.Windows().Find(obj => obj.Name.Equals("ESET Log Collector"));
                case "Any other project":
                    return Desktop.Instance.Windows().Find(obj => obj.Name.Contains("Any other window"));
                default:
                    throw new ArgumentException("Invalid window specified");
            }
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
 
