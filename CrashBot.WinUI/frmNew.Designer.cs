namespace CrashBot.WinUI
{
    partial class frmNew
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
            this.ptbStop = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cbTacno = new System.Windows.Forms.CheckBox();
            this.cbNetacno = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbStop
            // 
            this.ptbStop.Image = global::CrashBot.WinUI.Properties.Resources.smanjenZnak1;
            this.ptbStop.Location = new System.Drawing.Point(70, 66);
            this.ptbStop.Name = "ptbStop";
            this.ptbStop.Size = new System.Drawing.Size(147, 141);
            this.ptbStop.TabIndex = 0;
            this.ptbStop.TabStop = false;
            this.ptbStop.Click += new System.EventHandler(this.ptbStop_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CrashBot.WinUI.Properties.Resources.smanjenArrow___right;
            this.pictureBox2.Location = new System.Drawing.Point(294, 94);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(126, 79);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // cbTacno
            // 
            this.cbTacno.AutoSize = true;
            this.cbTacno.Location = new System.Drawing.Point(320, 232);
            this.cbTacno.Name = "cbTacno";
            this.cbTacno.Size = new System.Drawing.Size(80, 17);
            this.cbTacno.TabIndex = 2;
            this.cbTacno.Text = "checkBox1";
            this.cbTacno.UseVisualStyleBackColor = true;
            // 
            // cbNetacno
            // 
            this.cbNetacno.AutoSize = true;
            this.cbNetacno.Location = new System.Drawing.Point(320, 268);
            this.cbNetacno.Name = "cbNetacno";
            this.cbNetacno.Size = new System.Drawing.Size(80, 17);
            this.cbNetacno.TabIndex = 3;
            this.cbNetacno.Text = "checkBox2";
            this.cbNetacno.UseVisualStyleBackColor = true;
            // 
            // frmNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbNetacno);
            this.Controls.Add(this.cbTacno);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.ptbStop);
            this.Name = "frmNew";
            this.Text = "frmNew";
            
            ((System.ComponentModel.ISupportInitialize)(this.ptbStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbStop;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox cbTacno;
        private System.Windows.Forms.CheckBox cbNetacno;
    }
}