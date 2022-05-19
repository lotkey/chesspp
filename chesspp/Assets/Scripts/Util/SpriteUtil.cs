using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SpriteUtil
{
    public static Sprite SpriteFromColor(Color color)
    {
        Texture2D texture = new Texture2D(1, 1);
        texture.SetPixel(0, 0, color);
        texture.Apply();
        Sprite sprite = Sprite.Create(texture, new Rect(0f, 0f, 1f, 1f), new Vector2(0.5f, 0.5f), 1f);
        return sprite;
    }

    public static Sprite SpriteFromRGB(int r, int g, int b)
    {
        return SpriteFromRGBA(r, g, b, 255);
    }

    public static Sprite SpriteFromRGBA(int r, int g, int b, int a)
    {
        Color color = new Color(r / 255f, g / 255f, b / 255f, a / 255f);
        return SpriteFromColor(color);
    }

    public static Sprite SpriteFromImage(string imagePath)
    {
        return Resources.Load<Sprite>(imagePath);
    }

    public static Sprite Black() { return SpriteFromRGB(0, 0, 0); }
    public static Sprite White() { return SpriteFromRGB(255, 255, 255); }
    public static Sprite Red() { return SpriteFromRGB(255, 0, 0); }
    public static Sprite Lime() { return SpriteFromRGB(0, 255, 0); }
    public static Sprite Blue() { return SpriteFromRGB(0, 0, 255); }
    public static Sprite Yellow() { return SpriteFromRGB(255, 255, 0); }
    public static Sprite Cyan() { return SpriteFromRGB(0, 255, 255); }
    public static Sprite Magenta() { return SpriteFromRGB(255, 0, 255); }
    public static Sprite Silver() { return SpriteFromRGB(192, 192, 192); }
    public static Sprite Gray() { return SpriteFromRGB(128, 128, 128); }
    public static Sprite Maroon() { return SpriteFromRGB(128, 0, 0); }
    public static Sprite Olive() { return SpriteFromRGB(255, 255, 0); }
    public static Sprite Green() { return SpriteFromRGB(0, 255, 0); }
    public static Sprite Purple() { return SpriteFromRGB(128, 0, 128); }
    public static Sprite Teal() { return SpriteFromRGB(0, 128, 128); }
    public static Sprite Navy() { return SpriteFromRGB(0, 0, 128); }
    public static Sprite DarkRed() { return SpriteFromRGB(139, 0, 0); }
    public static Sprite Brown() { return SpriteFromRGB(165, 42, 42); }
    public static Sprite Firebrick() { return SpriteFromRGB(178, 34, 34); }
    public static Sprite Crimson() { return SpriteFromRGB(220, 20, 60); }
    public static Sprite Tomato() { return SpriteFromRGB(255, 99, 71); }
    public static Sprite Coral() { return SpriteFromRGB(255, 127, 80); }
    public static Sprite LightCoral() { return SpriteFromRGB(240, 128, 128); }
    public static Sprite DarkSalmon() { return SpriteFromRGB(233, 150, 122); }
    public static Sprite Salmon() { return SpriteFromRGB(250, 128, 114); }
    public static Sprite LightSalmon() { return SpriteFromRGB(255, 160, 122); }
    public static Sprite OrangeRed() { return SpriteFromRGB(255, 69, 0); }
    public static Sprite DarkOrange() { return SpriteFromRGB(255, 140, 0); }
    public static Sprite Orange() { return SpriteFromRGB(255, 165, 0); }
    public static Sprite Gold() { return SpriteFromRGB(255, 215, 0); }
    public static Sprite DarkGoldenRod() { return SpriteFromRGB(184, 134, 11); }
    public static Sprite GoldenRod() { return SpriteFromRGB(218, 165, 32); }
    public static Sprite PaleGoldenRod() { return SpriteFromRGB(238, 232, 170); }
    public static Sprite DarkKhaki() { return SpriteFromRGB(189, 183, 107); }
    public static Sprite Khaki() { return SpriteFromRGB(240, 230, 140); }
    public static Sprite YellowGreen() { return SpriteFromRGB(154, 205, 50); }
    public static Sprite DarkOliveGreen() { return SpriteFromRGB(85, 107, 47); }
    public static Sprite OliveDrab() { return SpriteFromRGB(107, 142, 35); }
    public static Sprite LawnGreen() { return SpriteFromRGB(124, 252, 0); }
    public static Sprite Chartreuse() { return SpriteFromRGB(127, 255, 0); }
    public static Sprite GreenYellow() { return SpriteFromRGB(173, 255, 47); }
    public static Sprite DarkGreen() { return SpriteFromRGB(0, 100, 0); }
    public static Sprite ForestGreen() { return SpriteFromRGB(34, 139, 34); }
    public static Sprite LimeGreen() { return SpriteFromRGB(50, 205, 50); }
    public static Sprite LightGreen() { return SpriteFromRGB(144, 238, 144); }
    public static Sprite PaleGreen() { return SpriteFromRGB(152, 251, 152); }
    public static Sprite DarkSeaGreen() { return SpriteFromRGB(143, 188, 143); }
    public static Sprite MediumSpringGreen() { return SpriteFromRGB(0, 250, 154); }
    public static Sprite SpringGreen() { return SpriteFromRGB(0, 255, 127); }
    public static Sprite SeaGreen() { return SpriteFromRGB(46, 139, 87); }
    public static Sprite MediumAquaMarine() { return SpriteFromRGB(102, 205, 170); }
    public static Sprite MediumSeaGreen() { return SpriteFromRGB(60, 179, 113); }
    public static Sprite LightSeaGreen() { return SpriteFromRGB(32, 178, 170); }
    public static Sprite DarkSlateGray() { return SpriteFromRGB(47, 79, 79); }
    public static Sprite DarkCyan() { return SpriteFromRGB(0, 139, 139); }
    public static Sprite Aqua() { return SpriteFromRGB(0, 255, 255); }
    public static Sprite LightCyan() { return SpriteFromRGB(224, 255, 255); }
    public static Sprite DarkTurquoise() { return SpriteFromRGB(0, 206, 209); }
    public static Sprite Turquoise() { return SpriteFromRGB(64, 224, 208); }
    public static Sprite MediumTurquoise() { return SpriteFromRGB(72, 209, 204); }
    public static Sprite PaleTurquoise() { return SpriteFromRGB(175, 238, 238); }
    public static Sprite AquaMarine() { return SpriteFromRGB(127, 255, 212); }
    public static Sprite PowderBlue() { return SpriteFromRGB(176, 224, 230); }
    public static Sprite CadetBlue() { return SpriteFromRGB(95, 158, 160); }
    public static Sprite SteelBlue() { return SpriteFromRGB(70, 130, 180); }
    public static Sprite CornFlowerBlue() { return SpriteFromRGB(100, 149, 237); }
    public static Sprite DeepSkyBlue() { return SpriteFromRGB(0, 191, 255); }
    public static Sprite DodgerBlue() { return SpriteFromRGB(30, 144, 255); }
    public static Sprite LightBlue() { return SpriteFromRGB(173, 216, 230); }
    public static Sprite SkyBlue() { return SpriteFromRGB(135, 206, 235); }
    public static Sprite LightSkyBlue() { return SpriteFromRGB(135, 206, 250); }
    public static Sprite MidnightBlue() { return SpriteFromRGB(25, 25, 112); }
    public static Sprite DarkBlue() { return SpriteFromRGB(0, 0, 139); }
    public static Sprite MediumBlue() { return SpriteFromRGB(0, 0, 205); }
    public static Sprite RoyalBlue() { return SpriteFromRGB(65, 105, 225); }
    public static Sprite BlueViolet() { return SpriteFromRGB(138, 43, 226); }
    public static Sprite Indigo() { return SpriteFromRGB(75, 0, 130); }
    public static Sprite DarkSlateBlue() { return SpriteFromRGB(72, 61, 139); }
    public static Sprite SlateBlue() { return SpriteFromRGB(106, 90, 205); }
    public static Sprite MediumSlateBlue() { return SpriteFromRGB(123, 104, 238); }
    public static Sprite MediumPurple() { return SpriteFromRGB(147, 112, 219); }
    public static Sprite DarkMagenta() { return SpriteFromRGB(139, 0, 139); }
    public static Sprite DarkViolet() { return SpriteFromRGB(148, 0, 211); }
    public static Sprite DarkOrchid() { return SpriteFromRGB(153, 50, 204); }
    public static Sprite MediumOrchid() { return SpriteFromRGB(186, 85, 211); }
    public static Sprite Thistle() { return SpriteFromRGB(216, 191, 216); }
    public static Sprite Plum() { return SpriteFromRGB(221, 160, 221); }
    public static Sprite Violet() { return SpriteFromRGB(238, 130, 238); }
    public static Sprite Orchid() { return SpriteFromRGB(218, 112, 214); }
    public static Sprite MediumVioletRed() { return SpriteFromRGB(199, 21, 133); }
    public static Sprite PaleVioletRed() { return SpriteFromRGB(219, 112, 147); }
    public static Sprite DeepPink() { return SpriteFromRGB(255, 20, 147); }
    public static Sprite HotPink() { return SpriteFromRGB(255, 105, 180); }
    public static Sprite LightPink() { return SpriteFromRGB(255, 182, 193); }
    public static Sprite Pink() { return SpriteFromRGB(255, 192, 203); }
    public static Sprite AntiqueWhite() { return SpriteFromRGB(250, 235, 215); }
    public static Sprite Beige() { return SpriteFromRGB(245, 245, 220); }
    public static Sprite Bisque() { return SpriteFromRGB(255, 228, 196); }
    public static Sprite BlanchedAlmond() { return SpriteFromRGB(255, 235, 205); }
    public static Sprite Wheat() { return SpriteFromRGB(245, 222, 179); }
    public static Sprite CornSilk() { return SpriteFromRGB(255, 248, 220); }
    public static Sprite LemonChiffon() { return SpriteFromRGB(255, 250, 205); }
    public static Sprite LightGoldenRodYellow() { return SpriteFromRGB(250, 250, 210); }
    public static Sprite LightYellow() { return SpriteFromRGB(255, 255, 224); }
    public static Sprite SaddleBrown() { return SpriteFromRGB(139, 69, 19); }
    public static Sprite Sienna() { return SpriteFromRGB(160, 82, 45); }
    public static Sprite Chocolate() { return SpriteFromRGB(210, 105, 30); }
    public static Sprite Peru() { return SpriteFromRGB(205, 133, 63); }
    public static Sprite SandyBrown() { return SpriteFromRGB(244, 164, 96); }
    public static Sprite BurlyWood() { return SpriteFromRGB(222, 184, 135); }
    public static Sprite Tan() { return SpriteFromRGB(210, 180, 140); }
    public static Sprite RosyBrown() { return SpriteFromRGB(188, 143, 143); }
    public static Sprite Moccasin() { return SpriteFromRGB(255, 228, 181); }
    public static Sprite NavajoWhite() { return SpriteFromRGB(255, 222, 173); }
    public static Sprite PeachPuff() { return SpriteFromRGB(255, 218, 185); }
    public static Sprite MistyRose() { return SpriteFromRGB(255, 228, 225); }
    public static Sprite LavenderBlush() { return SpriteFromRGB(255, 240, 245); }
    public static Sprite Linen() { return SpriteFromRGB(250, 240, 230); }
    public static Sprite OldLace() { return SpriteFromRGB(253, 245, 230); }
    public static Sprite PapayaWhip() { return SpriteFromRGB(255, 239, 213); }
    public static Sprite SeaShell() { return SpriteFromRGB(255, 245, 238); }
    public static Sprite MintCream() { return SpriteFromRGB(245, 255, 250); }
    public static Sprite SlateGray() { return SpriteFromRGB(112, 128, 144); }
    public static Sprite LightSlateGray() { return SpriteFromRGB(119, 136, 153); }
    public static Sprite LightSteelBlue() { return SpriteFromRGB(176, 196, 222); }
    public static Sprite Lavender() { return SpriteFromRGB(230, 230, 250); }
    public static Sprite FloralWhite() { return SpriteFromRGB(255, 250, 240); }
    public static Sprite AliceBlue() { return SpriteFromRGB(240, 248, 255); }
    public static Sprite GhostWhite() { return SpriteFromRGB(248, 248, 255); }
    public static Sprite Honeydew() { return SpriteFromRGB(240, 255, 240); }
    public static Sprite Ivory() { return SpriteFromRGB(255, 255, 240); }
    public static Sprite Azure() { return SpriteFromRGB(240, 255, 255); }
    public static Sprite Snow() { return SpriteFromRGB(255, 250, 250); }
    public static Sprite DimGray() { return SpriteFromRGB(105, 105, 105); }
    public static Sprite DarkGray() { return SpriteFromRGB(169, 169, 169); }
    public static Sprite LightGray() { return SpriteFromRGB(211, 211, 211); }
    public static Sprite Gainsboro() { return SpriteFromRGB(220, 220, 220); }
    public static Sprite WhiteSmoke() { return SpriteFromRGB(245, 245, 245); }
}