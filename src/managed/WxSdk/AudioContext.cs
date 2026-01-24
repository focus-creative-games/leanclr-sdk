
using System;
using System.Runtime.InteropServices;

namespace Wx
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
                SetSrcInternal(_audioHandle, src);
            }
        }

        public string Src
        {
            get => GetSrcInternal(_audioHandle);
            set
            {
                SetSrcInternal(_audioHandle, value);
            }
        }

        public bool Loop
        {
            get => GetLoopInternal(_audioHandle);
            set => SetLoopInternal(_audioHandle, value);
        }

        public bool AutoPlay
        {
            get => GetAutoPlayInternal(_audioHandle);
            set => SetAutoPlayInternal(_audioHandle, value);
        }

        public float CurrentTime
        {
            get => GetCurrentTimeInternal(_audioHandle);
            set => SetCurrentTimeInternal(_audioHandle, value);
        }

        public void Play()
        {
            PlayInternal(_audioHandle);
        }

        public void Pause()
        {
            PauseInternal(_audioHandle);
        }

        public void Stop()
        {
            StopInternal(_audioHandle);
        }

        [DllImport("wx", EntryPoint = "wx.createInnerAudioContext")]
        private static extern IntPtr CreateAudioInternal();

        [DllImport("wx", EntryPoint = "audio.set_src")]
        private static extern void SetSrcInternal(IntPtr audioHandle, string src);

        [DllImport("wx", EntryPoint = "audio.get_src")]
        private static extern string GetSrcInternal(IntPtr audioHandle);


        [DllImport("wx", EntryPoint = "audio.set_loop")]
        private static extern void SetLoopInternal(IntPtr audioHandle, bool loop);

        [DllImport("wx", EntryPoint = "audio.get_loop")]
        private static extern bool GetLoopInternal(IntPtr audioHandle);

        [DllImport("wx", EntryPoint = "audio.set_autoplay")]
        private static extern void SetAutoPlayInternal(IntPtr audioHandle, bool autoplay);
        [DllImport("wx", EntryPoint = "audio.get_autoplay")]
        private static extern bool GetAutoPlayInternal(IntPtr audioHandle);


        [DllImport("wx", EntryPoint = "audio.set_currentTime")]
        private static extern void SetCurrentTimeInternal(IntPtr audioHandle, float currentTime);
        [DllImport("wx", EntryPoint = "audio.get_currentTime")]
        private static extern float GetCurrentTimeInternal(IntPtr audioHandle);



        [DllImport("wx", EntryPoint = "audio.play")]
        private static extern void PlayInternal(IntPtr audioHandle);

        [DllImport("wx", EntryPoint = "audio.pause")]
        private static extern void PauseInternal(IntPtr audioHandle);
        [DllImport("wx", EntryPoint = "audio.stop")]
        private static extern void StopInternal(IntPtr audioHandle);
    }
}