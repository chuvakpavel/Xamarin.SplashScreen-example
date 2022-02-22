using System;
using System.Globalization;
using System.Reflection;
using Xamarin.Forms;

namespace Xamarin.SplashScreen_example
{
    public class EmbeddedImageToImageSourceConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string fileName)
            {
                try
                {
                    var imageSource = ImageSource.FromResource(fileName, typeof(EmbeddedImageToImageSourceConverter).GetTypeInfo().Assembly);
                    return imageSource;
                }
                catch (Exception)
                {
                    return value;
                }
            }
            else
                return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {

            throw new NotImplementedException();
        }
    }
}
