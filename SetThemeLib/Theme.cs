using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SetThemeLib
{
    public class Theme
    {
        public string Value { get; private set; }
        public string Description { get; private set; }
        public Action<IntPtr> ExtraAction { get; private set; }

        public Theme(string value, string description, Action<IntPtr> extraAction = null)
        {
            Value = value;
            Description = description;
            ExtraAction = extraAction;
        }

        public override string ToString()
            => $"ThemeAppName: {(Value != null ? Value : "null")}";
    }
}
