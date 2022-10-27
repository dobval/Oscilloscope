
namespace Dobromir_Oscilloscope
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.numericUpDown_X_Min = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_X_Max = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Y_Min = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Y_Max = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_X = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Y = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.label_Distance_Total = new System.Windows.Forms.Label();
            this.label_Min_Max = new System.Windows.Forms.Label();
            this.label_Point = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label_Total = new System.Windows.Forms.Label();
            this.label_Total1 = new System.Windows.Forms.Label();
            this.label_Distance_Current = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.button_Clear = new System.Windows.Forms.Button();
            this.label_Point_Count = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_X_Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_X_Max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Y_Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Y_Max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown_X_Min
            // 
            this.numericUpDown_X_Min.DecimalPlaces = 1;
            this.numericUpDown_X_Min.Location = new System.Drawing.Point(77, 33);
            this.numericUpDown_X_Min.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericUpDown_X_Min.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown_X_Min.Name = "numericUpDown_X_Min";
            this.numericUpDown_X_Min.Size = new System.Drawing.Size(51, 23);
            this.numericUpDown_X_Min.TabIndex = 0;
            // 
            // numericUpDown_X_Max
            // 
            this.numericUpDown_X_Max.DecimalPlaces = 1;
            this.numericUpDown_X_Max.Location = new System.Drawing.Point(77, 63);
            this.numericUpDown_X_Max.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericUpDown_X_Max.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown_X_Max.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numericUpDown_X_Max.Name = "numericUpDown_X_Max";
            this.numericUpDown_X_Max.Size = new System.Drawing.Size(51, 23);
            this.numericUpDown_X_Max.TabIndex = 1;
            this.numericUpDown_X_Max.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDown_Y_Min
            // 
            this.numericUpDown_Y_Min.DecimalPlaces = 1;
            this.numericUpDown_Y_Min.Location = new System.Drawing.Point(77, 92);
            this.numericUpDown_Y_Min.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericUpDown_Y_Min.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown_Y_Min.Name = "numericUpDown_Y_Min";
            this.numericUpDown_Y_Min.Size = new System.Drawing.Size(51, 23);
            this.numericUpDown_Y_Min.TabIndex = 2;
            // 
            // numericUpDown_Y_Max
            // 
            this.numericUpDown_Y_Max.DecimalPlaces = 1;
            this.numericUpDown_Y_Max.Location = new System.Drawing.Point(77, 121);
            this.numericUpDown_Y_Max.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericUpDown_Y_Max.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown_Y_Max.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numericUpDown_Y_Max.Name = "numericUpDown_Y_Max";
            this.numericUpDown_Y_Max.Size = new System.Drawing.Size(51, 23);
            this.numericUpDown_Y_Max.TabIndex = 3;
            this.numericUpDown_Y_Max.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // numericUpDown_X
            // 
            this.numericUpDown_X.DecimalPlaces = 1;
            this.numericUpDown_X.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown_X.Location = new System.Drawing.Point(77, 196);
            this.numericUpDown_X.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericUpDown_X.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown_X.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numericUpDown_X.Name = "numericUpDown_X";
            this.numericUpDown_X.Size = new System.Drawing.Size(51, 23);
            this.numericUpDown_X.TabIndex = 4;
            // 
            // numericUpDown_Y
            // 
            this.numericUpDown_Y.DecimalPlaces = 1;
            this.numericUpDown_Y.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown_Y.Location = new System.Drawing.Point(77, 225);
            this.numericUpDown_Y.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericUpDown_Y.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown_Y.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numericUpDown_Y.Name = "numericUpDown_Y";
            this.numericUpDown_Y.Size = new System.Drawing.Size(51, 23);
            this.numericUpDown_Y.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "x =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(15, 109);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "y =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(38, 198);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "x =";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(38, 227);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "y =";
            // 
            // buttonDraw
            // 
            this.buttonDraw.AutoSize = true;
            this.buttonDraw.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDraw.Location = new System.Drawing.Point(15, 255);
            this.buttonDraw.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(112, 31);
            this.buttonDraw.TabIndex = 12;
            this.buttonDraw.Text = "Draw";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.Draw_Click);
            // 
            // label_Distance_Total
            // 
            this.label_Distance_Total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label_Distance_Total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Distance_Total.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Distance_Total.Location = new System.Drawing.Point(15, 366);
            this.label_Distance_Total.Name = "label_Distance_Total";
            this.label_Distance_Total.Size = new System.Drawing.Size(113, 31);
            this.label_Distance_Total.TabIndex = 13;
            this.label_Distance_Total.Text = "N/A";
            this.label_Distance_Total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Min_Max
            // 
            this.label_Min_Max.AutoSize = true;
            this.label_Min_Max.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Min_Max.Location = new System.Drawing.Point(15, 9);
            this.label_Min_Max.Name = "label_Min_Max";
            this.label_Min_Max.Size = new System.Drawing.Size(117, 20);
            this.label_Min_Max.TabIndex = 15;
            this.label_Min_Max.Text = "Min, Max values:";
            // 
            // label_Point
            // 
            this.label_Point.AutoSize = true;
            this.label_Point.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Point.Location = new System.Drawing.Point(15, 172);
            this.label_Point.Name = "label_Point";
            this.label_Point.Size = new System.Drawing.Size(46, 20);
            this.label_Point.TabIndex = 16;
            this.label_Point.Text = "Point:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(46, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "min";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(45, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "max";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(45, 123);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "max";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(46, 94);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "min";
            // 
            // label_Total
            // 
            this.label_Total.AutoSize = true;
            this.label_Total.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Total.Location = new System.Drawing.Point(45, 346);
            this.label_Total.Name = "label_Total";
            this.label_Total.Size = new System.Drawing.Size(46, 20);
            this.label_Total.TabIndex = 21;
            this.label_Total.Text = "Total:";
            // 
            // label_Total1
            // 
            this.label_Total1.AutoSize = true;
            this.label_Total1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Total1.Location = new System.Drawing.Point(38, 289);
            this.label_Total1.Name = "label_Total1";
            this.label_Total1.Size = new System.Drawing.Size(60, 20);
            this.label_Total1.TabIndex = 23;
            this.label_Total1.Text = "Current:";
            // 
            // label_Distance_Current
            // 
            this.label_Distance_Current.BackColor = System.Drawing.Color.White;
            this.label_Distance_Current.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Distance_Current.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Distance_Current.Location = new System.Drawing.Point(15, 310);
            this.label_Distance_Current.Name = "label_Distance_Current";
            this.label_Distance_Current.Size = new System.Drawing.Size(113, 31);
            this.label_Distance_Current.TabIndex = 22;
            this.label_Distance_Current.Text = "N/A";
            this.label_Distance_Current.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.ErrorImage")));
            this.pictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.InitialImage")));
            this.pictureBox.Location = new System.Drawing.Point(134, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(439, 440);
            this.pictureBox.TabIndex = 14;
            this.pictureBox.TabStop = false;
            // 
            // button_Clear
            // 
            this.button_Clear.AutoSize = true;
            this.button_Clear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Clear.Location = new System.Drawing.Point(15, 420);
            this.button_Clear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(112, 31);
            this.button_Clear.TabIndex = 24;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // label_Point_Count
            // 
            this.label_Point_Count.AutoSize = true;
            this.label_Point_Count.Location = new System.Drawing.Point(2, 403);
            this.label_Point_Count.Name = "label_Point_Count";
            this.label_Point_Count.Size = new System.Drawing.Size(57, 15);
            this.label_Point_Count.TabIndex = 25;
            this.label_Point_Count.Text = "point #: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(585, 461);
            this.Controls.Add(this.label_Point_Count);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.label_Total1);
            this.Controls.Add(this.label_Distance_Current);
            this.Controls.Add(this.label_Total);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_Point);
            this.Controls.Add(this.label_Min_Max);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.label_Distance_Total);
            this.Controls.Add(this.buttonDraw);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown_Y);
            this.Controls.Add(this.numericUpDown_X);
            this.Controls.Add(this.numericUpDown_Y_Max);
            this.Controls.Add(this.numericUpDown_Y_Min);
            this.Controls.Add(this.numericUpDown_X_Max);
            this.Controls.Add(this.numericUpDown_X_Min);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Oscilloscope Test";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_X_Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_X_Max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Y_Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Y_Max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown_X_Min;
        private System.Windows.Forms.NumericUpDown numericUpDown_X_Max;
        private System.Windows.Forms.NumericUpDown numericUpDown_Y_Min;
        private System.Windows.Forms.NumericUpDown numericUpDown_Y_Max;
        private System.Windows.Forms.NumericUpDown numericUpDown_X;
        private System.Windows.Forms.NumericUpDown numericUpDown_Y;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.Label label_Distance_Total;
        private System.Windows.Forms.Label label_Min_Max;
        private System.Windows.Forms.Label label_Point;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_Total;
        private System.Windows.Forms.Label label_Total1;
        private System.Windows.Forms.Label label_Distance_Current;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Label label_Point_Count;
    }
}

