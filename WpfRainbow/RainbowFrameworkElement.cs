using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace WpfRainbow
{
    public class RainbowFrameworkElement : FrameworkElement
    {
        private Color[] colors = {Colors.Red, Colors.Orange, 
                             Colors.Yellow, Colors.Green, 
                             Colors.Blue, Colors.Indigo, Colors.Purple};
        protected override void OnRender(System.Windows.Media.DrawingContext drawingContext)
        {
            base.OnRender(drawingContext);
            Rect rect = new Rect(0, 0, RenderSize.Width / colors.Length, RenderSize.Height);
            
            foreach (Color color in colors)
            {
                SolidColorBrush myBrush = new SolidColorBrush();
                myBrush.Color = color;
                drawingContext.DrawRectangle(myBrush, null, rect);
                rect.X += RenderSize.Width / colors.Length;
            }
        }
    }
}
