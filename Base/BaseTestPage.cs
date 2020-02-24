using LogCollectorTest.Base.Interfaces;
using TestStack.White;
using TestStack.White.UIItems.WindowItems;

namespace LogCollectorTest.Base
{
    public class BaseTestPage : ITestPage
    {
        public Application Application { get; set; }
        public Window Window { get; set; }
        public BaseControl Control { get; set; }
    }
}
