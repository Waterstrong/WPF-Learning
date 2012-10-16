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

namespace NoDataBinding
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        Person[] persons = null;
        int curIndex = 0;
        public MainWindow()
        {
            InitializeComponent();
            persons = new Person[3];
            persons[0] = new Person("tes1", 22);
            persons[1] = new Person("test2", 23);
            persons[2] = new Person("test3", 25);
            this.txt_name.Text = persons[curIndex].Name;
            this.txt_age.Text = persons[curIndex].Age.ToString();
            btn_alter.IsEnabled = false;
        }

        private void btn_next_Click(object sender, RoutedEventArgs e)
        {
            ++curIndex;
            if (curIndex >= 3)
            {
                curIndex = 0;
            }
            this.txt_name.Text = persons[curIndex].Name;
            this.txt_age.Text = persons[curIndex].Age.ToString();
            btn_alter.IsEnabled = false;
        }

        private void btn_alter_Click(object sender, RoutedEventArgs e)
        {
            persons[curIndex].Name = txt_name.Text;
            int age = 0;
            if (int.TryParse(txt_age.Text, out age))
            {
                persons[curIndex].Age = age;
                MessageBox.Show("修改成功！");
            }
            else
            {
                MessageBox.Show("年龄输入有误，修改失败！");
            }
            btn_alter.IsEnabled = false;
        }

        private void txt_name_TextChanged(object sender, TextChangedEventArgs e)
        {
            btn_alter.IsEnabled = true;
        }

        private void txt_age_TextChanged(object sender, TextChangedEventArgs e)
        {
            btn_alter.IsEnabled = true;
        }
    }
}
