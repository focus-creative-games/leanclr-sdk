namespace WxSdk
{
    public class JSObject
    {

        public bool GetBool(string key)
        {
            return false;
        }

        public bool GetBoolOrDefault(string key, bool defaultValue = false)
        {
            return false;
        }

        public bool? GetBoolOptional(string key)
        {
            return false;
        }

        public int GetInt(string key)
        {
            return 0;
        }

        public int GetIntOrDefault(string key, int defaultValue = 0)
        {
            return 0;
        }

        public int? GetIntOptional(string key)
        {
            return 0;
        }

        public float GetFloat(string key)
        {
            return 0f;
        }

        public float GetFloatOrDefault(string key, float defaultValue = 0f)
        {
            return 0f;
        }

        public float? GetFloatOptional(string key)
        {
            return 0f;
        }

        public double GetDouble(string key)
        {
            return 0.0;
        }

        public double GetDoubleOrDefault(string key, double defaultValue = 0.0)
        {
            return 0.0;
        }

        public double? GetDoubleOptional(string key)
        {
            return 0.0;
        }

        public string GetString(string key)
        {
            return string.Empty;
        }

        public string GetStringOrDefault(string key, string defaultValue = "")
        {
            return string.Empty;
        }

        public string GetStringOptional(string key)
        {
            return string.Empty;
        }
    }

    public struct DelegateHandle
    {
        private readonly int Id;

        public DelegateHandle(int id)
        {
            Id = id;
        }

        public bool IsNull()
        {
            return Id == 0;
        }
    }

    public struct ObjectHandle
    {
        private readonly int Id;

        public ObjectHandle(int id)
        {
            Id = id;
        }

        public bool IsNull()
        {
            return Id == 0;
        }
    }
}