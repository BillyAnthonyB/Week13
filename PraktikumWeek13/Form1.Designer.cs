namespace PraktikumWeek13
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
            this.labelInput = new System.Windows.Forms.Label();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.labelNama = new System.Windows.Forms.Label();
            this.buttonProses = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Location = new System.Drawing.Point(36, 39);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(60, 13);
            this.labelInput.TabIndex = 0;
            this.labelInput.Text = "Input Data:";
            this.labelInput.Click += new System.EventHandler(this.labelInput_Click);
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(39, 64);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(364, 20);
            this.textBoxNama.TabIndex = 1;
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelNama.Location = new System.Drawing.Point(34, 131);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(93, 25);
            this.labelNama.TabIndex = 2;
            this.labelNama.Text = "[EMPTY]";
            // 
            // buttonProses
            // 
            this.buttonProses.Location = new System.Drawing.Point(39, 90);
            this.buttonProses.Name = "buttonProses";
            this.buttonProses.Size = new System.Drawing.Size(75, 23);
            this.buttonProses.TabIndex = 3;
            this.buttonProses.Text = "Proses";
            this.buttonProses.UseVisualStyleBackColor = true;
            this.buttonProses.Click += new System.EventHandler(this.buttonProses_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PraktikumWeek13.Properties.Resources._7246698;
            this.pictureBox1.Location = new System.Drawing.Point(438, 172);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 291);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonProses);
            this.Controls.Add(this.labelNama);
            this.Controls.Add(this.textBoxNama);
            this.Controls.Add(this.labelInput);
            this.Name = "Form1";
            this.Text = "Form Pengaturan Warna";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Button buttonProses;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

