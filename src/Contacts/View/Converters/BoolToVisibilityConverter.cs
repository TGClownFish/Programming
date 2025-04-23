using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace View.Converters
{
    /// <summary>
    /// Хранит методы для конверитрования значений типа bool в тип Visibility
    /// </summary>
    public class BoolToVisibilityConverter : IValueConverter
    {
        /// <summary>
        /// Конверитрирует значений типа bool в тип Visibility
        /// </summary>
        /// <param name="value">Принимаемое значение</param>
        /// <param name="targetType">Тип, к которому надо преобразовать значение value</param>
        /// <param name="parametr">Вспомогательный параметр</param>
        /// <param name="culture">Текущая культура приложения</param>
        /// <returns>Возвращает Visible, если value равно false, иначе - Hidden.</returns>
        public object Convert(object value, Type targetType, object parametr, CultureInfo culture)
        {
            if ((bool)value == false)
                return Visibility.Visible;
            else
                return Visibility.Hidden;
        }

        /// <summary>
        /// Существует для полной реализации интерфейса. Возвращает пустое значение.
        /// </summary>
        /// <param name="value">Значение, которое надо преобразовать</param>
        /// <param name="targetType">Тип, к которому надо преобразовать значение value</param>
        /// <param name="parametr">Вспомогательный параметр</param>
        /// <param name="culture">Текущая культура приложения</param>
        /// <returns>Пустое значение</returns>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return DependencyProperty.UnsetValue;
        }
    }
}
