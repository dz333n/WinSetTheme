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
    public partial class ThemePickControl : UserControl
    {
        public Theme SelectedTheme
        {
            get
            {
                var item = comboBox1.SelectedItem;
                if (item != null && item is Theme)
                    return (Theme)item;
                else
                    return null;
            }
        }

        public ThemePickControl()
        {
            InitializeComponent();

            foreach (var theme in ThemesRepository.Themes)
                comboBox1.Items.Add(theme);

            comboBox1.SelectedItem = comboBox1.Items[0];
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var theme = SelectedTheme;

            if (theme != null)
                labelDescription.Text = theme.Description;
            else
                labelDescription.Text = "Select a theme";
        }
    }
}
