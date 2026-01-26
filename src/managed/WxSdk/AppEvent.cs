using System;
using System.Runtime.InteropServices;

namespace WxSdk
{
    public class OnUnhandledRejectionResult
    {
        public JSObject Reason { get; set; }

        public JSObject Promise { get; set; }
    }

    public static class AppEvent
    {
        public static void OnUnhandledRejection(Action<OnUnhandledRejectionResult> listener)
        {
            OnUnhandledRejectionInternal(MarshalHelper.ToDelegateHandle(listener));
        }

        public static void OffUnhandledRejection(Action<OnUnhandledRejectionResult> listener)
        {
            OffUnhandledRejectionInternal(MarshalHelper.ToDelegateHandle(listener));
        }

        public static void OnError(Action<string> listener)
        {
            OnErrorInternal(MarshalHelper.ToDelegateHandle(listener));
        }

        public static void OffError(Action listener)
        {
            OffErrorInternal(MarshalHelper.ToDelegateHandle(listener));
        }

        public static void OnAudioInterruptionBegin(Action listener)
        {
            OnAudioInterruptionBeginInternal(MarshalHelper.ToDelegateHandle(listener));
        }

        public static void OffAudioInterruptionBegin(Action listener)
        {
            OffAudioInterruptionBeginInternal(MarshalHelper.ToDelegateHandle(listener));
        }

        public static void OnAudioInterruptionEnd(Action listener)
        {
            OnAudioInterruptionEndInternal(MarshalHelper.ToDelegateHandle(listener));
        }

        public static void OffAudioInterruptionEnd(Action listener)
        {
            OffAudioInterruptionEndInternal(MarshalHelper.ToDelegateHandle(listener));
        }

        [DllImport("wx", EntryPoint = "wxsdk_on_unhandled_rejection")]
        [ApiCompatible("2.10.0")]
        private static extern void OnUnhandledRejectionInternal(DelegateHandle listener);

        [DllImport("wx", EntryPoint = "wxsdk_off_unhandled_rejection")]
        private static extern void OffUnhandledRejectionInternal(DelegateHandle listener);

        [DllImport("wx", EntryPoint = "wxsdk_on_error")]
        private static extern void OnErrorInternal(DelegateHandle listener);

        [DllImport("wx", EntryPoint = "wxsdk_off_error")]
        private static extern void OffErrorInternal(DelegateHandle listener);

        [DllImport("wx", EntryPoint = "wxsdk_on_audio_interruption_begin")]
        private static extern void OnAudioInterruptionBeginInternal(DelegateHandle listener);

        [DllImport("wx", EntryPoint = "wxsdk_off_audio_interruption_begin")]
        private static extern void OffAudioInterruptionBeginInternal(DelegateHandle listener);

        [DllImport("wx", EntryPoint = "wxsdk_on_audio_interruption_end")]
        private static extern void OnAudioInterruptionEndInternal(DelegateHandle listener);

        [DllImport("wx", EntryPoint = "wxsdk_off_audio_interruption_end")]
        private static extern void OffAudioInterruptionEndInternal(DelegateHandle listener);

    }
}