
using IconFontHelper;

namespace FontAwesome.Brand
{
    public class IconSource : IconImageSource<Icon>
    {
        public IconSource() : base(IconInfo.font) { }

        public IconSource(Icon icon) : base(icon, IconInfo.font) { }
    }
}