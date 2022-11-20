
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
            this.numericUpDown_Point_Count = new System.Windows.Forms.NumericUpDown();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.label_Distance_Total = new System.Windows.Forms.Label();
            this.label_Min_Max = new System.Windows.Forms.Label();
            this.label_Total = new System.Windows.Forms.Label();
            this.label_Total1 = new System.Windows.Forms.Label();
            this.label_Distance_Current = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.button_Clear = new System.Windows.Forms.Button();
            this.label_Point_Count = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_Delay = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_File_Name = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Point_Count)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Delay)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown_Point_Count
            // 
            this.numericUpDown_Point_Count.Location = new System.Drawing.Point(15, 33);
            this.numericUpDown_Point_Count.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericUpDown_Point_Count.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown_Point_Count.Name = "numericUpDown_Point_Count";
            this.numericUpDown_Point_Count.Size = new System.Drawing.Size(113, 23);
            this.numericUpDown_Point_Count.TabIndex = 0;
            this.numericUpDown_Point_Count.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_Point_Count.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
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
            this.label_Min_Max.Location = new System.Drawing.Point(26, 9);
            this.label_Min_Max.Name = "label_Min_Max";
            this.label_Min_Max.Size = new System.Drawing.Size(86, 20);
            this.label_Min_Max.TabIndex = 15;
            this.label_Min_Max.Text = "Point count:";
            // 
            // label_Total
            // 
            this.label_Total.AutoSize = true;
            this.label_Total.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Total.Location = new System.Drawing.Point(45, 346);
            this.label_Total.Name = "label_Total";
            this.label_Total.Size = new System.Drawing.Size(45, 20);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Delay (seconds):";
            // 
            // numericUpDown_Delay
            // 
            this.numericUpDown_Delay.DecimalPlaces = 1;
            this.numericUpDown_Delay.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_Delay.Location = new System.Drawing.Point(15, 83);
            this.numericUpDown_Delay.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericUpDown_Delay.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown_Delay.Name = "numericUpDown_Delay";
            this.numericUpDown_Delay.Size = new System.Drawing.Size(113, 23);
            this.numericUpDown_Delay.TabIndex = 26;
            this.numericUpDown_Delay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_Delay.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(33, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "File name:";
            // 
            // textBox_File_Name
            // 
            this.textBox_File_Name.Location = new System.Drawing.Point(15, 132);
            this.textBox_File_Name.Name = "textBox_File_Name";
            this.textBox_File_Name.PlaceholderText = "Empty - no file";
            this.textBox_File_Name.Size = new System.Drawing.Size(113, 23);
            this.textBox_File_Name.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(585, 461);
            this.Controls.Add(this.textBox_File_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown_Delay);
            this.Controls.Add(this.label_Point_Count);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.label_Total1);
            this.Controls.Add(this.label_Distance_Current);
            this.Controls.Add(this.label_Total);
            this.Controls.Add(this.label_Min_Max);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.label_Distance_Total);
            this.Controls.Add(this.buttonDraw);
            this.Controls.Add(this.numericUpDown_Point_Count);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Oscilloscope Test";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Point_Count)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Delay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown_Point_Count;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.Label label_Distance_Total;
        private System.Windows.Forms.Label label_Min_Max;
        private System.Windows.Forms.Label label_Total;
        private System.Windows.Forms.Label label_Total1;
        private System.Windows.Forms.Label label_Distance_Current;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Label label_Point_Count;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_Delay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_File_Name;
    }
}

