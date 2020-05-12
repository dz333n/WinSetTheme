using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace SetThemeUI
{
    public class ProcessModel
    {
        public Process Process { get; set; }

        public string Name => Process.ProcessName + ".exe" ; // this is actually incorrect

        public override string ToString() => Name;

        public ProcessModel(Process process) => Process = process;
    }
}
