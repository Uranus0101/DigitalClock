namespace DigitalClock
{
    partial class DigitalClock
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
            this.components = new System.ComponentModel.Container();
            this.ClockLabel = new System.Windows.Forms.Label();
            this.clockTimer = new System.Windows.Forms.Timer(this.components);
            this.grayButton = new System.Windows.Forms.Button();
            this.greenButton = new System.Windows.Forms.Button();
            this.blueButton = new System.Windows.Forms.Button();
            this.yellowButton = new System.Windows.Forms.Button();
            this.purpleButton = new System.Windows.Forms.Button();
            this.styleButton1 = new System.Windows.Forms.Button();
            this.styleButton2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClockLabel
            // 
            this.ClockLabel.BackColor = System.Drawing.Color.Black;
            this.ClockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClockLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClockLabel.Location = new System.Drawing.Point(12, 9);
            this.ClockLabel.Name = "ClockLabel";
            this.ClockLabel.Size = new System.Drawing.Size(1066, 454);
            this.ClockLabel.TabIndex = 0;
            this.ClockLabel.Text = "Loading...";
            this.ClockLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clockTimer
            // 
            this.clockTimer.Interval = 1100;
            this.clockTimer.Tick += new System.EventHandler(this.clockTimer_Tick);
            // 
            // grayButton
            // 
            this.grayButton.BackColor = System.Drawing.Color.Gray;
            this.grayButton.Location = new System.Drawing.Point(22, 498);
            this.grayButton.Name = "grayButton";
            this.grayButton.Size = new System.Drawing.Size(41, 35);
            this.grayButton.TabIndex = 1;
            this.grayButton.UseVisualStyleBackColor = false;
            this.grayButton.Click += new System.EventHandler(this.grayButton_Click);
            // 
            // greenButton
            // 
            this.greenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.greenButton.Location = new System.Drawing.Point(66, 498);
            this.greenButton.Name = "greenButton";
            this.greenButton.Size = new System.Drawing.Size(41, 35);
            this.greenButton.TabIndex = 2;
            this.greenButton.UseVisualStyleBackColor = false;
            this.greenButton.Click += new System.EventHandler(this.greenButton_Click);
            // 
            // blueButton
            // 
            this.blueButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.blueButton.Location = new System.Drawing.Point(113, 498);
            this.blueButton.Name = "blueButton";
            this.blueButton.Size = new System.Drawing.Size(41, 35);
            this.blueButton.TabIndex = 3;
            this.blueButton.UseVisualStyleBackColor = false;
            this.blueButton.Click += new System.EventHandler(this.blueButton_Click_1);
            // 
            // yellowButton
            // 
            this.yellowButton.BackColor = System.Drawing.Color.Yellow;
            this.yellowButton.Location = new System.Drawing.Point(160, 498);
            this.yellowButton.Name = "yellowButton";
            this.yellowButton.Size = new System.Drawing.Size(41, 35);
            this.yellowButton.TabIndex = 4;
            this.yellowButton.UseVisualStyleBackColor = false;
            this.yellowButton.Click += new System.EventHandler(this.yellowButton_Click_1);
            // 
            // purpleButton
            // 
            this.purpleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.purpleButton.Location = new System.Drawing.Point(207, 498);
            this.purpleButton.Name = "purpleButton";
            this.purpleButton.Size = new System.Drawing.Size(41, 35);
            this.purpleButton.TabIndex = 5;
            this.purpleButton.UseVisualStyleBackColor = false;
            this.purpleButton.Click += new System.EventHandler(this.purpelButton_Click);
            // 
            // styleButton1
            // 
            this.styleButton1.BackColor = System.Drawing.Color.White;
            this.styleButton1.Font = new System.Drawing.Font("Mongolian Baiti", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.styleButton1.Location = new System.Drawing.Point(265, 498);
            this.styleButton1.Name = "styleButton1";
            this.styleButton1.Size = new System.Drawing.Size(75, 34);
            this.styleButton1.TabIndex = 6;
            this.styleButton1.Text = "Style 1";
            this.styleButton1.UseVisualStyleBackColor = false;
            this.styleButton1.Click += new System.EventHandler(this.styleButton1_Click);
            // 
            // styleButton2
            // 
            this.styleButton2.BackColor = System.Drawing.Color.White;
            this.styleButton2.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.styleButton2.Location = new System.Drawing.Point(346, 499);
            this.styleButton2.Name = "styleButton2";
            this.styleButton2.Size = new System.Drawing.Size(75, 34);
            this.styleButton2.TabIndex = 7;
            this.styleButton2.Text = "Style 2";
            this.styleButton2.UseVisualStyleBackColor = false;
            this.styleButton2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(427, 498);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 34);
            this.button3.TabIndex = 8;
            this.button3.Text = "Style 3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // DigitalClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1090, 545);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.styleButton2);
            this.Controls.Add(this.styleButton1);
            this.Controls.Add(this.purpleButton);
            this.Controls.Add(this.yellowButton);
            this.Controls.Add(this.blueButton);
            this.Controls.Add(this.greenButton);
            this.Controls.Add(this.grayButton);
            this.Controls.Add(this.ClockLabel);
            this.Name = "DigitalClock";
            this.Text = "Digital Clock";
            this.Load += new System.EventHandler(this.DigitalClock_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ClockLabel;
        private System.Windows.Forms.Timer clockTimer;
        private System.Windows.Forms.Button grayButton;
        private System.Windows.Forms.Button greenButton;
        private System.Windows.Forms.Button blueButton;
        private System.Windows.Forms.Button yellowButton;
        private System.Windows.Forms.Button purpleButton;
        private System.Windows.Forms.Button styleButton1;
        private System.Windows.Forms.Button styleButton2;
        private System.Windows.Forms.Button button3;
    }
}

