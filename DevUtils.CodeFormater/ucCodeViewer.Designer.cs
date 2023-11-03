
namespace DevUtils.CodeFormater
{
    partial class ucCodeViewer
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
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.txtRaw = new System.Windows.Forms.TextBox();
            this.txtChanged = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // scMain
            // 
            this.scMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.Location = new System.Drawing.Point(0, 0);
            this.scMain.Name = "scMain";
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.txtRaw);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.txtChanged);
            this.scMain.Size = new System.Drawing.Size(400, 200);
            this.scMain.SplitterDistance = 200;
            this.scMain.SplitterWidth = 2;
            this.scMain.TabIndex = 0;
            // 
            // txtRaw
            // 
            this.txtRaw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRaw.Location = new System.Drawing.Point(0, 0);
            this.txtRaw.Multiline = true;
            this.txtRaw.Name = "txtRaw";
            this.txtRaw.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRaw.Size = new System.Drawing.Size(198, 198);
            this.txtRaw.TabIndex = 0;
            this.txtRaw.TextChanged += new System.EventHandler(this.txtRaw_TextChanged);
            // 
            // txtChanged
            // 
            this.txtChanged.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtChanged.Location = new System.Drawing.Point(0, 0);
            this.txtChanged.Multiline = true;
            this.txtChanged.Name = "txtChanged";
            this.txtChanged.ReadOnly = true;
            this.txtChanged.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtChanged.Size = new System.Drawing.Size(196, 198);
            this.txtChanged.TabIndex = 1;
            this.txtChanged.DoubleClick += new System.EventHandler(this.txtChanged_DoubleClick);
            // 
            // ucCodeViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.scMain);
            this.Name = "ucCodeViewer";
            this.Size = new System.Drawing.Size(400, 200);
            this.Load += new System.EventHandler(this.ucCodeViewer_Load);
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel1.PerformLayout();
            this.scMain.Panel2.ResumeLayout(false);
            this.scMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.TextBox txtRaw;
        private System.Windows.Forms.TextBox txtChanged;
    }
}
