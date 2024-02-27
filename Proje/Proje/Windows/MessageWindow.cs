using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Windows
{
    public class MessageWindow
    {
        public static void Show(string _content, string _title, bool _secondaryEnabled)
        {
            Wpf.Ui.Controls.MessageBox messageBox = new Wpf.Ui.Controls.MessageBox();
            messageBox.Title = _title;
            messageBox.IsSecondaryButtonEnabled = _secondaryEnabled;
            messageBox.Content = _content;
            messageBox.CloseButtonText = "Tamam";
            messageBox.ShowDialogAsync();
        }

    }
}
