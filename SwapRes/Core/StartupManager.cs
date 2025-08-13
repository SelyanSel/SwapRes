using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace SwapRes.Core
{
    public static class StartupManager
    {
        private const string AppName = "SwapRes"; 

        public static void EnableStartup()
        {
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(
                    @"Software\Microsoft\Windows\CurrentVersion\Run", true))
                {
                    if (key == null)
                        throw new Exception("Cannot access Run regkey.");

                    string exePath = Application.ExecutablePath;
                    key.SetValue(AppName, exePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR while accessing Run Regkey: " + ex.Message);
            }
        }

        public static void DisableStartup()
        {
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(
                    @"Software\Microsoft\Windows\CurrentVersion\Run", true))
                {
                    if (key == null)
                        throw new Exception("Cannot access Run regkey.");

                    key.DeleteValue(AppName, false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR while accessing Run Regkey: " + ex.Message);
            }
        }

        public static bool IsStartupEnabled()
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(
                @"Software\Microsoft\Windows\CurrentVersion\Run", false))
            {
                return key?.GetValue(AppName) != null;
            }
        }
    }
}
