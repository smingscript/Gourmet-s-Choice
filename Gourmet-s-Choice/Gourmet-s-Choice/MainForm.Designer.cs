namespace Gourmet_s_Choice
{
    partial class MainForm
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
            this.ptbLeft = new System.Windows.Forms.PictureBox();
            this.ptbRight = new System.Windows.Forms.PictureBox();
            this.txtbxRight = new System.Windows.Forms.TextBox();
            this.txtbxLeft = new System.Windows.Forms.TextBox();
            this.pctbRound = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbRound)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbLeft
            // 
            this.ptbLeft.Location = new System.Drawing.Point(12, 90);
            this.ptbLeft.Name = "ptbLeft";
            this.ptbLeft.Size = new System.Drawing.Size(364, 387);
            this.ptbLeft.TabIndex = 0;
            this.ptbLeft.TabStop = false;
            this.ptbLeft.Click += new System.EventHandler(this.ptbLeft_Click);
            // 
            // ptbRight
            // 
            this.ptbRight.Location = new System.Drawing.Point(382, 90);
            this.ptbRight.Name = "ptbRight";
            this.ptbRight.Size = new System.Drawing.Size(379, 387);
            this.ptbRight.TabIndex = 1;
            this.ptbRight.TabStop = false;
            this.ptbRight.Click += new System.EventHandler(this.ptbRight_Click);
            // 
            // txtbxRight
            // 
            this.txtbxRight.Location = new System.Drawing.Point(537, 241);
            this.txtbxRight.Name = "txtbxRight";
            this.txtbxRight.Size = new System.Drawing.Size(100, 21);
            this.txtbxRight.TabIndex = 3;
            // 
            // txtbxLeft
            // 
            this.txtbxLeft.Location = new System.Drawing.Point(124, 241);
            this.txtbxLeft.Name = "txtbxLeft";
            this.txtbxLeft.Size = new System.Drawing.Size(100, 21);
            this.txtbxLeft.TabIndex = 2;
            // 
            // pctbRound
            // 
            this.pctbRound.Location = new System.Drawing.Point(333, 5);
            this.pctbRound.Margin = new System.Windows.Forms.Padding(1);
            this.pctbRound.Name = "pctbRound";
            this.pctbRound.Size = new System.Drawing.Size(83, 81);
            this.pctbRound.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctbRound.TabIndex = 6;
            this.pctbRound.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 425);
            this.Controls.Add(this.pctbRound);
            this.Controls.Add(this.txtbxRight);
            this.Controls.Add(this.txtbxLeft);
            this.Controls.Add(this.ptbRight);
            this.Controls.Add(this.ptbLeft);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbRound)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbLeft;
        private System.Windows.Forms.PictureBox ptbRight;
        private System.Windows.Forms.TextBox txtbxRight;
        private System.Windows.Forms.TextBox txtbxLeft;
        private System.Windows.Forms.PictureBox pctbRound;
    }
}

