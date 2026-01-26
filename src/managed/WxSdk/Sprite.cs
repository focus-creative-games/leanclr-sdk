namespace WxSdk
{
    public class Sprite
    {
        private readonly Image _image;
        private double _x;
        private double _y;
        private double _width;
        private double _height;

        private bool _visible;

        public Sprite(Image image, double width, double height, double x, double y)
        {
            _image = image;
            _x = x;
            _y = y;
            _width = width;
            _height = height;
            _visible = true;
        }

        public bool Visiable
        {
            get => _visible;
            set => _visible = value;
        }

        public void Draw(CanvasContext ctx)
        {
            if (!_visible) return;
            ctx.DrawImage(_image, _x, _y, _width, _height);
        }
    }
}