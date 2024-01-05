using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CustomScrollViewer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Point startPoint;
        private bool isDragging = false;

        public MainWindow()
        {
            InitializeComponent();

            scrollViewer.PreviewMouseDown += ScrollViewer_PreviewMouseDown;
            scrollViewer.PreviewMouseMove += ScrollViewer_PreviewMouseMove;
            scrollViewer.PreviewMouseUp += ScrollViewer_PreviewMouseUp;

        }

        private void ScrollViewer_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.OriginalSource is not Border)
            { // Capture the mouse to handle drag events
                scrollViewer.CaptureMouse();

                // Save the starting point of the drag
                startPoint = e.GetPosition(scrollViewer);
                isDragging = true;
            }        
        }

        private void ScrollViewer_PreviewMouseMove(object sender, MouseEventArgs e)
        {
            if (e.OriginalSource is not Border)
            {
                if (isDragging)
                {
                    // Calculate the difference in position
                    Point currentPoint = e.GetPosition(scrollViewer);
                    double deltaX = startPoint.X - currentPoint.X;
                    double deltaY = startPoint.Y - currentPoint.Y;

                    // Scroll horizontally and vertically
                    scrollViewer.ScrollToHorizontalOffset(scrollViewer.HorizontalOffset + deltaX);
                    scrollViewer.ScrollToVerticalOffset(scrollViewer.VerticalOffset + deltaY);

                    // Update the starting point for the next move
                    startPoint = currentPoint;
                }
            }           
        }

        private void ScrollViewer_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            if (e.OriginalSource is not Border)
            {// Release the captured mouse
                scrollViewer.ReleaseMouseCapture();

                isDragging = false;
            }              
        }

        private void up_Click(object sender, RoutedEventArgs e)
        {
            scrollViewer.ScrollToVerticalOffset(scrollViewer.VerticalOffset - 30);
        }

        private void down_Click(object sender, RoutedEventArgs e)
        {
            scrollViewer.ScrollToVerticalOffset(scrollViewer.VerticalOffset + 30);

        }
    }
}
