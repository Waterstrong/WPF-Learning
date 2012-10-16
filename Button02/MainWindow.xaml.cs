using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Button02
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SpaceButton_Click(object sender, RoutedEventArgs e)
        {
            btn_space.Space = 2;
        }

        static MainWindow()
        {
            FrameworkPropertyMetadata metadata = new FrameworkPropertyMetadata();
            metadata.Inherits = true;
            SpaceProperty = SpaceButton.SpaceProperty.AddOwner(typeof(MainWindow));
            SpaceProperty.OverrideMetadata(typeof(Window), metadata);
        }
        public static readonly DependencyProperty SpaceProperty;

        public int Space
        {
            set
            {
                SetValue(SpaceProperty, value);
            }
            get
            {
                return (int)GetValue(SpaceProperty);
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Space = 2;
        }
    }
}
