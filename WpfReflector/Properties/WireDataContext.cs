using CieloReflector.Forms.Local;
using CieloReflector.Forms.UI.Views;
using Jamesnet.Wpf.Global.Location;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfReflector.Properties
{
    public class WireDataContext : ViewModelLocationScenario
    {
        // View, ViewModel 연결하는 부분
        protected override void Match(ViewModelLocatorCollection items)
        {
            items.Register<MainContent, MainContentViewModel>();
        }
    }
}
