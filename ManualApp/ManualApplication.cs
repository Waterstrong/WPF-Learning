using System;
using System.Windows;

namespace ManualApp
{
    class ManualApplication
    {
        [STAThread]
        public static void Main()
        {
            Window win = new Window();
            win.Title = "手工创建";
            Application app = new Application();
            app.Run(win);
        }
    }
}
