namespace UcO
{
    partial class Convert
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
            this.materialBlueGreyTheme1 = new Telerik.WinControls.Themes.MaterialBlueGreyTheme();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.e_to_u = new Telerik.WinControls.UI.RadRadioButton();
            this.u_to_e = new Telerik.WinControls.UI.RadRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.e_to_u)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.u_to_e)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(116, 78);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(226, 46);
            this.radButton1.TabIndex = 0;
            this.radButton1.Text = "Convert and Save";
            this.radButton1.ThemeName = "MaterialBlueGrey";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.e_to_u);
            this.radPanel1.Controls.Add(this.u_to_e);
            this.radPanel1.Location = new System.Drawing.Point(13, 13);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(329, 59);
            this.radPanel1.TabIndex = 1;
            this.radPanel1.ThemeName = "MaterialBlueGrey";
            // 
            // e_to_u
            // 
            this.e_to_u.Location = new System.Drawing.Point(3, 34);
            this.e_to_u.Name = "e_to_u";
            this.e_to_u.Size = new System.Drawing.Size(148, 22);
            this.e_to_u.TabIndex = 1;
            this.e_to_u.Text = "Email to Username";
            this.e_to_u.ThemeName = "MaterialBlueGrey";
            // 
            // u_to_e
            // 
            this.u_to_e.Location = new System.Drawing.Point(3, 3);
            this.u_to_e.Name = "u_to_e";
            this.u_to_e.Size = new System.Drawing.Size(148, 22);
            this.u_to_e.TabIndex = 0;
            this.u_to_e.Text = "Username to Email";
            this.u_to_e.ThemeName = "MaterialBlueGrey";
            // 
            // Convert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 136);
            this.Controls.Add(this.radPanel1);
            this.Controls.Add(this.radButton1);
            this.MaximizeBox = false;
            this.Name = "Convert";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "UcO - Convert";
            this.ThemeName = "MaterialBlueGrey";
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.e_to_u)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.u_to_e)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.MaterialBlueGreyTheme materialBlueGreyTheme1;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadRadioButton e_to_u;
        private Telerik.WinControls.UI.RadRadioButton u_to_e;
    }
}
