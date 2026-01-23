
using System;
using System.Runtime.InteropServices;

namespace LeanCLRSdk
{
    public class AudioContext
    {
        private readonly IntPtr _audioHandle;

        public AudioContext(string src)
        {
            _audioHandle = CreateAudioInternal();
            if (_audioHandle == IntPtr.Zero)
            {
                throw new Exception("Failed to create audio context");
            }
            if (!string.IsNullOrEmpty(src))
            {
                SetSrc(_audioHandle, src);
            }
        }

        public string Src
        {
            get => GetSrc(_audioHandle);
            set
            {
                SetSrc(_audioHandle, value);
            }
        }

        public bool Loop
        {
            get => GetLoop(_audioHandle);
            set => SetLoop(_audioHandle, value);
        }

        public bool AutoPlay
        {
            get => GetAutoPlay(_audioHandle);
            set => SetAutoPlay(_audioHandle, value);
        }

        public float CurrentTime
        {
            get => GetCurrentTime(_audioHandle);
            set => SetCurrentTime(_audioHandle, value);
        }

        public void Play()
        {
            PlayInternal(_audioHandle);
        }

        [DllImport("wx", EntryPoint = "wx.createInnerAudioContext")]
        private static extern IntPtr CreateAudioInternal();

        [DllImport("wx", EntryPoint = "audio.set_src")]
        private static extern void SetSrc(IntPtr audioHandle, string src);

        [DllImport("wx", EntryPoint = "audio.get_src")]
        private static extern string GetSrc(IntPtr audioHandle);


        [DllImport("wx", EntryPoint = "audio.set_loop")]
        private static extern void SetLoop(IntPtr audioHandle, bool loop);

        [DllImport("wx", EntryPoint = "audio.get_loop")]
        private static extern bool GetLoop(IntPtr audioHandle);

        [DllImport("wx", EntryPoint = "audio.set_autoplay")]
        private static extern void SetAutoPlay(IntPtr audioHandle, bool autoplay);
        [DllImport("wx", EntryPoint = "audio.get_autoplay")]
        private static extern bool GetAutoPlay(IntPtr audioHandle);


        [DllImport("wx", EntryPoint = "audio.set_currentTime")]
        private static extern void SetCurrentTime(IntPtr audioHandle, float currentTime);
        [DllImport("wx", EntryPoint = "audio.get_currentTime")]
        private static extern float GetCurrentTime(IntPtr audioHandle);



        [DllImport("wx", EntryPoint = "audio.play")]
        private static extern void PlayInternal(IntPtr audioHandle);
    }
}