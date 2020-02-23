using LogCollectorTest.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;
using LogCollectorTest.ControlHelper;

namespace LogCollectorTest.PageObjects
{
    public class MainPage: ITestPage
    {
        public Application Application { get; set; }
        public Window Window { get; set; }
        public MainPage() { }

        #region Artifacts to collect

        #region Windows Processes
        public SearchCriteria RunningProcessesChBox = SearchCriteria.ByText(
                                                        "Running processes (open handles and loaded DDLs)");
        #endregion

        #region Windows Logs
        public SearchCriteria AppEventLogChBox = SearchCriteria.ByText("Application event log");
        public SearchCriteria SystemEventLogChBox = SearchCriteria.ByText("System event log");
        public SearchCriteria SetupAPIlogsChBox = SearchCriteria.ByText("SetupAPI logs");
        #endregion

        #region System Configuration
        public SearchCriteria SystemConfigChBox = SearchCriteria.ByText("System configuration");
        public SearchCriteria NetworkConfigChBox = SearchCriteria.ByText("Network configuration");
        public SearchCriteria WFPFiltersChBox = SearchCriteria.ByText("WFP filters");
        #endregion

        public SearchCriteria SelectDeselectAllChBox = SearchCriteria.ByText("Select / deselect all artifacts");
        #endregion

        public SearchCriteria LogsAgeLimitDrDown = SearchCriteria.ByText("Logs age limit [days]");
        public SearchCriteria LogsCollectModeDrDown = SearchCriteria.ByText("Logs collection mode");
        public SearchCriteria SaveArchiveTextBox = SearchCriteria.ByText("Save archive as");
        public SearchCriteria OperationLogTextBox = SearchCriteria.ByText("Operation log");

        public SearchCriteria CollectBtn = SearchCriteria.ByText("Collect");

        public SearchCriteria LogsCollectedMessage = SearchCriteria.ByText("Logs collected successfully");

        public void SelectAllCheckboxes()
        {
            Control.SelectCheckBox(SelectDeselectAllChBox, Window);
        }

        public void SelectWindowsProcesses()
        {
            Control.SelectCheckBox(RunningProcessesChBox, Window);
        }

        public void CollectLogs(out string message)
        {
            Control.ClickButton(CollectBtn, Window);
            
            message = Control.GetTextBox(LogsCollectedMessage, Window).Text;
        }

        public void SelectWindowsLogs()
        {
            var checkBoxes = new List<SearchCriteria>() { AppEventLogChBox, SystemEventLogChBox, SetupAPIlogsChBox };
            foreach (var item in checkBoxes)
                Control.SelectCheckBox(item, Window);
        }

        public void SelectSystemConfiguration()
        {
            var checkBoxes = new List<SearchCriteria>() { SystemConfigChBox, NetworkConfigChBox, WFPFiltersChBox };
            foreach (var item in checkBoxes)
                Control.SelectCheckBox(item, Window);
        }

        public void SelectInDropDown(SearchCriteria criteria, string textToSelect)
        {
            Control.SelectDropDown(criteria, textToSelect, Window);
        }
    }
}
