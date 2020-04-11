using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace SetThemeLib
{
    public class HwndSearch
    {
        /// <summary>
        /// Searches HWNDs and invokes Action
        /// </summary>
        public static void ForEach(HwndSearchTypes type, object[] valuesRaw, Action<IntPtr> action, Action<IntPtr, Exception> onFail = null)
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
                    uint proc;
                    User32.GetWindowThreadProcessId(mainHwnd, out proc);

                    IntPtr procHandle = Kernel32.OpenProcess(Kernel32.ProcessAccessFlags.QueryInformation | Kernel32.ProcessAccessFlags.VirtualMemoryRead, false, (int)proc);

                    if (procHandle == IntPtr.Zero)
                    {
                        var error = Marshal.GetLastWin32Error();

                        if (error == 5) // Referencing to original SetClassicTheme we should ignore this error
                            return true; 

                        onFail?.Invoke(mainHwnd, new Exception("Win32 error when OpenProcess: " + Marshal.GetLastWin32Error()));
                        return true;
                    }


                    StringBuilder moduleName = new StringBuilder(1024);
                    var moduleResult = PsApi.GetModuleFileNameEx(procHandle, IntPtr.Zero, moduleName, moduleName.Capacity);

                    if (moduleResult == 0)
                    {
                        onFail?.Invoke(mainHwnd, new Exception("Failed to get module file name: " + moduleResult));
                        Kernel32.CloseHandle(procHandle);
                        return true;
                    }

                    Kernel32.CloseHandle(procHandle);

                    var moduleFile = new FileInfo(moduleName.ToString());

                    if (!valuesRaw.Select(x => x.ToString().ToLower()).Contains(moduleFile.Name.ToLower()))
                    {
                        return true;
                    }

                    action(mainHwnd);
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
