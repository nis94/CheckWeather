namespace WeatherApp
{
    partial class FormWeather
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
            this.pictureBoxWeather = new System.Windows.Forms.PictureBox();
            this.labelTemp = new System.Windows.Forms.Label();
            this.labeltemprature = new System.Windows.Forms.Label();
            this.labelWndSpd = new System.Windows.Forms.Label();
            this.labelWindSpeed = new System.Windows.Forms.Label();
            this.labelTZ = new System.Windows.Forms.Label();
            this.labelTimeZone = new System.Windows.Forms.Label();
            this.labelSR = new System.Windows.Forms.Label();
            this.labelSS = new System.Windows.Forms.Label();
            this.labelSunRise = new System.Windows.Forms.Label();
            this.labelSunSet = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWeather)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxWeather
            // 
            this.pictureBoxWeather.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pictureBoxWeather.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxWeather.Location = new System.Drawing.Point(293, 12);
            this.pictureBoxWeather.Name = "pictureBoxWeather";
            this.pictureBoxWeather.Size = new System.Drawing.Size(100, 81);
            this.pictureBoxWeather.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxWeather.TabIndex = 0;
            this.pictureBoxWeather.TabStop = false;
            // 
            // labelTemp
            // 
            this.labelTemp.AutoSize = true;
            this.labelTemp.Location = new System.Drawing.Point(12, 76);
            this.labelTemp.Name = "labelTemp";
            this.labelTemp.Size = new System.Drawing.Size(90, 17);
            this.labelTemp.TabIndex = 1;
            this.labelTemp.Text = "Tempratue - ";
            // 
            // labeltemprature
            // 
            this.labeltemprature.AutoSize = true;
            this.labeltemprature.Location = new System.Drawing.Point(97, 76);
            this.labeltemprature.Name = "labeltemprature";
            this.labeltemprature.Size = new System.Drawing.Size(0, 17);
            this.labeltemprature.TabIndex = 2;
            // 
            // labelWndSpd
            // 
            this.labelWndSpd.AutoSize = true;
            this.labelWndSpd.Location = new System.Drawing.Point(12, 116);
            this.labelWndSpd.Name = "labelWndSpd";
            this.labelWndSpd.Size = new System.Drawing.Size(94, 17);
            this.labelWndSpd.TabIndex = 3;
            this.labelWndSpd.Text = "Wind Speed -";
            // 
            // labelWindSpeed
            // 
            this.labelWindSpeed.AutoSize = true;
            this.labelWindSpeed.Location = new System.Drawing.Point(103, 116);
            this.labelWindSpeed.Name = "labelWindSpeed";
            this.labelWindSpeed.Size = new System.Drawing.Size(0, 17);
            this.labelWindSpeed.TabIndex = 4;
            // 
            // labelTZ
            // 
            this.labelTZ.AutoSize = true;
            this.labelTZ.Location = new System.Drawing.Point(12, 35);
            this.labelTZ.Name = "labelTZ";
            this.labelTZ.Size = new System.Drawing.Size(85, 17);
            this.labelTZ.TabIndex = 5;
            this.labelTZ.Text = "Time Zone -";
            // 
            // labelTimeZone
            // 
            this.labelTimeZone.AutoSize = true;
            this.labelTimeZone.Location = new System.Drawing.Point(97, 35);
            this.labelTimeZone.Name = "labelTimeZone";
            this.labelTimeZone.Size = new System.Drawing.Size(0, 17);
            this.labelTimeZone.TabIndex = 6;
            // 
            // labelSR
            // 
            this.labelSR.AutoSize = true;
            this.labelSR.Location = new System.Drawing.Point(12, 158);
            this.labelSR.Name = "labelSR";
            this.labelSR.Size = new System.Drawing.Size(65, 17);
            this.labelSR.TabIndex = 7;
            this.labelSR.Text = "Sunrise -";
            // 
            // labelSS
            // 
            this.labelSS.AutoSize = true;
            this.labelSS.Location = new System.Drawing.Point(12, 199);
            this.labelSS.Name = "labelSS";
            this.labelSS.Size = new System.Drawing.Size(61, 17);
            this.labelSS.TabIndex = 8;
            this.labelSS.Text = "Sunset -";
            // 
            // labelSunRise
            // 
            this.labelSunRise.AutoSize = true;
            this.labelSunRise.Location = new System.Drawing.Point(83, 158);
            this.labelSunRise.Name = "labelSunRise";
            this.labelSunRise.Size = new System.Drawing.Size(0, 17);
            this.labelSunRise.TabIndex = 9;
            // 
            // labelSunSet
            // 
            this.labelSunSet.AutoSize = true;
            this.labelSunSet.Location = new System.Drawing.Point(79, 199);
            this.labelSunSet.Name = "labelSunSet";
            this.labelSunSet.Size = new System.Drawing.Size(0, 17);
            this.labelSunSet.TabIndex = 10;
            // 
            // FormWeather
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(405, 333);
            this.Controls.Add(this.labelSunSet);
            this.Controls.Add(this.labelSunRise);
            this.Controls.Add(this.labelSS);
            this.Controls.Add(this.labelSR);
            this.Controls.Add(this.labelTimeZone);
            this.Controls.Add(this.labelTZ);
            this.Controls.Add(this.labelWindSpeed);
            this.Controls.Add(this.labelWndSpd);
            this.Controls.Add(this.labeltemprature);
            this.Controls.Add(this.labelTemp);
            this.Controls.Add(this.pictureBoxWeather);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormWeather";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormWeather";
            this.Shown += new System.EventHandler(this.FormWeather_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWeather)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxWeather;
        private System.Windows.Forms.Label labelTemp;
        private System.Windows.Forms.Label labeltemprature;
        private System.Windows.Forms.Label labelWndSpd;
        private System.Windows.Forms.Label labelWindSpeed;
        private System.Windows.Forms.Label labelTZ;
        private System.Windows.Forms.Label labelTimeZone;
        private System.Windows.Forms.Label labelSR;
        private System.Windows.Forms.Label labelSS;
        private System.Windows.Forms.Label labelSunRise;
        private System.Windows.Forms.Label labelSunSet;
    }
}