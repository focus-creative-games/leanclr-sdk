using WxSdk;

namespace Game
{
    class Music
    {
        const string bgmSrc = "audio/bgm.mp3";
        private readonly AudioContext _bgm;
        private readonly AudioContext _shoot;
        private readonly AudioContext _boom;

        public static Music Ins = new Music();

        Music()
        {
            _bgm = new AudioContext("audio/bgm.mp3");
            _bgm.Loop = true;
            _bgm.AutoPlay = true;

            _shoot = new AudioContext("audio/bullet.mp3");
            _boom = new AudioContext("audio/boom.mp3");
        }

        public void Start()
        {
            _bgm.Play();
        }

        public void PlayShoot()
        {
            _shoot.CurrentTime = 0;
            _shoot.Play();
        }

        public void PlayBoom()
        {
            _boom.CurrentTime = 0;
            _boom.Play();
        }
    }
}
