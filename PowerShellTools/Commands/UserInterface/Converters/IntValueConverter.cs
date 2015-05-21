﻿using System;
using System.Globalization;
using System.Windows.Data;

namespace PowerShellTools.Commands.UserInterface
{
    /// <summary>
    /// Converts from string to int and back
    /// </summary>
    public class IntValueConverter : IValueConverter
    {
        object IValueConverter.Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }

        object IValueConverter.ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var stringValue = value as string;

            if (String.IsNullOrWhiteSpace(stringValue))
            {
                return null;
            }

            if (stringValue != null)
            {
                int result;
                if (int.TryParse(stringValue.Trim(), out result))
                {
                    return result;
                }
            }

            return value;
        }
    }
}
