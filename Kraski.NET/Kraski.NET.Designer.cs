namespace Kraski.NET
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pbColor = new System.Windows.Forms.PictureBox();
            this.btnPencil = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnTriangle = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnEllipse = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnFractal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nudZoom = new System.Windows.Forms.NumericUpDown();
            this.nudX = new System.Windows.Forms.NumericUpDown();
            this.nudY = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).BeginInit();
            this.SuspendLayout();
            // 
            // pbColor
            // 
            this.pbColor.BackColor = System.Drawing.Color.Black;
            this.pbColor.Location = new System.Drawing.Point(12, 12);
            this.pbColor.Name = "pbColor";
            this.pbColor.Size = new System.Drawing.Size(20, 20);
            this.pbColor.TabIndex = 0;
            this.pbColor.TabStop = false;
            this.pbColor.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnPencil
            // 
            this.btnPencil.Location = new System.Drawing.Point(12, 67);
            this.btnPencil.Name = "btnPencil";
            this.btnPencil.Size = new System.Drawing.Size(95, 23);
            this.btnPencil.TabIndex = 1;
            this.btnPencil.Text = "Карандаш";
            this.btnPencil.UseVisualStyleBackColor = true;
            this.btnPencil.Click += new System.EventHandler(this.btnPencil_Click);
            // 
            // btnLine
            // 
            this.btnLine.Location = new System.Drawing.Point(12, 96);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(95, 23);
            this.btnLine.TabIndex = 2;
            this.btnLine.Text = "Прямая";
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // btnTriangle
            // 
            this.btnTriangle.Location = new System.Drawing.Point(12, 125);
            this.btnTriangle.Name = "btnTriangle";
            this.btnTriangle.Size = new System.Drawing.Size(95, 23);
            this.btnTriangle.TabIndex = 3;
            this.btnTriangle.Text = "Треугольник";
            this.btnTriangle.UseVisualStyleBackColor = true;
            this.btnTriangle.Click += new System.EventHandler(this.btnTriangle_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.Location = new System.Drawing.Point(12, 154);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(95, 23);
            this.btnRectangle.TabIndex = 4;
            this.btnRectangle.Text = "Прямоугольник";
            this.btnRectangle.UseVisualStyleBackColor = true;
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // btnCircle
            // 
            this.btnCircle.Location = new System.Drawing.Point(12, 183);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(95, 23);
            this.btnCircle.TabIndex = 5;
            this.btnCircle.Text = "Окружность";
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // btnEllipse
            // 
            this.btnEllipse.Location = new System.Drawing.Point(12, 212);
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.Size = new System.Drawing.Size(95, 23);
            this.btnEllipse.TabIndex = 6;
            this.btnEllipse.Text = "Эллипс";
            this.btnEllipse.UseVisualStyleBackColor = true;
            this.btnEllipse.Click += new System.EventHandler(this.btnEllipse_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(38, 12);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(69, 20);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(113, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(780, 374);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseMove);
            this.pictureBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseUp);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 38);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(95, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFractal
            // 
            this.btnFractal.Location = new System.Drawing.Point(12, 350);
            this.btnFractal.Name = "btnFractal";
            this.btnFractal.Size = new System.Drawing.Size(95, 35);
            this.btnFractal.TabIndex = 10;
            this.btnFractal.Text = "Построить";
            this.btnFractal.UseVisualStyleBackColor = true;
            this.btnFractal.Click += new System.EventHandler(this.btnFractal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Фрактал Жулиа";
            // 
            // nudZoom
            // 
            this.nudZoom.Location = new System.Drawing.Point(64, 272);
            this.nudZoom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudZoom.Name = "nudZoom";
            this.nudZoom.Size = new System.Drawing.Size(43, 20);
            this.nudZoom.TabIndex = 12;
            this.nudZoom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudX
            // 
            this.nudX.Location = new System.Drawing.Point(64, 298);
            this.nudX.Name = "nudX";
            this.nudX.Size = new System.Drawing.Size(43, 20);
            this.nudX.TabIndex = 13;
            // 
            // nudY
            // 
            this.nudY.Location = new System.Drawing.Point(64, 324);
            this.nudY.Name = "nudY";
            this.nudY.Size = new System.Drawing.Size(43, 20);
            this.nudY.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Zoom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "По X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "По Y";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 396);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudY);
            this.Controls.Add(this.nudX);
            this.Controls.Add(this.nudZoom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFractal);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btnEllipse);
            this.Controls.Add(this.btnCircle);
            this.Controls.Add(this.btnRectangle);
            this.Controls.Add(this.btnTriangle);
            this.Controls.Add(this.btnLine);
            this.Controls.Add(this.btnPencil);
            this.Controls.Add(this.pbColor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Kraski.NET";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudZoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox pbColor;
        private System.Windows.Forms.Button btnPencil;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnTriangle;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Button btnEllipse;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnFractal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudZoom;
        private System.Windows.Forms.NumericUpDown nudX;
        private System.Windows.Forms.NumericUpDown nudY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

