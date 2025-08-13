using System.Drawing;
using System.Drawing.Text;
using System.Linq;

public static class Outfit
{
    private static readonly PrivateFontCollection fonts = new PrivateFontCollection();

    static Outfit()
    {
        Add("Resources/Outfit-Black.ttf");
        Add("Resources/Outfit-Bold.ttf");
        Add("Resources/Outfit-ExtraBold.ttf");
        Add("Resources/Outfit-ExtraLight.ttf");
        Add("Resources/Outfit-Light.ttf");
        Add("Resources/Outfit-Medium.ttf");
        Add("Resources/Outfit-Regular.ttf");
        Add("Resources/Outfit-SemiBold.ttf");
        Add("Resources/Outfit-Thin.ttf");
    }

    private static void Add(string file)
    {
        fonts.AddFontFile(file);
    }

    private static Font Get(string style, float size)
    {
        var family = fonts.Families.First(f => f.Name == "Outfit");
        FontStyle fs;

        switch (style)
        {
            case "Black":
            case "Bold":
            case "ExtraBold":
            case "SemiBold":
                fs = FontStyle.Bold;
                break;

            default:
                fs = FontStyle.Regular;
                break;
        }

        return new Font(family, size, fs);
    }

    public static Font Black(float size) { return Get("Black", size); }
    public static Font Bold(float size) { return Get("Bold", size); }
    public static Font ExtraBold(float size) { return Get("ExtraBold", size); }
    public static Font ExtraLight(float size) { return Get("ExtraLight", size); }
    public static Font Light(float size) { return Get("Light", size); }
    public static Font Medium(float size) { return Get("Medium", size); }
    public static Font Regular(float size) { return Get("Regular", size); }
    public static Font SemiBold(float size) { return Get("SemiBold", size); }
    public static Font Thin(float size) { return Get("Thin", size); }
}