using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;

namespace TelCo.ColorCoder
{
    partial class Program
    {
        /// <summary>
        /// Given the two colors the function returns the pair number corresponding to them
        /// </summary>
        /// <param name="pair">Color pair with major and minor color</param>
        /// <returns></returns>
        private static int getMajorColorIndex(Color majorColor)
        {
            // Find the major color in the array and get the index
            int majorIndex = -1;
            for (int i = 0; i < colorMapMajor.Length; i++)
            {
                if (colorMapMajor[i] == majorColor)
                {
                    majorIndex = i;
                    break;
                }
            }
            return majorIndex;

        }
        private static int getMinorColorIndex(Color minorColor)
        {
            // Find the minor color in the array and get the index
            int minorIndex = -1;
            for (int i = 0; i < colorMapMinor.Length; i++)
            {
                if (colorMapMinor[i] == minorColor)
                {
                    minorIndex = i;
                    break;
                }
            }
            return minorIndex;
        }
        private static int GetPairNumberFromColor(ColorPair pair)
        {

            int majorIndex = getMajorColorIndex(pair.majorColor);
            int minorIndex = getMinorColorIndex(pair.minorColor);
            // If colors can not be found throw an exception
            if (majorIndex == -1 || minorIndex == -1)
            {
                throw new ArgumentException(
                    string.Format("Unknown Colors: {0}", pair.ToString()));
            }

            // Compute pair number and Return  
            // (Note: +1 in compute is because pair number is 1 based, not zero)
            return (majorIndex * colorMapMinor.Length) + (minorIndex + 1);
        }
    }
}