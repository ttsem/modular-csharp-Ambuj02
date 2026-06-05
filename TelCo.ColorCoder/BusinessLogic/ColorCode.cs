using System;
using System.Drawing;
using TelCo.ColorCoder.Models;

namespace TelCo.ColorCoder.BusinessLogic
{
    public class ColorCode
    {
        private static readonly Color[] colorMapMajor =
            { Color.White, Color.Red, Color.Black, Color.Yellow, Color.Violet };

        private static readonly Color[] colorMapMinor =
            { Color.Blue, Color.Orange, Color.Green, Color.Brown, Color.SlateGray };

        public Models.IColorPair GetColorFromPairNumber(int pairNumber)
        {
            int minorSize = colorMapMinor.Length;
            int majorSize = colorMapMajor.Length;
            if (pairNumber < 1 || pairNumber > minorSize * majorSize)
                throw new ArgumentOutOfRangeException($"Argument PairNumber:{pairNumber} is outside the allowed range");

            int zeroBased = pairNumber - 1;
            int majorIndex = zeroBased / minorSize;
            int minorIndex = zeroBased % minorSize;

            return new Models.ColorPair { MajorColor = colorMapMajor[majorIndex], MinorColor = colorMapMinor[minorIndex] };
        }

        public int GetPairNumberFromColor(Models.IColorPair pair)
        {
            int majorIndex = Array.IndexOf(colorMapMajor, pair.MajorColor);
            int minorIndex = Array.IndexOf(colorMapMinor, pair.MinorColor);
            if (majorIndex < 0 || minorIndex < 0)
                throw new ArgumentException($"Unknown Colors: {pair}");

            return (majorIndex * colorMapMinor.Length) + (minorIndex + 1);
        }
    }
}
