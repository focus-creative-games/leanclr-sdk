namespace Wx
{

    public struct TouchData
    {
        public int identifier;
        public float pageX;
        public float pageY;
        public float clientX;
        public float clientY;
        public float force;
    }


    public class TouchEvent
    {
        public TouchData[] touches;
        public TouchData[] changedTouches;
        public float timeStamp;
    }

    public class InputSystem
    {

        public static void RegisterTouchStartCallback(System.Action<TouchEvent> callback)
        {
            // No implementation
        }
    }
}