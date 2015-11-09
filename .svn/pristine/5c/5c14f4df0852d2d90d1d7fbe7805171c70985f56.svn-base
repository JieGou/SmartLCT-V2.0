using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
//using System.Windows.Shapes;

namespace SmartLCT
{
   public class StateToPathConverter: IValueConverter
    {
       private readonly string strPath = "/Nova.SmartLCT.Skin;component/Image/BlueMode"; 
       private readonly string strDisablePath = "/Nova.SmartLCT.Skin;component/Image/BlueMode/Disable";
        private readonly string strNormalPath = "/Nova.SmartLCT.Skin;component/Image/BlueMode/Normal";
        private readonly string strSelectPath = "/Nova.SmartLCT.Skin;component/Image/BlueMode/Selecte";
        private readonly string strImageType = ".png";
      // /Nova.SmartLCT.Skin;component/Image/BlueMode/Disable/OriginalSize.png
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            string strImagePath = string.Empty;
            string strState = value.ToString();
            string strImageName = parameter.ToString();
            strImagePath = string.Format("{0}/{1}/{2}{3}", strPath,strState,strImageName, strImageType);
            //switch(strState)
            //{
            //    case "Disable":
            //        strImagePath = string.Format("{0}/{1}{2}", strDisablePath, strImageName, strImageType);
            //        break;
            //    case "Normal":
            //        strImagePath = string.Format("{0}/{1}{2}", strNormalPath, strImageName, strImageType);
            //        break;
            //    case "Select":
            //        strImagePath = string.Format("{0}/{1}{2}", strSelectPath, strImageName, strImageType);
            //        break;
            //    default:
            //        strImagePath = string.Format("{0}/{1}{2}", strNormalPath, strImageName, strImageType);
            //        break;
            //}
            return strImagePath;
           
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
