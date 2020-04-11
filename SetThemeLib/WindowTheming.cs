using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SetThemeLib
{
    public class WindowTheming
    {
        /// <summary>
        /// Sets theming for specified HWND
        /// </summary>
        public static void Set(IntPtr hwnd, Theme theme)
        {
            UxTheme.SetWindowTheme(hwnd, theme.Value, null);
            theme.ExtraAction?.Invoke(hwnd);
        }

        /// <summary>
        /// Applies dark theming for win32 application
        /// </summary>
        public static void ApplyDark32(IntPtr hwnd)
        {

        }
    }
}
