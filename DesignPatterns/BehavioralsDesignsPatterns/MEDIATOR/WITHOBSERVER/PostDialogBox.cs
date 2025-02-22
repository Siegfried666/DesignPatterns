using System.Net.Mime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralsDesignsPatterns.MEDIATOR.WITHOBSERVER
{
    public class PostDialogBox
    {
        private ListBox _postListBox;
        private TextBox _titleTextBox;
        private Button _saveButton;

        public PostDialogBox()
        {
            _postListBox = new ListBox();
            _titleTextBox = new TextBox();
            _saveButton = new Button();

            _postListBox.AddEventHandler(PostSelected);
            _postListBox.AddEventHandler(TitleChanged);
        }

        public void SimulateUserInteraction()
        {
            _postListBox.SetSelection("Post 2");
            _titleTextBox.SetText("");
            System.Console.WriteLine("Title text box: " + _titleTextBox.GetText());
            System.Console.WriteLine("Button enabled: " + _saveButton.IsEnabled());
        }

        private void TitleChanged()
        {
            bool isTitleEmpty = _titleTextBox.GetText() == "";
            _saveButton.SetEnabled(!isTitleEmpty);
        }

        private void PostSelected()
        {
            _titleTextBox.SetText(_postListBox.GetSelection());
            _saveButton.SetEnabled(true);
        }
    }
}