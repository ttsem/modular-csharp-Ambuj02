using System.Drawing;


namespace TelCo.ColorCoder.Models
{
    public class ColorPair : IColorPair
    {
        public Color MajorColor { get; set; }
        public Color MinorColor { get; set; }

        public override string ToString()
        {
            return string.Format("MajorColor:{0}, MinorColor:{1}", MajorColor.Name, MinorColor.Name);
        }
    }
}


