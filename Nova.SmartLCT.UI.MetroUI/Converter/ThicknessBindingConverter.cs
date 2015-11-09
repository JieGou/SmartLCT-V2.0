using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace Nova.SmartLCT.UI.MetroUI.Converter
{
    public class ThicknessBindingConverter : IValueConverter
    {
        public IgnoreThicknessSideType IgnoreThicknessSide { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is Thickness)
            {
                if (parameter is IgnoreThicknessSideType)
                {
                    this.IgnoreThicknessSide = (IgnoreThicknessSideType)parameter;
                }
                var orgThickness = (Thickness)value;
                switch (this.IgnoreThicknessSide)
                {
                    case IgnoreThicknessSideType.Left:
                        return new Thickness(0, orgThickness.Top, orgThickness.Right, orgThickness.Bottom);
                    case IgnoreThicknessSideType.Top:
                        return new Thickness(orgThickness.Left, 0, orgThickness.Right, orgThickness.Bottom);
                    case IgnoreThicknessSideType.Right:
                        return new Thickness(orgThickness.Left, orgThickness.Top, 0, orgThickness.Bottom);
                    case IgnoreThicknessSideType.Bottom:
                        return new Thickness(orgThickness.Left, orgThickness.Top, orgThickness.Right, 0);
                    default:
                        return orgThickness;
                }
            }
            return default(Thickness);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return DependencyProperty.UnsetValue;
        }
    }

    public enum IgnoreThicknessSideType
    {
        /// <summary>
        /// Use all sides.
        /// </summary>
        None,
        /// <summary>
        /// Ignore the left side.
        /// </summary>
        Left,
        /// <summary>
        /// Ignore the top side.
        /// </summary>
        Top,
        /// <summary>
        /// Ignore the right side.
        /// </summary>
        Right,
        /// <summary>
        /// Ignore the bottom side.
        /// </summary>
        Bottom
    }
}
