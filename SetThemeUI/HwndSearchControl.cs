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

        public List<object> SearchValues = new List<object>();

        public HwndSearchControl()
        {
            InitializeComponent();
            CheckChanged(null, null);
        }

        private void btnEditProps_Click(object sender, EventArgs e)
        {
            using (var editWnd = new EditWindow("Edit properties...", "You can specify few or more values. Split using ;"))
            {
                var dialogResult = editWnd.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    SearchValues.Clear();

                    if (SearchType == HwndSearchTypes.ForProcess)
                        foreach (var processName in editWnd.Result.Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries))
                            SearchValues.Add(processName);
                    else if (SearchType == HwndSearchTypes.Specific)
                        foreach (var hwnd in editWnd.Result.Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries))
                            SearchValues.Add(hwnd);
                }
            }
        }

        private void CheckChanged(object sender, EventArgs e)
        {
            btnEditProps.Enabled = SearchType != HwndSearchTypes.All;
        }
    }
}
