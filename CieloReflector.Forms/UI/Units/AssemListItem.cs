using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CieloReflector.Forms.UI.Units
{
    public class AssemListItem : TreeViewItem
    {
        static AssemListItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(AssemListItem), new FrameworkPropertyMetadata(typeof(AssemListItem)));
        }

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new AssemListItem();
        }
    }
}
