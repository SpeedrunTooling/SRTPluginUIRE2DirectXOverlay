using Microsoft.Win32;

namespace SRTPluginUIRE2DirectXOverlay
{
    public static class RegistryHelper
    {
        public static T GetValue<T>(RegistryKey baseKey, string valueKey, T defaultValue = default)
        {
            try
            {
                return (T)baseKey.GetValue(valueKey, defaultValue);
            }
            catch
            {
                return defaultValue;
            }
        }

        public static bool GetBoolValue(RegistryKey baseKey, string valueKey, bool defaultValue = default)
        {
            int dwordValue = GetValue(baseKey, valueKey, (defaultValue) ? 1 : 0);
            return (dwordValue == 0) ? false : true;
        }
    }
}
