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
using System.Windows.Media.Media3D;

namespace EarthDemo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CompositionTarget.Rendering += new EventHandler(CompositionTarget_Rendering);
        }
        private bool isStop = false;
        void CompositionTarget_Rendering(object sender, EventArgs e)
        {
            YRotate.Angle++;
            if (YRotate.Angle > 360)
            {
                YRotate.Angle = 0;
            }
        }

        private void main_window_KeyUp(object sender, KeyEventArgs e)
        {
            switch(e.Key)
            {
                case Key.Escape:
                    Application.Current.Shutdown();
                    break;
                case Key.P:
                    if (isStop == true)
                    {
                        isStop = false;
                        CompositionTarget.Rendering += new EventHandler(CompositionTarget_Rendering);
                    }
                    else
                    {
                        isStop = true;
                        CompositionTarget.Rendering -= new EventHandler(CompositionTarget_Rendering);
                    }
                    break;
                default:
                    break;
            }
        }

        private void main_window_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            double z = cam.Position.Z;
            if (z > 100)
            {
                z = 99;
                cam.Position = new Point3D(0, 0, z);
                return;
            }
            if (z < 4)
            {
                z = 5;
                cam.Position = new Point3D(0, 0, z);
                return;
            }
            z = z - (double)(e.Delta / 60);
            cam.Position = new Point3D(0, 0, z);
        }

        private void story_Completed(object sender, EventArgs e)
        {
            cam.Position = new Point3D(0, 0, 7);
        }
    }
}
