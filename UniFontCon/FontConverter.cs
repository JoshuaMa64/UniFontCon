using System;
using System.Globalization;
using System.Linq;
using System.Windows.Data;

namespace UniFontCon
{
    public class FontConverter : IValueConverter
    {
        private static readonly string[] Uppers =
        {
            "𝓐", "𝓑", "𝓒", "𝓓", "𝓔", "𝓕", "𝓖", "𝓗", "𝓘", "𝓙", "𝓚", "𝓛", "𝓜", "𝓝", "𝓞", "𝓟", "𝓠", "𝓡",
            "𝓢", "𝓣", "𝓤", "𝓥", "𝓦", "𝓧", "𝓨", "𝓩"
        };

        private static readonly string[] Lowers =
        {
            "𝓪", "𝓫", "𝓬", "𝓭", "𝓮", "𝓯", "𝓰", "𝓱", "𝓲", "𝓳", "𝓴", "𝓵", "𝓶", "𝓷", "𝓸", "𝓹", "𝓺", "𝓻",
            "𝓼", "𝓽", "𝓾", "𝓿", "𝔀", "𝔁", "𝔂", "𝔃"
        };
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) return null;
            var outstr = "";
            var str = value.ToString();
            foreach (var t in str)
            {
                if (t <= 'z' && t >= 'a')
                {
                    outstr += Lowers[t - 'a'];
                } else if (t <= 'Z' && t >= 'A')
                {
                    outstr += Uppers[t - 'A'];
                }
            }
            return outstr;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
