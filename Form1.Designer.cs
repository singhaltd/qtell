namespace qtellq
{
    partial class QtelFrm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QtelFrm));
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.btnSkip = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnRecall = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnCall = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnServed = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbNextService = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbNextNumber = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnReject = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lbMecalled = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbWaiting = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbCounter = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbtnSeting = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnSetting = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSetting)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSkip
            // 
            resources.ApplyResources(this.btnSkip, "btnSkip");
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnSkip.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnSkip.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSkip.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSkip.StateCommon.Border.Rounding = 10;
            this.btnSkip.StateCommon.Border.Width = 2;
            this.btnSkip.Values.ExtraText = resources.GetString("btnSkip.Values.ExtraText");
            this.btnSkip.Values.ImageTransparentColor = ((System.Drawing.Color)(resources.GetObject("btnSkip.Values.ImageTransparentColor")));
            this.btnSkip.Values.Text = resources.GetString("btnSkip.Values.Text");
            // 
            // btnRecall
            // 
            resources.ApplyResources(this.btnRecall, "btnRecall");
            this.btnRecall.Name = "btnRecall";
            this.btnRecall.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnRecall.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnRecall.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRecall.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnRecall.StateCommon.Border.Rounding = 10;
            this.btnRecall.StateCommon.Border.Width = 2;
            this.btnRecall.Values.ExtraText = resources.GetString("btnRecall.Values.ExtraText");
            this.btnRecall.Values.ImageTransparentColor = ((System.Drawing.Color)(resources.GetObject("btnRecall.Values.ImageTransparentColor")));
            this.btnRecall.Values.Text = resources.GetString("btnRecall.Values.Text");
            this.btnRecall.Click += new System.EventHandler(this.btnRecall_Click);
            // 
            // btnCall
            // 
            resources.ApplyResources(this.btnCall, "btnCall");
            this.btnCall.Name = "btnCall";
            this.btnCall.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnCall.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnCall.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCall.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCall.StateCommon.Border.Rounding = 10;
            this.btnCall.StateCommon.Border.Width = 2;
            this.btnCall.Values.ExtraText = resources.GetString("btnCall.Values.ExtraText");
            this.btnCall.Values.ImageTransparentColor = ((System.Drawing.Color)(resources.GetObject("btnCall.Values.ImageTransparentColor")));
            this.btnCall.Values.Text = resources.GetString("btnCall.Values.Text");
            this.btnCall.Click += new System.EventHandler(this.btnCall_Click);
            // 
            // btnServed
            // 
            resources.ApplyResources(this.btnServed, "btnServed");
            this.btnServed.Name = "btnServed";
            this.btnServed.StateCommon.Back.Color1 = System.Drawing.Color.LimeGreen;
            this.btnServed.StateCommon.Back.Color2 = System.Drawing.Color.ForestGreen;
            this.btnServed.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnServed.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnServed.StateCommon.Border.Rounding = 10;
            this.btnServed.StateCommon.Border.Width = 2;
            this.btnServed.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnServed.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnServed.Values.ExtraText = resources.GetString("btnServed.Values.ExtraText");
            this.btnServed.Values.ImageTransparentColor = ((System.Drawing.Color)(resources.GetObject("btnServed.Values.ImageTransparentColor")));
            this.btnServed.Values.Text = resources.GetString("btnServed.Values.Text");
            this.btnServed.Click += new System.EventHandler(this.btnServed_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // lbNextService
            // 
            resources.ApplyResources(this.lbNextService, "lbNextService");
            this.lbNextService.Name = "lbNextService";
            this.lbNextService.Values.ExtraText = resources.GetString("lbNextService.Values.ExtraText");
            this.lbNextService.Values.ImageTransparentColor = ((System.Drawing.Color)(resources.GetObject("lbNextService.Values.ImageTransparentColor")));
            this.lbNextService.Values.Text = resources.GetString("lbNextService.Values.Text");
            // 
            // lbNextNumber
            // 
            resources.ApplyResources(this.lbNextNumber, "lbNextNumber");
            this.lbNextNumber.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.lbNextNumber.Name = "lbNextNumber";
            this.lbNextNumber.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbNextNumber.Values.ExtraText = resources.GetString("lbNextNumber.Values.ExtraText");
            this.lbNextNumber.Values.ImageTransparentColor = ((System.Drawing.Color)(resources.GetObject("lbNextNumber.Values.ImageTransparentColor")));
            this.lbNextNumber.Values.Text = resources.GetString("lbNextNumber.Values.Text");
            // 
            // btnReject
            // 
            resources.ApplyResources(this.btnReject, "btnReject");
            this.btnReject.Name = "btnReject";
            this.btnReject.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnReject.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnReject.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnReject.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnReject.StateCommon.Border.Rounding = 10;
            this.btnReject.StateCommon.Border.Width = 2;
            this.btnReject.Values.ExtraText = resources.GetString("btnReject.Values.ExtraText");
            this.btnReject.Values.ImageTransparentColor = ((System.Drawing.Color)(resources.GetObject("btnReject.Values.ImageTransparentColor")));
            this.btnReject.Values.Text = resources.GetString("btnReject.Values.Text");
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // lbMecalled
            // 
            resources.ApplyResources(this.lbMecalled, "lbMecalled");
            this.lbMecalled.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.lbMecalled.Name = "lbMecalled";
            this.lbMecalled.Values.ExtraText = resources.GetString("lbMecalled.Values.ExtraText");
            this.lbMecalled.Values.ImageTransparentColor = ((System.Drawing.Color)(resources.GetObject("lbMecalled.Values.ImageTransparentColor")));
            this.lbMecalled.Values.Text = resources.GetString("lbMecalled.Values.Text");
            // 
            // lbWaiting
            // 
            resources.ApplyResources(this.lbWaiting, "lbWaiting");
            this.lbWaiting.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.lbWaiting.Name = "lbWaiting";
            this.lbWaiting.Values.ExtraText = resources.GetString("lbWaiting.Values.ExtraText");
            this.lbWaiting.Values.ImageTransparentColor = ((System.Drawing.Color)(resources.GetObject("lbWaiting.Values.ImageTransparentColor")));
            this.lbWaiting.Values.Text = resources.GetString("lbWaiting.Values.Text");
            // 
            // lbCounter
            // 
            resources.ApplyResources(this.lbCounter, "lbCounter");
            this.lbCounter.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.lbCounter.Name = "lbCounter";
            this.lbCounter.Values.ExtraText = resources.GetString("lbCounter.Values.ExtraText");
            this.lbCounter.Values.ImageTransparentColor = ((System.Drawing.Color)(resources.GetObject("lbCounter.Values.ImageTransparentColor")));
            this.lbCounter.Values.Text = resources.GetString("lbCounter.Values.Text");
            // 
            // lbtnSeting
            // 
            resources.ApplyResources(this.lbtnSeting, "lbtnSeting");
            this.lbtnSeting.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.lbtnSeting.Name = "lbtnSeting";
            this.lbtnSeting.Values.ExtraText = resources.GetString("lbtnSeting.Values.ExtraText");
            this.lbtnSeting.Values.ImageTransparentColor = ((System.Drawing.Color)(resources.GetObject("lbtnSeting.Values.ImageTransparentColor")));
            this.lbtnSeting.Values.Text = resources.GetString("lbtnSeting.Values.Text");
            // 
            // btnSetting
            // 
            resources.ApplyResources(this.btnSetting, "btnSetting");
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.TabStop = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // QtelFrm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbtnSeting);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.lbCounter);
            this.Controls.Add(this.lbWaiting);
            this.Controls.Add(this.lbMecalled);
            this.Controls.Add(this.btnReject);
            this.Controls.Add(this.lbNextService);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnServed);
            this.Controls.Add(this.btnCall);
            this.Controls.Add(this.btnRecall);
            this.Controls.Add(this.btnSkip);
            this.Controls.Add(this.lbNextNumber);
            this.MaximizeBox = false;
            this.Name = "QtelFrm";
            this.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.StateCommon.Border.ColorAngle = 0F;
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 12;
            this.StateCommon.Border.Width = 0;
            this.StateCommon.Header.Back.Color1 = System.Drawing.Color.White;
            this.StateCommon.Header.Back.Color2 = System.Drawing.Color.White;
            this.StateCommon.Header.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(85)))), ((int)(((byte)(4)))));
            this.StateCommon.Header.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(85)))), ((int)(((byte)(4)))));
            this.Load += new System.EventHandler(this.QtelFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSetting)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSkip;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnRecall;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCall;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnServed;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbNextService;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbNextNumber;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnReject;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbMecalled;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbWaiting;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbCounter;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbtnSeting;
        private PictureBox btnSetting;
    }
}