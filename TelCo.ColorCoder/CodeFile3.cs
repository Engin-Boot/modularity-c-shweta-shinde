using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;

namespace TelCo.ColorCoder
{
    partial class Program
    {
        
        public static string ToString()
        {
            StringBuilder ColorCodeMannual=new StringBuilder();
            int num = 1;
            for(int i=0; i< colorMapMajor.Length; i++)
            {
                string MajorColorCode = colorMapMajor[i].ToString();
                for(int j=0;j< colorMapMinor.Length; j++)
                {
                    string MinorColorCode = colorMapMinor[j].ToString();
                    ColorCodeMannual.Append(num.ToString() + " ");
                    ColorCodeMannual.Append(MajorColorCode+ " ");
                    ColorCodeMannual.AppendLine(MinorColorCode);
                    num++;
                }
            }
            string ReturnColorCodeMannualString = ColorCodeMannual.ToString();
            return ReturnColorCodeMannualString;
        }
    }
}