using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace SetThemeLib
{
    public class WindowTheming
    {
        /// <summary>
        /// Sets theming for specified HWND
        /// </summary>
        public static int Set(IntPtr hwnd, Theme theme)
        {
            theme.ExtraAction?.Invoke(hwnd);
            var result = UxTheme.SetWindowTheme(hwnd, theme.Value, null);

            return result;
        }

        /// <summary>
        /// Applies dark theming for win32 application
        /// </summary>
        public static void AllowDarkMode(IntPtr hwnd)
        {
            if (!UxTheme.AllowDarkModeForWindow(hwnd, true))
                throw new Exception("Unable to apply dark mode to " + hwnd + ", win32 error: " + Marshal.GetLastWin32Error());
        }
    }
}
