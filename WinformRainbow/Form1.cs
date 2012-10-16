using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinformRainbow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Color[] colors = {Color.Red, Color.Orange, 
                             Color.Yellow, Color.Green, 
                             Color.Blue, Color.Indigo, Color.Purple};
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Rectangle rect = new Rectangle(0, 0, this.Size.Width / colors.Length, this.Size.Height);
            SolidBrush myBrush = new SolidBrush(Color.Red);
            Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            foreach (Color color in colors)
            {
                myBrush.Color = color;
                formGraphics.FillRectangle(myBrush, rect);
                rect.X += this.Size.Width / colors.Length;
            }
        }
    }
}
