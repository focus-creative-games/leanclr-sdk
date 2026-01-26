namespace WxSdk
{
    public enum AppAuthStatus
    {
        Authorized,
        Denied,
        NotDetermined
    }

    public class AppAuthorizeSetting
    {
        public AppAuthStatus AlbumAuthorized { get; set; }

        public AppAuthStatus BluetoothAuthorized { get; set; }

        public AppAuthStatus CameraAuthorized { get; set; }
        public AppAuthStatus LocationAuthorized { get; set; }

        public bool LocationReduceAccuracy { get; set; }

        public AppAuthStatus MicrophoneAuthorized { get; set; }

        public AppAuthStatus NotificationAuthorized { get; set; }

        public AppAuthStatus NotificationAlertAuthorized { get; set; }

        public AppAuthStatus NotificationBadgeAuthorized { get; set; }

        public AppAuthStatus NotificationSoundAuthorized { get; set; }

        public AppAuthStatus PhoneCalendarAuthorized { get; set; }
    }
}