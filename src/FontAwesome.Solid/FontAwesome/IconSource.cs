using IconFontHelper;

namespace FontAwesome.Solid
{
    public class IconSource : IconImageSource<Icon>
    {
        public IconSource() : base(IconInfo.font) { }

        public IconSource(Icon icon) : base(icon, IconInfo.font) { }
    }
}
