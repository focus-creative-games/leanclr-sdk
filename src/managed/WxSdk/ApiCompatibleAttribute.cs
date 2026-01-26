using System;

namespace WxSdk
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
    public class ApiCompatibleAttribute : System.Attribute
    {
        public string SinceVersion { get; }

        public ApiCompatibleAttribute(string sinceVersion)
        {
            SinceVersion = sinceVersion;
        }
    }
}