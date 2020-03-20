namespace LakoparkProjekt
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
            this.balraPictureBox = new System.Windows.Forms.PictureBox();
            this.tombGroupBox = new System.Windows.Forms.GroupBox();
            this.arcPictureBox = new System.Windows.Forms.PictureBox();
            this.jobraPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.balraPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobraPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // balraPictureBox
            // 
            this.balraPictureBox.Location = new System.Drawing.Point(234, 394);
            this.balraPictureBox.Name = "balraPictureBox";
            this.balraPictureBox.Size = new System.Drawing.Size(100, 44);
            this.balraPictureBox.TabIndex = 0;
            this.balraPictureBox.TabStop = false;
            // 
            // tombGroupBox
            // 
            this.tombGroupBox.Location = new System.Drawing.Point(144, 13);
            this.tombGroupBox.Name = "tombGroupBox";
            this.tombGroupBox.Size = new System.Drawing.Size(644, 333);
            this.tombGroupBox.TabIndex = 1;
            this.tombGroupBox.TabStop = false;
            // 
            // arcPictureBox
            // 
            this.arcPictureBox.Location = new System.Drawing.Point(12, 12);
            this.arcPictureBox.Name = "arcPictureBox";
            this.arcPictureBox.Size = new System.Drawing.Size(100, 150);
            this.arcPictureBox.TabIndex = 0;
            this.arcPictureBox.TabStop = false;
            // 
            // jobraPictureBox
            // 
            this.jobraPictureBox.Location = new System.Drawing.Point(362, 394);
            this.jobraPictureBox.Name = "jobraPictureBox";
            this.jobraPictureBox.Size = new System.Drawing.Size(100, 44);
            this.jobraPictureBox.TabIndex = 0;
            this.jobraPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tombGroupBox);
            this.Controls.Add(this.arcPictureBox);
            this.Controls.Add(this.jobraPictureBox);
            this.Controls.Add(this.balraPictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.balraPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobraPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox balraPictureBox;
        private System.Windows.Forms.GroupBox tombGroupBox;
        private System.Windows.Forms.PictureBox arcPictureBox;
        private System.Windows.Forms.PictureBox jobraPictureBox;
    }
}

