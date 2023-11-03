
namespace DevUtils.CodeFormater
{
    partial class frmMain
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
            this.btnStructAnnotations = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStructAnnotations
            // 
            this.btnStructAnnotations.Location = new System.Drawing.Point(27, 27);
            this.btnStructAnnotations.Name = "btnStructAnnotations";
            this.btnStructAnnotations.Size = new System.Drawing.Size(109, 23);
            this.btnStructAnnotations.TabIndex = 0;
            this.btnStructAnnotations.Text = "StructAnnotations";
            this.btnStructAnnotations.UseVisualStyleBackColor = true;
            this.btnStructAnnotations.Click += new System.EventHandler(this.btnStructAnnotations_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 369);
            this.Controls.Add(this.btnStructAnnotations);
            this.Name = "frmMain";
            this.Text = "=FBug= --DevUtils--";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStructAnnotations;
    }
}

