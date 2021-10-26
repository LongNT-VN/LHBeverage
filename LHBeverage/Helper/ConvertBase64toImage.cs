using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LHBeverage.Helper
{
    public class ConvertBase64toImage
    {
        public static Image ConverImageFromBase64(string imagebase64)
        {
            byte[] bytes = Convert.FromBase64String(imagebase64);

            Image image;
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                image = Image.FromStream(ms);
            }
            return image;
        }
    }
}
