using System.Runtime.InteropServices;

namespace WxSdk
{
    public class PerformanceManager : WxObject
    {
        public PerformanceManager(ObjectHandle handle) : base(handle)
        {
        }

        public double Now => GetNowInternal(_handle);

        [DllImport("wx", EntryPoint = "wxsdk_performance_now")]
        private static extern double GetNowInternal(ObjectHandle handle);
    }

    public static class Performance
    {
        public static void TriggerGC()
        {
            TriggerGCInternal();
        }

        public static void ReportPerformance(int id, double value, string[] demensions)
        {
            ReportPerformanceInternal(id, value, demensions);
        }

        private static PerformanceManager s_performanceManager;

        public static PerformanceManager GetPerformance()
        {
            if (s_performanceManager == null)
            {
                var handle = GetPerformanceInternal();
                s_performanceManager = new PerformanceManager(handle);
            }
            return s_performanceManager;
        }

        [DllImport("wx", EntryPoint = "wxsdk_trigger_gc")]
        private static extern void TriggerGCInternal();

        [DllImport("wx", EntryPoint = "wxsdk_report_performance")]
        private static extern void ReportPerformanceInternal(int id, double value, string[] demensions);

        [DllImport("wx", EntryPoint = "wxsdk_get_performance")]
        private static extern ObjectHandle GetPerformanceInternal();
    }
}