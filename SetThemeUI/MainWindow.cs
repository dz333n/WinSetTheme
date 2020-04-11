using SetThemeLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SetThemeUI
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            log.WriteLine(Environment.OSVersion.ToString());
        }

        private void SetWorking(bool value)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => SetWorking(value)));
                return;
            }

            Cursor = value ? Cursors.AppStarting : null;

            tableLayoutPanel1.Enabled = !value;
            btnPerform.Enabled = !value;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void btnPerform_Click(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                var time = DateTime.Now;

                SetWorking(true);
                log.WriteLine("Beginning...");

                try
                {
                    foreach (var hwnd in HwndSearch.Search(hwndSearchControl1.SearchType, hwndSearchControl1.SearchValues.ToArray()))
                    {
                        try
                        {
                            WindowTheming.Set(hwnd, themePickControl1.SelectedTheme);
                        }
                        catch (Exception ex)
                        {
                            log.WriteLine("Failed to process HWND: " + hwnd);
                            log.WriteLine(ex.ToString());
                        }
                    }
                }
                catch (Exception ex) 
                {

                    log.WriteLine("Global error happened.");
                    log.WriteLine(ex.ToString());
                }

                log.WriteLine("Completed in " + (DateTime.Now - time));
                SetWorking(false);
            }).Start();
        }
    }
}
