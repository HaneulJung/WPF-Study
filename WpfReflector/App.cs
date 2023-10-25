using CieloReflector.Forms.UI.Views;
using Jamesnet.Wpf.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfReflector
{
    public class App : JamesApplication
    {
        protected override Window CreateShell()
        {
            ReflectorWindow window = new ReflectorWindow();

            return window;
        }
    }
}
