using WxSdk;

namespace Game
{

    class Background
    {
        const string src = "images/bg.jpg";
        //const int screenWidth = 512;
        //const int screenHeight = 512;
        const int speed = 2;

        private readonly Image _bg;

        private int _screenWidth = ScreenInfo.Width;
        private int _screenHeight = ScreenInfo.Height;
        private int _width;
        private int _height;
        private int _top;

        public static Background Ins = new Background();

        Background()
        {
            _bg = new Image(src);
            _width = 512;// _bg.Width;
            _height = 512;// _bg.Height;
            _top = 0;
        }

        public void Start()
        {

        }

        public void Update()
        {
            _top += speed;
            if (_top >= _screenHeight)
            {
                _top = 0;
            }
        }

        public void Render(CanvasContext c)
        {
            for (int curY = _top; curY > 0; curY -= _screenHeight)
            {
                c.DrawImage(_bg, 0, 0, _width, _height, 0, curY - _screenHeight, _screenWidth, _screenHeight);
            }
            for (int curY = _top; curY < _screenHeight; curY += _screenHeight)
            {
                c.DrawImage(_bg, 0, 0, _width, _height, 0, curY, _screenWidth, _screenHeight);
            }
        }
    }
}
