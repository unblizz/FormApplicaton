using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace Proje
{
    public class FrameService
    {
        public static void Navigate(object navigatePage)
        {
            Window activeWindow = Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);

            // Frame nesnesini bul (Örneğin, Frame nesnesinin adı "MainFrame" olsun)
            Frame frame = activeWindow.FindName("mainFrame") as Frame;
            // Frame'in Source özelliğini değiştir
            frame.Navigate(navigatePage);
        }
    }
}
