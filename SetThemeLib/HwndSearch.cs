using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SetThemeLib
{
    public class HwndSearch
    {
        /// <summary>
        /// Searches HWNDs and invokes Action
        /// </summary>
        public static void ForEach(HwndSearchTypes type, object[] valuesRaw, Action<IntPtr> action)
        {
            if (type == HwndSearchTypes.Specific)
            {
                foreach (var value in valuesRaw.Cast<IntPtr>())
                    action(value);

                return;
            }

            User32.EnumWindows((mainHwnd, b) =>
            {
                if (type == HwndSearchTypes.All)
                    action(mainHwnd);
                else if (type == HwndSearchTypes.ForProcess)
                {
                    // check for process name
                    throw new NotImplementedException();
                }
                else throw new NotImplementedException("Unknown search type: " + type);

                User32.EnumChildWindows(mainHwnd, (childHwnd, b2) =>
                {
                    action(childHwnd);
                    return true;
                }, IntPtr.Zero);

                return true;
            }, IntPtr.Zero);
        }
    }
}
