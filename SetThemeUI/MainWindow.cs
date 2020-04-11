using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
