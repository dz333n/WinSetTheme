using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SetThemeUI
{
    public partial class SelectProcessWindow : Form
    {
        public ProcessModel[] SelectedProcesses
            => LbMain.SelectedItems.Cast<ProcessModel>().ToArray();

        public SelectProcessWindow()
        {
            InitializeComponent();
            TbFilter_TextChanged(null, null);
        }

        private void SelectProcessWindow_Load(object sender, EventArgs e)
        {

        }

        private void TbFilter_TextChanged(object sender, EventArgs e)
        {
            LbMain.Items.Clear();
            LbMain.Items.AddRange(Process.GetProcesses()
                .Where(x => x.ProcessName.ToLower().Contains(TbFilter.Text.ToLower()))
                .Select(x => new ProcessModel(x))
                .ToArray());
        }
    }
}
