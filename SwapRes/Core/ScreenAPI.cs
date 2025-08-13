using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SwapRes.Core
{
    public static class ScreenAPI
    {
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        private struct DEVMODE
        {
            public const int DM_PELSWIDTH = 0x80000;
            public const int DM_PELSHEIGHT = 0x100000;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string dmDeviceName;

            public short dmSpecVersion;
            public short dmDriverVersion;
            public short dmSize;
            public short dmDriverExtra;
            public int dmFields;
            public int dmPositionX;
            public int dmPositionY;
            public int dmDisplayOrientation;
            public int dmDisplayFixedOutput;
            public short dmColor;
            public short dmDuplex;
            public short dmYResolution;
            public short dmTTOption;
            public short dmCollate;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string dmFormName;

            public short dmLogPixels;
            public int dmBitsPerPel;
            public int dmPelsWidth;
            public int dmPelsHeight;
            public int dmDisplayFlags;
            public int dmDisplayFrequency;
            public int dmICMMethod;
            public int dmICMIntent;
            public int dmMediaType;
            public int dmDitherType;
            public int dmReserved1;
            public int dmReserved2;
            public int dmPanningWidth;
            public int dmPanningHeight;
        }

        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        private static extern int ChangeDisplaySettingsEx(
            string lpszDeviceName,
            ref DEVMODE lpDevMode,
            IntPtr hwnd,
            uint dwFlags,
            IntPtr lParam
        );

        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        private static extern bool EnumDisplaySettings(
            string lpszDeviceName,
            int iModeNum,
            ref DEVMODE lpDevMode
        );

        private const int CDS_UPDATEREGISTRY = 0x01;

        public static string[] GetScreenNames()
        {
            return Screen.AllScreens.Select(s => s.DeviceName).ToArray();
        }

        public static bool IsValidRes(string widthStr, string heightStr, int screenIndex)
        {
            if (!int.TryParse(widthStr, out int width) || !int.TryParse(heightStr, out int height))
                return false;

            if (width < 640 || height < 480 || width > 7680 || height > 4320)
                return false;

            var screens = Screen.AllScreens;
            if (screenIndex < 0 || screenIndex >= screens.Length)
                return false;

            var deviceName = screens[screenIndex].DeviceName;
            DEVMODE devMode = new DEVMODE();
            devMode.dmSize = (short)Marshal.SizeOf(typeof(DEVMODE));
            int modeIndex = 0;

            while (EnumDisplaySettings(deviceName, modeIndex, ref devMode))
            {
                if (devMode.dmPelsWidth == width && devMode.dmPelsHeight == height)
                    return true;
                modeIndex++;
            }

            return false;
        }

        public static void ChangeScreenResolution(Screen targetScreen, int width, int height)
        {
            DEVMODE devMode = new DEVMODE
            {
                dmSize = (short)Marshal.SizeOf(typeof(DEVMODE)),
                dmPelsWidth = width,
                dmPelsHeight = height,
                dmFields = DEVMODE.DM_PELSWIDTH | DEVMODE.DM_PELSHEIGHT
            };

            int result = ChangeDisplaySettingsEx(
                targetScreen.DeviceName,
                ref devMode,
                IntPtr.Zero,
                CDS_UPDATEREGISTRY,
                IntPtr.Zero
            );

            Console.WriteLine(result.ToString());
        }
    }
}
