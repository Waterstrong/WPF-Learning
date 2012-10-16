using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Button02
{
    public class SpaceButton : Button
    {
        string _txt;
        public string Text
        {
            set
            {
                _txt = value;
                Content = SpaceOutText(_txt);
            }
            get 
            {
                return _txt;
            }
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
        static SpaceButton()
        {
            FrameworkPropertyMetadata metadata = new FrameworkPropertyMetadata();
            metadata.DefaultValue = 0;
            metadata.Inherits = true;
            metadata.PropertyChangedCallback += OnSpacePropertyChanged;

            SpaceProperty = DependencyProperty.Register("Space", typeof(int), typeof(SpaceButton), metadata, ValidateSpaceValue);

        }
        string SpaceOutText(string str)
        {
            if (str == null)
            {
                return null;
            }
            StringBuilder build = new StringBuilder();
            foreach (char ch in str)
            {
                build.Append(ch + new string(' ', Space));
            }
            return build.ToString();
        }
        static bool ValidateSpaceValue(object obj)
        {
            int i = (int)obj;
            return i >= 0;
        }
        static void OnSpacePropertyChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            SpaceButton btn = obj as SpaceButton;
            string txt = btn.Content as string;
            if (txt == null)
            {
                return;
            }
            btn.Content = btn.SpaceOutText(txt);
        }
    }
}
