namespace SetThemeUI
{
    partial class HwndSearchControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rbAllHwnds = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbProcess = new System.Windows.Forms.RadioButton();
            this.rbSpecificHWNDs = new System.Windows.Forms.RadioButton();
            this.btnEditProps = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbAllHwnds
            // 
            this.rbAllHwnds.AutoSize = true;
            this.rbAllHwnds.Checked = true;
            this.rbAllHwnds.Location = new System.Drawing.Point(6, 19);
            this.rbAllHwnds.Name = "rbAllHwnds";
            this.rbAllHwnds.Size = new System.Drawing.Size(146, 17);
            this.rbAllHwnds.TabIndex = 0;
            this.rbAllHwnds.Text = "Find all available HWNDs";
            this.rbAllHwnds.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnEditProps);
            this.groupBox1.Controls.Add(this.rbSpecificHWNDs);
            this.groupBox1.Controls.Add(this.rbProcess);
            this.groupBox1.Controls.Add(this.rbAllHwnds);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 171);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "HWND Search";
            // 
            // rbProcess
            // 
            this.rbProcess.AutoSize = true;
            this.rbProcess.Location = new System.Drawing.Point(6, 42);
            this.rbProcess.Name = "rbProcess";
            this.rbProcess.Size = new System.Drawing.Size(188, 17);
            this.rbProcess.TabIndex = 1;
            this.rbProcess.Text = "Find HWNDs for specified process";
            this.rbProcess.UseVisualStyleBackColor = true;
            // 
            // rbSpecificHWNDs
            // 
            this.rbSpecificHWNDs.AutoSize = true;
            this.rbSpecificHWNDs.Location = new System.Drawing.Point(6, 65);
            this.rbSpecificHWNDs.Name = "rbSpecificHWNDs";
            this.rbSpecificHWNDs.Size = new System.Drawing.Size(106, 17);
            this.rbSpecificHWNDs.TabIndex = 2;
            this.rbSpecificHWNDs.Text = "Specific HWNDs";
            this.rbSpecificHWNDs.UseVisualStyleBackColor = true;
            // 
            // btnEditProps
            // 
            this.btnEditProps.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditProps.Location = new System.Drawing.Point(6, 142);
            this.btnEditProps.Name = "btnEditProps";
            this.btnEditProps.Size = new System.Drawing.Size(264, 23);
            this.btnEditProps.TabIndex = 3;
            this.btnEditProps.Text = "Edit properties...";
            this.btnEditProps.UseVisualStyleBackColor = true;
            this.btnEditProps.Click += new System.EventHandler(this.btnEditProps_Click);
            // 
            // HwndSearchControl
            // 
            this.Controls.Add(this.groupBox1);
            this.Name = "HwndSearchControl";
            this.Size = new System.Drawing.Size(282, 177);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbAllHwnds;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbSpecificHWNDs;
        private System.Windows.Forms.RadioButton rbProcess;
        private System.Windows.Forms.Button btnEditProps;
    }
}
