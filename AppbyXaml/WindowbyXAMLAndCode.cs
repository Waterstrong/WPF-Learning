using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Shapes;
using System.Windows.Media;
using System.Windows.Markup;
using System.Xml;
using System.IO;

namespace AppbyXaml
{
    public class WindowbyXAMLAndCode : Window
    {
        private Ellipse elip;
        public WindowbyXAMLAndCode()
        {
            InitializeComponent();
        }
        public void InitializeComponent()
        {
            this.Width = 600;
            this.Height = 200;
            this.Title = "WS";
            //string strXaml = "<StackPanel xmlns = 'http://schemas.microsoft.com/winfx/2006/xaml/presentation'>" +
            //                "<Button Content = 'MyButton'/>" +
            //                "<Ellipse Stroke = 'Red' Height = '60' StrokeThickness = '3' />" +
            //                "</StackPanel>";
            //StringReader strReader = new StringReader(strXaml);
            //XmlTextReader xmlreader = new XmlTextReader(strReader);
            //StackPanel obj = (StackPanel)XamlReader.Load(xmlreader);
            //Content = obj;
            Uri uri = new Uri("pack://application:,,,/stackpanel.xaml");
            Stream stream = Application.GetResourceStream(uri).Stream;
            StackPanel obj = (StackPanel)XamlReader.Load(stream);
            elip = obj.FindName("elip") as Ellipse;
            Button btn = obj.FindName("btn") as Button;
            btn.Click += new RoutedEventHandler(btn_Click);
            Content = obj;
        }
        private void btn_Click(object sender, RoutedEventArgs e)
        {
            if (elip != null)
            {
                elip.Stroke = new SolidColorBrush(Colors.Blue);
            }
        }
        [STAThread]
        public static void Main()
        {
            Application app = new Application();
            app.Run(new WindowbyXAMLAndCode());
        }
    }
}
