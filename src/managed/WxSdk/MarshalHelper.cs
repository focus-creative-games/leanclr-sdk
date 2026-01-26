namespace WxSdk
{
    public static class MarshalHelper
    {
        public static DelegateHandle ToDelegateHandle(System.MulticastDelegate del)
        {
            return new DelegateHandle(0);
        }

        public static ObjectHandle ToObjectHandle(object obj)
        {
            return new ObjectHandle(0);
        }

        public static object GetObjectFromHandle(ObjectHandle handle)
        {
            throw new System.NotImplementedException();
        }
    }
}