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

        private bool _isWorking;
        public bool IsWorking
        {
            get => _isWorking;
            set
            {
                if (InvokeRequired)
                {
                    Invoke(new Action(() => IsWorking = value));
                    return;
                }

                _isWorking = value;

                Cursor = value ? Cursors.AppStarting : null;

                tableLayoutPanel1.Enabled = !value;
                btnPerform.Enabled = !value;
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void btnPerform_Click(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                var time = DateTime.Now;

                IsWorking = true;
                log.WriteLine("Beginning...");

                try
                {
                    HwndSearch.ForEach(hwndSearchControl1.SearchType, hwndSearchControl1.SearchValues.ToArray(), (hwnd) =>
                    {
                        try
                        {
                            // log.WriteLine("Setting theming for " + hwnd);
                            var result = WindowTheming.Set(hwnd, themePickControl1.SelectedTheme);

                            if (result != 0)
                            {
                                log.WriteLine($"Failed to process {hwnd:X2}: {result}"); // TODO: error string here
                            }
                        }
                        catch (Exception ex)
                        {
                            log.WriteLine("Failed to process HWND: " + hwnd);
                            log.WriteLine(ex.ToString());
                        }
                    }, (hwnd, ex) =>
                    {
                        log.WriteLine("Failed search for HWND: " + hwnd);
                        log.WriteLine(ex.ToString());
                    });
                }
                catch (Exception ex) 
                {

                    log.WriteLine("Global error happened.");
                    log.WriteLine(ex.ToString());
                }

                log.WriteLine("Completed in " + (DateTime.Now - time));
                IsWorking = false;
            }).Start();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsWorking)
            {
                var msg = MessageBox.Show("The program is working. Force exit?", "SetTheme", MessageBoxButtons.YesNo);

                if (msg == DialogResult.Yes)
                    Environment.Exit(0);
                else
                    e.Cancel = true;
            }
        }
    }
}
