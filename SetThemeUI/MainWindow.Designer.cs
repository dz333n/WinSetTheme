namespace SetThemeUI
{
    partial class MainWindow
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPerform = new System.Windows.Forms.Button();
            this.log = new SetThemeUI.LogControl();
            this.hwndSearchControl1 = new SetThemeUI.HwndSearchControl();
            this.themePickControl1 = new SetThemeUI.ThemePickControl();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.hwndSearchControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.themePickControl1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.54683F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(550, 173);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.log, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnPerform, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 191);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.77698F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.22302F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(550, 139);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // btnPerform
            // 
            this.btnPerform.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPerform.Location = new System.Drawing.Point(3, 3);
            this.btnPerform.Name = "btnPerform";
            this.btnPerform.Size = new System.Drawing.Size(544, 33);
            this.btnPerform.TabIndex = 1;
            this.btnPerform.Text = "Perform SetWindowTheme for each HWND";
            this.btnPerform.UseVisualStyleBackColor = true;
            // 
            // log
            // 
            this.log.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.log.Location = new System.Drawing.Point(3, 42);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(544, 94);
            this.log.TabIndex = 0;
            // 
            // hwndSearchControl1
            // 
            this.hwndSearchControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hwndSearchControl1.Location = new System.Drawing.Point(3, 3);
            this.hwndSearchControl1.Name = "hwndSearchControl1";
            this.hwndSearchControl1.Size = new System.Drawing.Size(269, 167);
            this.hwndSearchControl1.TabIndex = 0;
            // 
            // themePickControl1
            // 
            this.themePickControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.themePickControl1.Location = new System.Drawing.Point(278, 3);
            this.themePickControl1.Name = "themePickControl1";
            this.themePickControl1.Size = new System.Drawing.Size(269, 167);
            this.themePickControl1.TabIndex = 1;
            // 
            // MainWindow
            // 
            this.AcceptButton = this.btnPerform;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 342);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainWindow";
            this.Text = "SetTheme";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private LogControl log;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private HwndSearchControl hwndSearchControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnPerform;
        private ThemePickControl themePickControl1;
    }
}

