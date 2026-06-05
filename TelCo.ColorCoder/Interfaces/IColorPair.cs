using System.Drawing;

namespace TelCo.ColorCoder.Models
{
    public interface IColorPair
    {
        Color MajorColor { get; }
        Color MinorColor { get; }
    }
}
