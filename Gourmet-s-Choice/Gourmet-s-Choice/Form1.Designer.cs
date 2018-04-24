namespace Gourmet_s_Choice
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pctbRound = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbRound)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbLeft
            // 
            this.ptbLeft.Location = new System.Drawing.Point(31, 225);
            this.ptbLeft.Margin = new System.Windows.Forms.Padding(8);
            this.ptbLeft.Name = "ptbLeft";
            this.ptbLeft.Size = new System.Drawing.Size(936, 968);
            this.ptbLeft.TabIndex = 0;
            this.ptbLeft.TabStop = false;
            this.ptbLeft.Click += new System.EventHandler(this.ptbLeft_Click);
            // 
            // ptbRight
            // 
            this.ptbRight.Location = new System.Drawing.Point(982, 225);
            this.ptbRight.Margin = new System.Windows.Forms.Padding(8);
            this.ptbRight.Name = "ptbRight";
            this.ptbRight.Size = new System.Drawing.Size(975, 968);
            this.ptbRight.TabIndex = 1;
            this.ptbRight.TabStop = false;
            this.ptbRight.Click += new System.EventHandler(this.ptbRight_Click);
            // 
            // txtbxRight
            // 
            this.txtbxRight.Location = new System.Drawing.Point(1381, 602);
            this.txtbxRight.Margin = new System.Windows.Forms.Padding(8);
            this.txtbxRight.Name = "txtbxRight";
            this.txtbxRight.Size = new System.Drawing.Size(251, 42);
            this.txtbxRight.TabIndex = 3;
            // 
            // txtbxLeft
            // 
            this.txtbxLeft.Location = new System.Drawing.Point(319, 602);
            this.txtbxLeft.Margin = new System.Windows.Forms.Padding(8);
            this.txtbxLeft.Name = "txtbxLeft";
            this.txtbxLeft.Size = new System.Drawing.Size(251, 42);
            this.txtbxLeft.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(357, 670);
            this.button1.Margin = new System.Windows.Forms.Padding(8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 58);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1412, 670);
            this.button2.Margin = new System.Windows.Forms.Padding(8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 58);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pctbRound
            // 
            this.pctbRound.Location = new System.Drawing.Point(856, 12);
            this.pctbRound.Name = "pctbRound";
            this.pctbRound.Size = new System.Drawing.Size(214, 202);
            this.pctbRound.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctbRound.TabIndex = 6;
            this.pctbRound.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1988, 1222);
            this.Controls.Add(this.pctbRound);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtbxRight);
            this.Controls.Add(this.txtbxLeft);
            this.Controls.Add(this.ptbRight);
            this.Controls.Add(this.ptbLeft);
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "Form1";
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pctbRound;
    }
}

