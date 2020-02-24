using TestStack.White;
using TestStack.White.UIItems.WindowItems;

namespace LogCollectorTest.Base.Interfaces
{
    public interface ITestPage
    {
        /// <summary>
        /// Instance of program under test
        /// </summary>
        Application Application { get; set; }
        /// <summary>
        /// Window of the program for controls search
        /// </summary>
        Window Window { get; set; }
        /// <summary>
        /// Instance of the Control class with method for operations with controls
        /// </summary>
        BaseControl Control { get; set; }
    }
}
