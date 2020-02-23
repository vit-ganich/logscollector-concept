using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White;
using TestStack.White.UIItems.WindowItems;

namespace LogCollectorTest.Base.Interfaces
{
    public interface ITestPage
    {
        Application Application { get; set; }
        Window Window { get; set; }
    }
}
