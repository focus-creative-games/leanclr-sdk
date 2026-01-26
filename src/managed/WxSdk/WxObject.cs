using System;

namespace WxSdk
{
    public abstract class WxObject : IDisposable
    {
        protected ObjectHandle _handle;

        public WxObject(ObjectHandle handle)
        {
            _handle = handle;
        }

        public void Dispose()
        {
            Dispose(true);
        }

        ~WxObject()
        {
            Dispose(false);
        }

        protected void Dispose(bool disposing)
        {
            if (disposing)
            {
                // Free any managed objects here.
            }

            MarshalHelper.ReleaseObjectHandle(_handle);
            _handle = ObjectHandle.Null;
        }
    }
}