using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SetThemeLib
{
    public class HwndSearch
    {
        /// <summary>
        /// Searches HWNDs and returns a list of HWNDs
        /// </summary>
        public static List<IntPtr> Search(HwndSearchTypes type, object[] valuesRaw)
        {
            var list = new List<IntPtr>();

            if (type == HwndSearchTypes.All)
            {
                User32.EnumWindows((mainHwnd, b) =>
                {
                    list.Add(mainHwnd);

                    User32.EnumChildWindows(mainHwnd, (childHwnd, b2) =>
                    {
                        list.Add(childHwnd);
                        return true;
                    }, IntPtr.Zero);

                    return true;
                }, IntPtr.Zero);
            }
            else throw new NotImplementedException();

            return list;
        }
    }
}
