namespace particleMod
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            picDisplay = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            tbDirection = new TrackBar();
            txtDirection = new TextBox();
            tbGravity = new TrackBar();
            txtGravity = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tbGravityPoint = new TrackBar();
            label3 = new Label();
            tbGravityPoint2 = new TrackBar();
            label4 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            tbSpeedRotation = new TrackBar();
            txtSpeedRotation = new TextBox();
            tbSize = new TrackBar();
            label5 = new Label();
            txtSize = new TextBox();
            ((System.ComponentModel.ISupportInitialize)picDisplay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbDirection).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbGravity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbGravityPoint).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbGravityPoint2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbSpeedRotation).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbSize).BeginInit();
            SuspendLayout();
            // 
            // picDisplay
            // 
            picDisplay.BackColor = Color.Transparent;
            picDisplay.InitialImage = null;
            picDisplay.Location = new Point(12, 12);
            picDisplay.Name = "picDisplay";
            picDisplay.Size = new Size(878, 519);
            picDisplay.SizeMode = PictureBoxSizeMode.StretchImage;
            picDisplay.TabIndex = 0;
            picDisplay.TabStop = false;
            picDisplay.MouseMove += picDisplay_MouseMove;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 40;
            timer1.Tick += timer1_Tick;
            // 
            // tbDirection
            // 
            tbDirection.Location = new Point(903, 30);
            tbDirection.Maximum = 359;
            tbDirection.Name = "tbDirection";
            tbDirection.Size = new Size(275, 45);
            tbDirection.TabIndex = 1;
            tbDirection.Value = 1;
            tbDirection.Scroll += trackBar1_Scroll;
            // 
            // txtDirection
            // 
            txtDirection.Location = new Point(1184, 30);
            txtDirection.Name = "txtDirection";
            txtDirection.Size = new Size(59, 23);
            txtDirection.TabIndex = 2;
            // 
            // tbGravity
            // 
            tbGravity.Location = new Point(903, 96);
            tbGravity.Maximum = 50;
            tbGravity.Name = "tbGravity";
            tbGravity.Size = new Size(275, 45);
            tbGravity.TabIndex = 3;
            tbGravity.Scroll += tbGravity_Scroll;
            // 
            // txtGravity
            // 
            txtGravity.Location = new Point(1184, 96);
            txtGravity.Name = "txtGravity";
            txtGravity.Size = new Size(59, 23);
            txtGravity.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(903, 12);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 5;
            label1.Text = "Направление";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(903, 78);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 6;
            label2.Text = "Гравитация";
            // 
            // tbGravityPoint
            // 
            tbGravityPoint.Location = new Point(1078, 475);
            tbGravityPoint.Maximum = 100;
            tbGravityPoint.Name = "tbGravityPoint";
            tbGravityPoint.Size = new Size(165, 45);
            tbGravityPoint.TabIndex = 7;
            tbGravityPoint.Scroll += tbGravityPoint_Scroll;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(903, 457);
            label3.Name = "label3";
            label3.Size = new Size(114, 15);
            label3.TabIndex = 8;
            label3.Text = "Гравитация точки 1";
            // 
            // tbGravityPoint2
            // 
            tbGravityPoint2.Location = new Point(907, 475);
            tbGravityPoint2.Maximum = 100;
            tbGravityPoint2.Name = "tbGravityPoint2";
            tbGravityPoint2.Size = new Size(165, 45);
            tbGravityPoint2.TabIndex = 9;
            tbGravityPoint2.Scroll += tbGravityPoint2_Scroll;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1078, 457);
            label4.Name = "label4";
            label4.Size = new Size(114, 15);
            label4.TabIndex = 10;
            label4.Text = "Гравитация точки 2";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(907, 412);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(164, 19);
            checkBox1.TabIndex = 12;
            checkBox1.Text = "Следование за курсором";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(907, 374);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(87, 19);
            checkBox2.TabIndex = 13;
            checkBox2.Text = "Вокруг оси";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // tbSpeedRotation
            // 
            tbSpeedRotation.Location = new Point(1000, 361);
            tbSpeedRotation.Maximum = 20;
            tbSpeedRotation.Name = "tbSpeedRotation";
            tbSpeedRotation.Size = new Size(178, 45);
            tbSpeedRotation.TabIndex = 14;
            tbSpeedRotation.Scroll += tbSpeedRotation_Scroll;
            // 
            // txtSpeedRotation
            // 
            txtSpeedRotation.Location = new Point(1184, 361);
            txtSpeedRotation.Name = "txtSpeedRotation";
            txtSpeedRotation.Size = new Size(59, 23);
            txtSpeedRotation.TabIndex = 15;
            // 
            // tbSize
            // 
            tbSize.Location = new Point(907, 162);
            tbSize.Maximum = 20;
            tbSize.Minimum = 2;
            tbSize.Name = "tbSize";
            tbSize.Size = new Size(271, 45);
            tbSize.TabIndex = 16;
            tbSize.Value = 2;
            tbSize.Scroll += tbSize_Scroll;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(903, 144);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 17;
            label5.Text = "Размер";
            // 
            // txtSize
            // 
            txtSize.Location = new Point(1184, 162);
            txtSize.Name = "txtSize";
            txtSize.Size = new Size(59, 23);
            txtSize.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1255, 539);
            Controls.Add(txtSize);
            Controls.Add(label5);
            Controls.Add(tbSize);
            Controls.Add(txtSpeedRotation);
            Controls.Add(tbSpeedRotation);
            Controls.Add(checkBox2);
            Controls.Add(picDisplay);
            Controls.Add(checkBox1);
            Controls.Add(label4);
            Controls.Add(tbGravityPoint2);
            Controls.Add(label3);
            Controls.Add(tbGravityPoint);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtGravity);
            Controls.Add(tbGravity);
            Controls.Add(txtDirection);
            Controls.Add(tbDirection);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)picDisplay).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbDirection).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbGravity).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbGravityPoint).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbGravityPoint2).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbSpeedRotation).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbSize).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picDisplay;
        private System.Windows.Forms.Timer timer1;
        private TrackBar tbDirection;
        private TextBox txtDirection;
        private TrackBar tbGravity;
        private TextBox txtGravity;
        private Label label1;
        private Label label2;
        private TrackBar tbGravityPoint;
        private Label label3;
        private TrackBar tbGravityPoint2;
        private Label label4;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private TrackBar tbSpeedRotation;
        private TextBox txtSpeedRotation;
        private TrackBar tbSize;
        private Label label5;
        private TextBox txtSize;
    }
}
