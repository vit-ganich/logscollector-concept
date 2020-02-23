using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.MenuItems;
using TestStack.White.UIItems.WindowItems;

namespace LogCollectorTest.ControlHelper
{
    public class Control
    {
        public static void SelectCheckBox(SearchCriteria howToFind, Window window)
        {
            var checkBox = window.Get<CheckBox>(howToFind);
            if (!checkBox.Checked)
                checkBox.Click();
        }

        public static void ClickButton(SearchCriteria howToFind, Window window)
        {
            var button = window.Get<Button>(howToFind);
            button.Click();
        }

        public static TextBox GetTextBox(SearchCriteria howToFind, Window window)
        {
            return window.Get<TextBox>(howToFind);
        }

        public static void SelectDropDown(SearchCriteria howToFind, string optionToSelect, Window window)
        {
            var dropDown = window.Get<Menu>(howToFind);
            dropDown.SubMenu(optionToSelect).Click();
        }
    }
}
