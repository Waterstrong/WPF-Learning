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

namespace NotepadWithCmd
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
        private bool isDirty = false;
        private void TextBox_Changed(object sender, TextChangedEventArgs e)
        {
            isDirty = true;
        }

        private void CloseCommand(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Close Command:" + e.Source.ToString() + "\n" + sender.ToString());
            Application.Current.Shutdown();
            
        }
        private void Commanding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = isDirty;
        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            isDirty = false;
        }
    }
}
