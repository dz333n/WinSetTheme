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
    public partial class EditWindow : Form
    {
        public EditWindow()
        {
            InitializeComponent();
        }

        public EditWindow(string title, string label, string text = "") : this()
        {
            this.label.Text = label;
            this.Text = title;
            this.textBox1.Text = text;
        }

        public string Result => textBox1.Text;

        private void EditWindow_Load(object sender, EventArgs e)
        {
            var pos = this.textBox1.TextLength;
            this.textBox1.Select(pos >= 1 ? pos - 1 : 0, 0);
            this.textBox1.ScrollToCaret();
            this.textBox1.Focus();
        }
    }
}
