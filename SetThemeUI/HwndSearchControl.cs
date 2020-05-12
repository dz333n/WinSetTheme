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
            using (var editWnd = new EditWindow(
                "Edit properties...",
                "You can specify few or more values. Split using ;",
                SearchValues.Count >= 1 ? 
                SearchValues.Select(x => x.ToString()).Aggregate((i, j) => i + ";" + j) : ""))
            {
                var dialogResult = editWnd.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    SearchValues.Clear();

                    if (SearchType == HwndSearchTypes.ForProcess)
                        SearchValues.AddRange(editWnd.Result.Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()));
                    else if (SearchType == HwndSearchTypes.Specific)
                        foreach (var hwndText in editWnd.Result.Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()))
                        {
                            try
                            {
                                var hwndLong = long.Parse(hwndText, System.Globalization.NumberStyles.Any);
                                SearchValues.Add(new IntPtr(hwndLong));
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString(), "Unable to convert your HWNDs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                }
            }
        }

        private void CheckChanged(object sender, EventArgs e)
        {
            btnEditProps.Enabled = SearchType != HwndSearchTypes.All;
            BtnSelectProcesses.Enabled = SearchType == HwndSearchTypes.ForProcess;
            BtnSelectWindows.Enabled = false; // SearchType == HwndSearchTypes.Specific; // TODO
        }

        private void BtnSelectProcesses_Click(object sender, EventArgs e)
        {
            using (var processesWnd = new SelectProcessWindow())
            {
                if (processesWnd.ShowDialog() == DialogResult.OK)
                {
                    SearchValues.Clear();
                    SearchValues.AddRange(processesWnd.SelectedProcesses.Select(x => x.Name));
                }
            }
        }

        private void BtnSelectWindows_Click(object sender, EventArgs e)
        {

        }
    }
}
