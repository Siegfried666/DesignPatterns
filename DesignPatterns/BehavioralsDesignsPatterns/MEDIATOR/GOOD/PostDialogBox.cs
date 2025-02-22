using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralsDesignsPatterns.MEDIATOR.GOOD
{
    public class PostDialogBox : DialogBox
    {
        // fields for all UI components
        private ListBox _postsListBox;
        private TextBox _titleTextBox;
        private Button _saveButton;

        public PostDialogBox()
        {
            _postsListBox = new ListBox(this);
            _titleTextBox = new TextBox(this);
            _saveButton = new Button(this);
            _saveButton.SetEnabled(false);

        }
        public override void Changed(UIControl uIControl)
        {
            if (uIControl == _postsListBox)
            {
                HandlePostChanged();
            }
            else if (uIControl == _titleTextBox)
            {
                HandleTitleChanged();
            }
        }

        public void SimulateUserInteraction()
        {
            _postsListBox.SetSelection("Post 2");
            _titleTextBox.SetText("");
            System.Console.WriteLine("Title text box: " + _titleTextBox.GetText());
            System.Console.WriteLine("Button enabled: " + _saveButton.IsEnabled());
        }

        private void HandleTitleChanged()
        {
            bool isTitleEmpty = _titleTextBox.GetText() == "";
            _saveButton.SetEnabled(!isTitleEmpty);
        }

        private void HandlePostChanged()
        {
            _titleTextBox.SetText(_postsListBox.GetSelection());
            _saveButton.SetEnabled(true);
        }
    }
}