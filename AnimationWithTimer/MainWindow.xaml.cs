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
using System.Windows.Threading;
using System.Windows.Media.Animation;

namespace AnimationWithTimer
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            startWidth = rectangle.Width;
        }

        private double maxWidth = 500;
        private double startWidth = 0;

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            // 计时器
            //DispatcherTimer tmr = new DispatcherTimer();
            //tmr.Interval = TimeSpan.FromSeconds(0.1);
            //tmr.Tick += TimerOnTick;
            //tmr.Start();
            //btn.IsEnabled = false;

            // 帧
            //CompositionTarget.Rendering += new EventHandler(CompositionTarget_Rendering);

            // 基于属性
            DoubleAnimation doubAni = new DoubleAnimation();
            doubAni.From = 30;
            doubAni.To = 500;
            doubAni.Duration = TimeSpan.Parse("0:0:2.7");
            doubAni.FillBehavior = FillBehavior.Stop;
            rectangle.BeginAnimation(Rectangle.WidthProperty, doubAni);
        }

        //void CompositionTarget_Rendering(object sender, EventArgs e)
        //{
        //    rectangle.Width += 10;
        //    if (rectangle.Width >= maxWidth)
        //    {
        //        rectangle.Width = startWidth;
        //        CompositionTarget.Rendering -= new EventHandler(CompositionTarget_Rendering);
        //        btn.IsEnabled = true;
        //    }
        //}
        //private void TimerOnTick(object sender, EventArgs args)
        //{
        //    rectangle.Width += 10;
        //    if (rectangle.Width >= maxWidth)
        //    {
        //        rectangle.Width = startWidth;
        //        (sender as DispatcherTimer).Stop();
        //        btn.IsEnabled = true;
        //    }
        //}
    }
}
