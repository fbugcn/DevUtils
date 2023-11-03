
namespace DevUtils.CodeFormater
{
    partial class frmStructAnnotations
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
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.nuDelay = new System.Windows.Forms.NumericUpDown();
            this.lblDelay = new System.Windows.Forms.Label();
            this.sStripMain = new System.Windows.Forms.StatusStrip();
            this.tslOutput = new System.Windows.Forms.ToolStripStatusLabel();
            this.cViewer = new DevUtils.CodeFormater.ucCodeViewer();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuDelay)).BeginInit();
            this.sStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // scMain
            // 
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.Location = new System.Drawing.Point(0, 0);
            this.scMain.Name = "scMain";
            this.scMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.nuDelay);
            this.scMain.Panel1.Controls.Add(this.lblDelay);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.sStripMain);
            this.scMain.Panel2.Controls.Add(this.cViewer);
            this.scMain.Size = new System.Drawing.Size(912, 496);
            this.scMain.SplitterDistance = 43;
            this.scMain.TabIndex = 0;
            // 
            // nuDelay
            // 
            this.nuDelay.DecimalPlaces = 1;
            this.nuDelay.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nuDelay.Location = new System.Drawing.Point(60, 12);
            this.nuDelay.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nuDelay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nuDelay.Name = "nuDelay";
            this.nuDelay.Size = new System.Drawing.Size(46, 21);
            this.nuDelay.TabIndex = 0;
            this.nuDelay.Value = new decimal(new int[] {
            8,
            0,
            0,
            65536});
            this.nuDelay.ValueChanged += new System.EventHandler(this.nuDelay_ValueChanged);
            // 
            // lblDelay
            // 
            this.lblDelay.AutoSize = true;
            this.lblDelay.Location = new System.Drawing.Point(12, 15);
            this.lblDelay.Name = "lblDelay";
            this.lblDelay.Size = new System.Drawing.Size(125, 12);
            this.lblDelay.TabIndex = 1;
            this.lblDelay.Text = "延迟：          (秒)";
            // 
            // sStripMain
            // 
            this.sStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslOutput});
            this.sStripMain.Location = new System.Drawing.Point(0, 427);
            this.sStripMain.Name = "sStripMain";
            this.sStripMain.Size = new System.Drawing.Size(912, 22);
            this.sStripMain.TabIndex = 1;
            // 
            // tslOutput
            // 
            this.tslOutput.Name = "tslOutput";
            this.tslOutput.Size = new System.Drawing.Size(0, 17);
            // 
            // cViewer
            // 
            this.cViewer.Delay = 1000;
            this.cViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cViewer.CodeFormating = null;
            this.cViewer.Location = new System.Drawing.Point(0, 0);
            this.cViewer.Name = "cViewer";
            this.cViewer.Size = new System.Drawing.Size(912, 449);
            this.cViewer.TabIndex = 0;
            this.cViewer.Load += new System.EventHandler(this.cViewer_Load);
            // 
            // frmStructAnnotations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 496);
            this.Controls.Add(this.scMain);
            this.Name = "frmStructAnnotations";
            this.Text = "frmStructAnnotations";
            this.Load += new System.EventHandler(this.frmStructAnnotations_Load);
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel1.PerformLayout();
            this.scMain.Panel2.ResumeLayout(false);
            this.scMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nuDelay)).EndInit();
            this.sStripMain.ResumeLayout(false);
            this.sStripMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scMain;
        private ucCodeViewer cViewer;
        private System.Windows.Forms.NumericUpDown nuDelay;
        private System.Windows.Forms.Label lblDelay;
        private System.Windows.Forms.StatusStrip sStripMain;
        private System.Windows.Forms.ToolStripStatusLabel tslOutput;
    }
}