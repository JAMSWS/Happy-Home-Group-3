using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appliances_Management_System
{
    internal class ThemeColor
    {
        public static List<String> ColorList = new List<string>() { "#FF0000",
                                                                        "#FFA500",
                                                                        "#FFFF00",
                                                                        "#008000",
                                                                        "#0000FF",
                                                                        "#800080",
                                                                        "#FFC0CB",
                                                                        "#000000",
                                                                        "#FFFFFF",
                                                                        "#FFD700",
                                                                        "#00FF00",
                                                                        "#00FFFF",
                                                                        "#FF69B4",
                                                                        "#ADD8E6",
                                                                        "#FF7F50",
                                                                        "#8B0000",
                                                                        "#8B008B",
                                                                        "#008080",
                                                                        "#2F4F4F",
                                                                        "#FF6347",
                                                                        "#40E0D0",
                                                                        "#E6E6FA",
                                                                        "#800000",
                                                                        "#7B68EE",
                                                                        "#BDB76B",
                                                                        "#FA8072",
                                                                        "#228B22",
                                                                        "#DAA520",
                                                                        "#808080",
                                                                        "#FAEBD7",
                                                                        "#F0E68C",
                                                                        "#7FFFD4",
                                                                        "#AFEEEE",
                                                                        "#FFE4C4",
                                                                        "#FFE4B5",
                                                                        "#F5DEB3",
                                                                        "#F5F5DC",
                                                                        "#D2691E",
                                                                        "#CD853F",
                                                                        "#B22222",
                                                                        "#FFA07A",
                                                                        "#BC8F8F",
                                                                        "#9370DB",
                                                                        "#6B8E23",
                                                                        "#20B2AA",
                                                                        "#B0C4DE",
                                                                        "#4682B4",
                                                                        "#3CB371",
                                                                        "#00CED1",
                                                                        "#6495ED",

        };


            public static Color ChangeColorBrightness(Color color, double correctionFactor)
            {
                double red = color.R;
                double green = color.G;
                double blue = color.B;
                //lf correction factor is less than 0, darken color.
                if (correctionFactor < 0)
                {
                    correctionFactor = 1 + correctionFactor;
                    red *= correctionFactor;
                    green *= correctionFactor;
                    blue *= correctionFactor;
                }
                //lf correction factor is greater than zero, lighten color.
                else
                {
                    red = (255 - red) * correctionFactor + red;
                    green = (255 - green) * correctionFactor + green;
                    blue = (255 - blue) * correctionFactor + blue;
                }
                return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
            }

        }
}
