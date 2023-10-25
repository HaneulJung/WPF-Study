using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfCustomApp.UI.Views;

namespace WpfCustomApp
{
    public class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            PracticeWindow window = new PracticeWindow();
            window.Show();
        }
    }
}
