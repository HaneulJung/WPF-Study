﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows;

namespace CieloReflector.LayoutSupport.UI.Units
{
    public class PathCanvas : Control
    {
        public static readonly DependencyProperty FillProperty = DependencyProperty.Register("Fill", typeof(Brush), typeof(PathCanvas), new PropertyMetadata());
        public static readonly DependencyProperty DataProperty = DependencyProperty.Register("Data", typeof(Geometry), typeof(PathCanvas), new PropertyMetadata());

        static PathCanvas()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(PathCanvas), new FrameworkPropertyMetadata(typeof(PathCanvas)));
        }

        public Brush Fill
        {
            get => (Brush)GetValue(FillProperty);
            set => SetValue(FillProperty, value);
        }

        public Geometry Data
        {
            get => (Geometry)GetValue(DataProperty);
            set => SetValue(DataProperty, value);
        }
    }
}
