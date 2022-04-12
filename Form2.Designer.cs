namespace qtellq
{
    partial class fmSetting
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
            this.components = new System.ComponentModel.Container();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.TabGeneral = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.TabConfig = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.paneCtrl = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // TabGeneral
            // 
            this.TabGeneral.Location = new System.Drawing.Point(12, 1);
            this.TabGeneral.Name = "TabGeneral";
            this.TabGeneral.Size = new System.Drawing.Size(104, 41);
            this.TabGeneral.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.TabGeneral.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.TabGeneral.StateCommon.Border.Color2 = System.Drawing.Color.Red;
            this.TabGeneral.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.TabGeneral.StateCommon.Border.Width = 0;
            this.TabGeneral.TabIndex = 0;
            this.TabGeneral.Values.Text = "General";
            this.TabGeneral.Click += new System.EventHandler(this.TabGeneral_Click);
            // 
            // TabConfig
            // 
            this.TabConfig.Location = new System.Drawing.Point(122, 1);
            this.TabConfig.Name = "TabConfig";
            this.TabConfig.Size = new System.Drawing.Size(95, 41);
            this.TabConfig.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.TabConfig.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.TabConfig.StateCommon.Border.Color2 = System.Drawing.Color.Red;
            this.TabConfig.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.TabConfig.StateCommon.Border.Width = 0;
            this.TabConfig.TabIndex = 1;
            this.TabConfig.Values.Text = "Config";
            this.TabConfig.Click += new System.EventHandler(this.TabConfig_Click);
            // 
            // paneCtrl
            // 
            this.paneCtrl.Location = new System.Drawing.Point(0, 48);
            this.paneCtrl.Name = "paneCtrl";
            this.paneCtrl.Size = new System.Drawing.Size(781, 451);
            this.paneCtrl.TabIndex = 2;
            // 
            // fmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 502);
            this.Controls.Add(this.TabConfig);
            this.Controls.Add(this.TabGeneral);
            this.Controls.Add(this.paneCtrl);
            this.Name = "fmSetting";
            this.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 11;
            this.StateCommon.Border.Width = 0;
            this.StateCommon.Header.Back.Color1 = System.Drawing.Color.White;
            this.StateCommon.Header.Back.Color2 = System.Drawing.Color.White;
            this.StateCommon.Header.Border.Color1 = System.Drawing.Color.White;
            this.StateCommon.Header.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.StateCommon.Header.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Header.Border.Width = 0;
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton TabGeneral;
        private ComponentFactory.Krypton.Toolkit.KryptonButton TabConfig;
        private Panel paneCtrl;
    }
}