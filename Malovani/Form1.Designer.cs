namespace Malovani
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.customColour = new System.Windows.Forms.PictureBox();
            this.CustomColor = new System.Windows.Forms.PictureBox();
            this.WhitePen = new System.Windows.Forms.PictureBox();
            this.GrayPen = new System.Windows.Forms.PictureBox();
            this.BlackPen = new System.Windows.Forms.PictureBox();
            this.YellowPen = new System.Windows.Forms.PictureBox();
            this.RedPen = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Rectangle = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customColour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WhitePen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrayPen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlackPen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YellowPen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedPen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(13, 166);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(775, 497);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.customColour);
            this.panel1.Controls.Add(this.CustomColor);
            this.panel1.Controls.Add(this.WhitePen);
            this.panel1.Controls.Add(this.GrayPen);
            this.panel1.Controls.Add(this.BlackPen);
            this.panel1.Controls.Add(this.YellowPen);
            this.panel1.Controls.Add(this.RedPen);
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 40);
            this.panel1.TabIndex = 1;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // customColour
            // 
            this.customColour.BackColor = System.Drawing.Color.SeaGreen;
            this.customColour.Location = new System.Drawing.Point(250, 5);
            this.customColour.Name = "customColour";
            this.customColour.Size = new System.Drawing.Size(30, 30);
            this.customColour.TabIndex = 24;
            this.customColour.TabStop = false;
            this.customColour.Click += new System.EventHandler(this.customColour_Click);
            // 
            // CustomColor
            // 
            this.CustomColor.BackColor = System.Drawing.Color.SeaGreen;
            this.CustomColor.Location = new System.Drawing.Point(210, 5);
            this.CustomColor.Name = "CustomColor";
            this.CustomColor.Size = new System.Drawing.Size(30, 30);
            this.CustomColor.TabIndex = 23;
            this.CustomColor.TabStop = false;
            // 
            // WhitePen
            // 
            this.WhitePen.BackColor = System.Drawing.Color.White;
            this.WhitePen.Location = new System.Drawing.Point(170, 5);
            this.WhitePen.Name = "WhitePen";
            this.WhitePen.Size = new System.Drawing.Size(30, 30);
            this.WhitePen.TabIndex = 22;
            this.WhitePen.TabStop = false;
            this.WhitePen.Click += new System.EventHandler(this.RedPen_Click);
            // 
            // GrayPen
            // 
            this.GrayPen.BackColor = System.Drawing.Color.Gray;
            this.GrayPen.Location = new System.Drawing.Point(130, 5);
            this.GrayPen.Name = "GrayPen";
            this.GrayPen.Size = new System.Drawing.Size(30, 30);
            this.GrayPen.TabIndex = 21;
            this.GrayPen.TabStop = false;
            this.GrayPen.Click += new System.EventHandler(this.RedPen_Click);
            // 
            // BlackPen
            // 
            this.BlackPen.BackColor = System.Drawing.Color.Black;
            this.BlackPen.Location = new System.Drawing.Point(90, 5);
            this.BlackPen.Name = "BlackPen";
            this.BlackPen.Size = new System.Drawing.Size(30, 30);
            this.BlackPen.TabIndex = 20;
            this.BlackPen.TabStop = false;
            this.BlackPen.Click += new System.EventHandler(this.RedPen_Click);
            // 
            // YellowPen
            // 
            this.YellowPen.BackColor = System.Drawing.Color.Yellow;
            this.YellowPen.Location = new System.Drawing.Point(50, 5);
            this.YellowPen.Name = "YellowPen";
            this.YellowPen.Size = new System.Drawing.Size(30, 30);
            this.YellowPen.TabIndex = 19;
            this.YellowPen.TabStop = false;
            this.YellowPen.Click += new System.EventHandler(this.RedPen_Click);
            // 
            // RedPen
            // 
            this.RedPen.BackColor = System.Drawing.Color.Red;
            this.RedPen.Location = new System.Drawing.Point(10, 5);
            this.RedPen.Name = "RedPen";
            this.RedPen.Size = new System.Drawing.Size(30, 30);
            this.RedPen.TabIndex = 18;
            this.RedPen.TabStop = false;
            this.RedPen.Click += new System.EventHandler(this.RedPen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pen size";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(70, 53);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(45, 20);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Rectangle
            // 
            this.Rectangle.Location = new System.Drawing.Point(100, 79);
            this.Rectangle.Name = "Rectangle";
            this.Rectangle.Size = new System.Drawing.Size(75, 81);
            this.Rectangle.TabIndex = 4;
            this.Rectangle.Text = "Rectangle";
            this.Rectangle.UseVisualStyleBackColor = true;
            this.Rectangle.Click += new System.EventHandler(this.Rectangle_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(13, 79);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 81);
            this.clearBtn.TabIndex = 5;
            this.clearBtn.Text = "Clear/New";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(182, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 81);
            this.button1.TabIndex = 6;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 675);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.Rectangle);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customColour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WhitePen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrayPen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlackPen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YellowPen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedPen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox RedPen;
        private System.Windows.Forms.PictureBox WhitePen;
        private System.Windows.Forms.PictureBox GrayPen;
        private System.Windows.Forms.PictureBox BlackPen;
        private System.Windows.Forms.PictureBox YellowPen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.PictureBox CustomColor;
        private System.Windows.Forms.Button Rectangle;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.PictureBox customColour;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

