using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SetThemeUI
{
    public partial class LogControl : UserControl
    {
        public LogControl()
        {
            InitializeComponent();
        }

        public void Write(string text)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => Write(text)));
                return;
            }

            tbLog.AppendText(text);
        }

        public void WriteLine(string text) => Write(text + Environment.NewLine);
    }
}
