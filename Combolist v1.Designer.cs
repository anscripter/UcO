namespace UcO
{
    partial class Combolist_v1
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
            this.location = new Telerik.WinControls.UI.RadTextBox();
            this.browse = new Telerik.WinControls.UI.RadButton();
            this.shuffle = new Telerik.WinControls.UI.RadButton();
            this.convert = new Telerik.WinControls.UI.RadButton();
            this.save = new Telerik.WinControls.UI.RadButton();
            this.nulled = new System.Windows.Forms.LinkLabel();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.scanned = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.location)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.browse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shuffle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.convert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scanned)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // location
            // 
            this.location.Location = new System.Drawing.Point(13, 53);
            this.location.Name = "location";
            this.location.NullText = "Combolist Location";
            this.location.ReadOnly = true;
            this.location.Size = new System.Drawing.Size(233, 36);
            this.location.TabIndex = 0;
            this.location.ThemeName = "MaterialBlueGrey";
            // 
            // browse
            // 
            this.browse.Location = new System.Drawing.Point(252, 53);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(130, 36);
            this.browse.TabIndex = 1;
            this.browse.Text = "Browse";
            this.browse.ThemeName = "MaterialBlueGrey";
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // shuffle
            // 
            this.shuffle.Location = new System.Drawing.Point(13, 95);
            this.shuffle.Name = "shuffle";
            this.shuffle.Size = new System.Drawing.Size(181, 36);
            this.shuffle.TabIndex = 2;
            this.shuffle.Text = "Shuffle List";
            this.shuffle.ThemeName = "MaterialBlueGrey";
            this.shuffle.Click += new System.EventHandler(this.shuffle_Click);
            // 
            // convert
            // 
            this.convert.Location = new System.Drawing.Point(201, 95);
            this.convert.Name = "convert";
            this.convert.Size = new System.Drawing.Size(181, 36);
            this.convert.TabIndex = 3;
            this.convert.Text = "Convert Combolist";
            this.convert.ThemeName = "MaterialBlueGrey";
            this.convert.Click += new System.EventHandler(this.convert_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(98, 139);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(284, 47);
            this.save.TabIndex = 4;
            this.save.Text = "Save Combolist";
            this.save.ThemeName = "MaterialBlueGrey";
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // nulled
            // 
            this.nulled.ActiveLinkColor = System.Drawing.Color.Teal;
            this.nulled.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nulled.LinkColor = System.Drawing.Color.Gray;
            this.nulled.Location = new System.Drawing.Point(13, 139);
            this.nulled.Name = "nulled";
            this.nulled.Size = new System.Drawing.Size(79, 47);
            this.nulled.TabIndex = 5;
            this.nulled.TabStop = true;
            this.nulled.Text = "Nulled.to";
            this.nulled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nulled.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.nulled_LinkClicked);
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.scanned);
            this.radPanel1.Location = new System.Drawing.Point(12, 12);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(370, 35);
            this.radPanel1.TabIndex = 6;
            this.radPanel1.ThemeName = "MaterialBlueGrey";
            // 
            // scanned
            // 
            this.scanned.AutoSize = false;
            this.scanned.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scanned.Location = new System.Drawing.Point(0, 0);
            this.scanned.Name = "scanned";
            this.scanned.Size = new System.Drawing.Size(370, 35);
            this.scanned.TabIndex = 0;
            this.scanned.Text = "Accounts Scanned: 0";
            this.scanned.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.scanned.ThemeName = "MaterialBlueGrey";
            // 
            // Combolist_v1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 198);
            this.Controls.Add(this.radPanel1);
            this.Controls.Add(this.nulled);
            this.Controls.Add(this.save);
            this.Controls.Add(this.convert);
            this.Controls.Add(this.shuffle);
            this.Controls.Add(this.browse);
            this.Controls.Add(this.location);
            this.MaximizeBox = false;
            this.Name = "Combolist_v1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "UcO - Ultimate Combolist Optimization";
            this.ThemeName = "MaterialBlueGrey";
            ((System.ComponentModel.ISupportInitialize)(this.location)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.browse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shuffle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.convert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.save)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scanned)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.MaterialBlueGreyTheme materialBlueGreyTheme1;
        private Telerik.WinControls.UI.RadTextBox location;
        private Telerik.WinControls.UI.RadButton browse;
        private Telerik.WinControls.UI.RadButton shuffle;
        private Telerik.WinControls.UI.RadButton convert;
        private Telerik.WinControls.UI.RadButton save;
        private System.Windows.Forms.LinkLabel nulled;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadLabel scanned;
    }
}