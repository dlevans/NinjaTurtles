namespace NinjaTurtles
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
            this.Leonardo = new System.Windows.Forms.Button();
            this.Michelangelo = new System.Windows.Forms.Button();
            this.Raphael = new System.Windows.Forms.Button();
            this.Donatello = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.April = new System.Windows.Forms.Button();
            this.Shredder = new System.Windows.Forms.Button();
            this.Krang = new System.Windows.Forms.Button();
            this.Splinter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Leonardo
            // 
            this.Leonardo.Location = new System.Drawing.Point(12, 12);
            this.Leonardo.Name = "Leonardo";
            this.Leonardo.Size = new System.Drawing.Size(75, 23);
            this.Leonardo.TabIndex = 0;
            this.Leonardo.Text = "Leonardo";
            this.Leonardo.UseVisualStyleBackColor = true;
            this.Leonardo.Click += new System.EventHandler(this.Leonardo_Click);
            // 
            // Michelangelo
            // 
            this.Michelangelo.Location = new System.Drawing.Point(12, 41);
            this.Michelangelo.Name = "Michelangelo";
            this.Michelangelo.Size = new System.Drawing.Size(75, 23);
            this.Michelangelo.TabIndex = 1;
            this.Michelangelo.Text = "Michelangelo";
            this.Michelangelo.UseVisualStyleBackColor = true;
            this.Michelangelo.Click += new System.EventHandler(this.Michelangelo_Click);
            // 
            // Raphael
            // 
            this.Raphael.Location = new System.Drawing.Point(12, 70);
            this.Raphael.Name = "Raphael";
            this.Raphael.Size = new System.Drawing.Size(75, 23);
            this.Raphael.TabIndex = 2;
            this.Raphael.Text = "Raphael";
            this.Raphael.UseVisualStyleBackColor = true;
            this.Raphael.Click += new System.EventHandler(this.Raphael_Click);
            // 
            // Donatello
            // 
            this.Donatello.Location = new System.Drawing.Point(12, 99);
            this.Donatello.Name = "Donatello";
            this.Donatello.Size = new System.Drawing.Size(75, 23);
            this.Donatello.TabIndex = 3;
            this.Donatello.Text = "Donatello";
            this.Donatello.UseVisualStyleBackColor = true;
            this.Donatello.Click += new System.EventHandler(this.Donatello_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::NinjaTurtles.Properties.Resources.sewer;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(230, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 226);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(501, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 226);
            this.textBox1.TabIndex = 0;
            // 
            // April
            // 
            this.April.Location = new System.Drawing.Point(12, 128);
            this.April.Name = "April";
            this.April.Size = new System.Drawing.Size(75, 23);
            this.April.TabIndex = 6;
            this.April.Text = "April";
            this.April.UseVisualStyleBackColor = true;
            this.April.Click += new System.EventHandler(this.April_Click);
            // 
            // Shredder
            // 
            this.Shredder.Location = new System.Drawing.Point(12, 157);
            this.Shredder.Name = "Shredder";
            this.Shredder.Size = new System.Drawing.Size(75, 23);
            this.Shredder.TabIndex = 7;
            this.Shredder.Text = "Shredder";
            this.Shredder.UseVisualStyleBackColor = true;
            this.Shredder.Click += new System.EventHandler(this.Shredder_Click);
            // 
            // Krang
            // 
            this.Krang.Location = new System.Drawing.Point(12, 186);
            this.Krang.Name = "Krang";
            this.Krang.Size = new System.Drawing.Size(75, 23);
            this.Krang.TabIndex = 8;
            this.Krang.Text = "Krang";
            this.Krang.UseVisualStyleBackColor = true;
            this.Krang.Click += new System.EventHandler(this.Krang_Click);
            // 
            // Splinter
            // 
            this.Splinter.Location = new System.Drawing.Point(12, 215);
            this.Splinter.Name = "Splinter";
            this.Splinter.Size = new System.Drawing.Size(75, 23);
            this.Splinter.TabIndex = 9;
            this.Splinter.Text = "Splinter";
            this.Splinter.UseVisualStyleBackColor = true;
            this.Splinter.Click += new System.EventHandler(this.Splinter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NinjaTurtles.Properties.Resources.tmnt_background;
            this.ClientSize = new System.Drawing.Size(872, 302);
            this.Controls.Add(this.Splinter);
            this.Controls.Add(this.Krang);
            this.Controls.Add(this.Shredder);
            this.Controls.Add(this.April);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Donatello);
            this.Controls.Add(this.Raphael);
            this.Controls.Add(this.Michelangelo);
            this.Controls.Add(this.Leonardo);
            this.Name = "Form1";
            this.Text = "TMNT";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Leonardo;
        private System.Windows.Forms.Button Michelangelo;
        private System.Windows.Forms.Button Raphael;
        private System.Windows.Forms.Button Donatello;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button April;
        private System.Windows.Forms.Button Shredder;
        private System.Windows.Forms.Button Krang;
        private System.Windows.Forms.Button Splinter;
    }
}

