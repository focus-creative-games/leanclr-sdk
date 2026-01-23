namespace LeanCLRSdk
{
    public class Sprite
    {
        private readonly Image _image;
        private double _x;
        private double _y;
        private double _width;
        private double _height;

        private bool _visible;

        public Sprite(Image image, double x, double y, double width, double height)
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