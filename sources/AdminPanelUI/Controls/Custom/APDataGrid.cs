using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace AdminPanelUI.Controls
{
    internal class APDataGrid : System.Windows.Controls.DataGrid
    {
        static APDataGrid()
        {
            DefaultStyleKeyProperty.OverrideMetadata(
                typeof(APDataGrid),
                new FrameworkPropertyMetadata(typeof(APDataGrid)));
        }


        // Header Height

        public double APHeaderHeight
        {
            get => (double)GetValue(APHeaderHeightProperty);
            set => SetValue(APHeaderHeightProperty, value);
        }

        public static readonly DependencyProperty APHeaderHeightProperty =
            DependencyProperty.Register(
                nameof(APHeaderHeight),
                typeof(double),
                typeof(APDataGrid),
                new PropertyMetadata(48d));


        // Row Height

        public double APRowHeight
        {
            get => (double)GetValue(APRowHeightProperty);
            set => SetValue(APRowHeightProperty, value);
        }

        public static readonly DependencyProperty APRowHeightProperty =
            DependencyProperty.Register(
                nameof(APRowHeight),
                typeof(double),
                typeof(APDataGrid),
                new PropertyMetadata(58d));


        // Header Background

        public Brush APHeaderBackground
        {
            get => (Brush)GetValue(APHeaderBackgroundProperty);
            set => SetValue(APHeaderBackgroundProperty, value);
        }

        public static readonly DependencyProperty APHeaderBackgroundProperty =
            DependencyProperty.Register(
                nameof(APHeaderBackground),
                typeof(Brush),
                typeof(APDataGrid),
                new PropertyMetadata(
                    new SolidColorBrush(
                        Color.FromRgb(38, 52, 95))));


        // Row Backgroundd

        public Brush APRowBackground
        {
            get => (Brush)GetValue(APRowBackgroundProperty);
            set => SetValue(APRowBackgroundProperty, value);
        }

        public static readonly DependencyProperty APRowBackgroundProperty =
            DependencyProperty.Register(
                nameof(APRowBackground),
                typeof(Brush),
                typeof(APDataGrid),
                new PropertyMetadata(
                    new SolidColorBrush(
                        Color.FromRgb(32, 44, 85))));


        // Row Hover Background

        public Brush APRowHoverBackground
        {
            get => (Brush)GetValue(APRowHoverBackgroundProperty);
            set => SetValue(APRowHoverBackgroundProperty, value);
        }

        public static readonly DependencyProperty APRowHoverBackgroundProperty =
            DependencyProperty.Register(
                nameof(APRowHoverBackground),
                typeof(Brush),
                typeof(APDataGrid),
                new PropertyMetadata(
                    new SolidColorBrush(
                        Color.FromRgb(41, 55, 101))));


        // Selected Row Background

        public Brush APSelectedRowBackground
        {
            get => (Brush)GetValue(APSelectedRowBackgroundProperty);
            set => SetValue(APSelectedRowBackgroundProperty, value);
        }

        public static readonly DependencyProperty APSelectedRowBackgroundProperty =
            DependencyProperty.Register(
                nameof(APSelectedRowBackground),
                typeof(Brush),
                typeof(APDataGrid),
                new PropertyMetadata(
                    new SolidColorBrush(
                        Color.FromRgb(45, 59, 108))));
    }
}
