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

namespace NotepadWithoutCmd
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private KeyGesture gestCut = new KeyGesture(Key.X, ModifierKeys.Control);
        private KeyGesture gestCopy = new KeyGesture(Key.C, ModifierKeys.Control);
        private KeyGesture gestPaste = new KeyGesture(Key.V, ModifierKeys.Control);
        private KeyGesture gestDel = new KeyGesture(Key.Delete);
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_copy_Click(object sender, RoutedEventArgs e)
        {
            if (text.Text != null && text.Text.Length > 0)
            {
                Clipboard.SetText(text.Text);
            }
        }

        private void btn_paste_Click(object sender, RoutedEventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                text.Text = Clipboard.GetText();
            }
        }

        private void btn_cut_Click(object sender, RoutedEventArgs e)
        {
            btn_copy_Click(sender, e);
            btn_del_Click(sender, e);
        }

        private void btn_del_Click(object sender, RoutedEventArgs e)
        {
            text.Text = null;
        }

        protected override void OnPreviewKeyDown(KeyEventArgs e)
        {
            base.OnPreviewKeyDown(e);
            e.Handled = true;
            if (gestCopy.Matches(null, e))
            {
                btn_copy_Click(this, e);
            }
            else if (gestCut.Matches(null, e))
            {
                btn_cut_Click(this, e);
            }
            else if (gestDel.Matches(null, e))
            {
                btn_del_Click(this, e);
            }
            else if (gestPaste.Matches(null, e))
            {
                btn_paste_Click(this, e);
            }
            else
            {
                e.Handled = false;
            }
        }

        private void MenuItem_SubmenuOpened(object sender, RoutedEventArgs e)
        {
            cutitem.IsEnabled = copyitem.IsEnabled = deleteitem.IsEnabled =
                text.Text != null && text.Text.Length > 0;
            pasteitem.IsEnabled = Clipboard.ContainsText();
        }

        private void text_contextMenuOpening(object sender, ContextMenuEventArgs e)
        {

        }
    }
}
