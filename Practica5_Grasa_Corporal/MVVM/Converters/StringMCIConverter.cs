using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica5_Grasa_Corporal.MVVM.Converters
{
    public class StringMCIConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
           
            if ((int)value <= 16)
            {
                return "IMC: Delgadez Severa";
            }else if((int)value > 16 && (int)value < 17)
            {
                return "IMC: Delgadez Moderada";
            }
            else if ((int)value >= 17 && (int)value < 18.5)
            {
                return "IMC: Delgadez ligera";
            }
            else if ((int)value > 18.5 && (int)value < 25)
            {
                return "IMC: Normal";
            }
            else if ((int)value >= 25 && (int)value < 30)
            {
                return "IMC: Sobrepeso";
            }
            else if ((int)value >= 30 && (int)value <35)
            {
                return "Obesidad Clase I";
            }
            else if ((int)value >= 35 && (int)value < 40)
            {
                return "Obesidad Clase II";
            }
            else
            {
                return "IMC: Obesidad Clase III";
            }  
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
