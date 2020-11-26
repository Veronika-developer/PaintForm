namespace PaintApp
{
    partial class Form2
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
            this.RedScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.BluehScrollBar2 = new System.Windows.Forms.HScrollBar();
            this.GreenhScrollBar3 = new System.Windows.Forms.HScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ColorpictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.REDnumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.GREENnumericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.BLUEnumericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ColorpictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.REDnumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GREENnumericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BLUEnumericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // RedScrollBar1
            // 
            this.RedScrollBar1.Location = new System.Drawing.Point(109, 47);
            this.RedScrollBar1.Maximum = 264;
            this.RedScrollBar1.Name = "RedScrollBar1";
            this.RedScrollBar1.Size = new System.Drawing.Size(217, 24);
            this.RedScrollBar1.TabIndex = 0;
            this.RedScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.RedScrollBar1_Scroll);
            // 
            // BluehScrollBar2
            // 
            this.BluehScrollBar2.Location = new System.Drawing.Point(109, 162);
            this.BluehScrollBar2.Maximum = 264;
            this.BluehScrollBar2.Name = "BluehScrollBar2";
            this.BluehScrollBar2.Size = new System.Drawing.Size(217, 24);
            this.BluehScrollBar2.TabIndex = 1;
            this.BluehScrollBar2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.BluehScrollBar2_Scroll);
            // 
            // GreenhScrollBar3
            // 
            this.GreenhScrollBar3.Location = new System.Drawing.Point(109, 104);
            this.GreenhScrollBar3.Maximum = 264;
            this.GreenhScrollBar3.Name = "GreenhScrollBar3";
            this.GreenhScrollBar3.Size = new System.Drawing.Size(217, 24);
            this.GreenhScrollBar3.TabIndex = 2;
            this.GreenhScrollBar3.Scroll += new System.Windows.Forms.ScrollEventHandler(this.GreenhScrollBar3_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(29, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Red:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label2.Location = new System.Drawing.Point(29, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Green:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label3.Location = new System.Drawing.Point(29, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Blue:";
            // 
            // ColorpictureBox1
            // 
            this.ColorpictureBox1.Location = new System.Drawing.Point(411, 21);
            this.ColorpictureBox1.Name = "ColorpictureBox1";
            this.ColorpictureBox1.Size = new System.Drawing.Size(179, 107);
            this.ColorpictureBox1.TabIndex = 10;
            this.ColorpictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SandyBrown;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Location = new System.Drawing.Point(411, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 36);
            this.button1.TabIndex = 11;
            this.button1.Text = "Готово";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // REDnumericUpDown1
            // 
            this.REDnumericUpDown1.Location = new System.Drawing.Point(340, 51);
            this.REDnumericUpDown1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.REDnumericUpDown1.Name = "REDnumericUpDown1";
            this.REDnumericUpDown1.Size = new System.Drawing.Size(55, 20);
            this.REDnumericUpDown1.TabIndex = 12;
            this.REDnumericUpDown1.ValueChanged += new System.EventHandler(this.REDnumericUpDown1_ValueChanged);
            // 
            // GREENnumericUpDown2
            // 
            this.GREENnumericUpDown2.Location = new System.Drawing.Point(340, 108);
            this.GREENnumericUpDown2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.GREENnumericUpDown2.Name = "GREENnumericUpDown2";
            this.GREENnumericUpDown2.Size = new System.Drawing.Size(55, 20);
            this.GREENnumericUpDown2.TabIndex = 13;
            this.GREENnumericUpDown2.ValueChanged += new System.EventHandler(this.GREENnumericUpDown2_ValueChanged);
            // 
            // BLUEnumericUpDown3
            // 
            this.BLUEnumericUpDown3.Location = new System.Drawing.Point(340, 166);
            this.BLUEnumericUpDown3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.BLUEnumericUpDown3.Name = "BLUEnumericUpDown3";
            this.BLUEnumericUpDown3.Size = new System.Drawing.Size(55, 20);
            this.BLUEnumericUpDown3.TabIndex = 14;
            this.BLUEnumericUpDown3.ValueChanged += new System.EventHandler(this.BLUEnumericUpDown3_ValueChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SandyBrown;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Location = new System.Drawing.Point(509, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 36);
            this.button2.TabIndex = 15;
            this.button2.Text = "Другой цвет";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(611, 212);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BLUEnumericUpDown3);
            this.Controls.Add(this.GREENnumericUpDown2);
            this.Controls.Add(this.REDnumericUpDown1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ColorpictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GreenhScrollBar3);
            this.Controls.Add(this.BluehScrollBar2);
            this.Controls.Add(this.RedScrollBar1);
            this.Name = "Form2";
            this.Text = "Color picker";
            ((System.ComponentModel.ISupportInitialize)(this.ColorpictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.REDnumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GREENnumericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BLUEnumericUpDown3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar RedScrollBar1;
        private System.Windows.Forms.HScrollBar BluehScrollBar2;
        private System.Windows.Forms.HScrollBar GreenhScrollBar3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox ColorpictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown REDnumericUpDown1;
        private System.Windows.Forms.NumericUpDown GREENnumericUpDown2;
        private System.Windows.Forms.NumericUpDown BLUEnumericUpDown3;
        private System.Windows.Forms.Button button2;
    }
}