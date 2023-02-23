using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media.TextFormatting;

namespace Linkmarker.Converters {
    public class MarginBindConverter : IValueConverter {
        public Thickness DefaultValue { get; set; }

        public bool Left { get; set; }
        public bool Top { get; set; }
        public bool Right { get; set; }
        public bool Bottom { get; set; }

        public Thickness CloneDefault {
            get {
                Thickness def = this.DefaultValue; // not sure if this does an auto-clone...
                return new Thickness(def.Left, def.Top, def.Right, def.Bottom);
            }
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            if (value is IConvertible convertible) {
                Thickness thickness = this.CloneDefault;
                double property = convertible.ToDouble(null);
                if (this.Left) thickness.Left = property;
                if (this.Top) thickness.Top = property;
                if (this.Right) thickness.Right = property;
                if (this.Bottom) thickness.Bottom = property;
                return thickness;
            }

            return DependencyProperty.UnsetValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            throw new NotImplementedException();
        }
    }
}