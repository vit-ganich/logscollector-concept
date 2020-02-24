using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.MenuItems;
using TestStack.White.UIItems.WindowItems;

namespace LogCollectorTest
{
    /// <summary>
    /// Class for operations with controls
    /// </summary>
    public class BaseControl
    {
        public void SelectCheckBox(SearchCriteria howToFind, Window window)
        {
            var checkBox = window.Get<CheckBox>(howToFind);
            if (!checkBox.Checked)
                checkBox.Click();
        }

        public void ClickButton(SearchCriteria howToFind, Window window)
        {
            var button = window.Get<Button>(howToFind);
            button.Click();
        }

        public TextBox GetTextBox(SearchCriteria howToFind, Window window)
        {
            return window.Get<TextBox>(howToFind);
        }

        public void SelectDropDown(SearchCriteria howToFind, string optionToSelect, Window window)
        {
            var dropDown = window.Get<Menu>(howToFind);
            dropDown.SubMenu(optionToSelect).Click();
        }
    }
}
