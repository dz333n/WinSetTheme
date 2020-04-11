using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SetThemeLib;

namespace SetThemeUI
{
    public partial class HwndSearchControl : UserControl
    {
        public HwndSearchTypes SearchType
        {
            get
            {
                if (rbAllHwnds.Checked)
                    return HwndSearchTypes.All;
                else if (rbProcess.Checked)
                    return HwndSearchTypes.ForProcess;
                else if (rbSpecificHWNDs.Checked)
                    return HwndSearchTypes.Specific;
                else
                    throw new NotImplementedException("Unknown HWNDs search type");
            }
        }

        public HwndSearchControl()
        {
            InitializeComponent();
        }

        private void btnEditProps_Click(object sender, EventArgs e)
        {

        }
    }
}
